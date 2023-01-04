using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using TrPo.Models;
using MimeKit;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace TrPo.Controllers
{
    public class HomeController : Controller
    {
        private UserContext db;

        public HomeController(UserContext context)
        {
            db = context;
        }

        [HttpPost]
        public void TestMe()
        {
            Debug.WriteLine("NICEEEEEEE");
        }

        public async Task<IActionResult> Index()
        {
            var tr = await db.Translations.ToListAsync();
            Translation temp = new Translation();
            Translation translation = new Translation();
            for (int i = 0; i < tr.Count; i++)
            {
                translation = await db.Translations.FirstOrDefaultAsync(t => t.Code == tr[i].Code);
                if (translation != null)
                {
                    temp = await YouTubeBroadcastService.BroadcastInformation(tr[i].Code);
                    translation.Name = temp.Name;
                    translation.Condition = temp.Condition;
                }
                await db.SaveChangesAsync();
            }
            return View(await db.Translations.ToListAsync());
        }

        public IActionResult Help()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Help(HelpModel model, string OurEmail)
        {
            if(ModelState.IsValid)
            {
                EmailService emailService = new EmailService();
                MimeMessage emailMessage = new MimeMessage
                {
                    Subject = "Вопросик",
                    Body = new BodyBuilder() { HtmlBody = $"<div style=\"font-size: 20px;\"><h2>От {model.Email}</h2>{model.Question}</div>" }.ToMessageBody()
                };
                await emailService.SendEmailAsync(OurEmail, OurEmail, emailMessage);

                //Потом Ден добавит страничку тип успешно отправлено на несколько секунд

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HelpIndex(string FirstName, string Email, string LastName, string Question)
        {
            if (ModelState.IsValid)
            {
                string OurEmail = "LookToHelper@gmail.com";
                EmailService emailService = new EmailService();
                MimeMessage emailMessage = new MimeMessage
                {
                    Subject = "Вопросик",
                    Body = new BodyBuilder() { HtmlBody = $"<div style=\"font-size: 20px;\"><h1>{LastName} {FirstName}</h1><h2>От {Email}</h2>{Question}</div>" }.ToMessageBody()
                };
                await emailService.SendEmailAsync(OurEmail, OurEmail, emailMessage);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

    }
}
