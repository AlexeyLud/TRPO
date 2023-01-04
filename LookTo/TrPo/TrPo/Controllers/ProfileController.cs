using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrPo.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using MimeKit;
using Microsoft.AspNetCore.Authorization;
using System;

namespace TrPo.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserContext db;

        public ProfileController(UserContext context)
        {
            db = context;
        }

        [Authorize]
        public async Task<IActionResult> UserProfile()
        {
            return View(await db.UsersBroadcasts.ToListAsync());
        }

        [HttpGet]
        [Authorize]
        public IActionResult CreateBroadcast()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBroadcast(string Code)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Translation translation = await db.Translations.FirstOrDefaultAsync(t => t.Code == Code);
                    if (translation == null)
                    {
                        translation = await YouTubeBroadcastService.BroadcastInformation(Code);

                        db.Translations.Add(translation);

                        await db.SaveChangesAsync();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"{ex.Message}");
                }

                return RedirectToAction("UserProfile", "Profile");
            }
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult ChangeInfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeInfo(ChangeInfoModel model, string Email)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Email == Email);
                if (user != null)
                {
                    var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot", "avatars", model.Avatar.FileName); //изменить место хранения аватаров, а может и нет)

                    await model.Avatar.CopyToAsync(new FileStream(path, FileMode.Create));

                    Debug.WriteLine(model.Avatar);

                    path = "/avatars/" + model.Avatar.FileName;

                    user.Avatar = path;

                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    await db.SaveChangesAsync();


                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    await Authenticate(user);
                    return RedirectToAction("UserProfile", "Profile");
                }
            }


            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model, string Email)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(x => x.Email == Email);
                if (user.Password != model.OldPassword)
                {
                    ModelState.AddModelError("old", "Неправильно введён старый пароль");
                    return View(model);
                }
                else if (model.NewPassword == model.OldPassword)
                {
                    ModelState.AddModelError("new", "Новый пароль не может быть похож на старый");
                    return View(model);
                }
                user.Password = model.NewPassword;

                db.SaveChanges();

                return RedirectToAction("UserProfile", "Profile");
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Specialist()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Specialist(BecomeSpecialist model, string OurEmail)
        {
            if (ModelState.IsValid)
            {
                MimeMessage becomeMessage = new MimeMessage()
                {
                    Body = new BodyBuilder() { HtmlBody = $"<div style=\"font-size: 20px;\">{model.Email}</div>" }.ToMessageBody()
                };

                EmailService emailService = new EmailService();
                await emailService.SendEmailAsync(model.Email, OurEmail, becomeMessage);

                return RedirectToAction("Index", "Home");
                
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult MakeSpecialist()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MakeSpecialist(string UserEmail)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == UserEmail);
                if (user != null)
                {
                    Role userRole = await db.Roles.FirstOrDefaultAsync(r => r.Name == "mentor");
                    if (userRole != null)
                    {
                        user.Role = userRole;
                    }
                    await db.SaveChangesAsync();

                    return View(); // мб будет выводит "пользователь А стал ментором" или нет такого пользователя
                }
            }
            return View();
        }

        [HttpPost]
        public async Task AddBroadcastToPlanned(string UserEmail, string Code)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == UserEmail);
                if (user != null)
                {
                    Translation broadcast = await db.Translations.FirstOrDefaultAsync(b => b.Code == Code);
                    if (broadcast != null)
                    {
                        BroadcastList broadcastList = await db.UsersBroadcasts.FirstOrDefaultAsync(b =>
                        b.Code == broadcast.Code && b.UserId == user.Id);
                        if (broadcastList == null)
                        {
                            broadcastList = new BroadcastList()
                            {
                                Code = broadcast.Code,
                                UserId = user.Id,
                                Condition = "planned",
                                Name = broadcast.Name
                            };
                            await db.UsersBroadcasts.AddAsync(broadcastList);
                        }
                    }
                }
                await db.SaveChangesAsync();
            }
        }

        [HttpPost]
        public async Task ChangeCondition(string UserEmail, string Code)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == UserEmail);
                if (user != null)
                {
                    Translation broadcast = await db.Translations.FirstOrDefaultAsync(b => b.Code == Code);
                    if (broadcast != null)
                    {
                        BroadcastList broadcastList = await db.UsersBroadcasts.FirstOrDefaultAsync(b =>
                        b.Code == broadcast.Code && b.UserId == user.Id);
                        if (broadcastList != null)
                        {
                            broadcastList.Condition = "viewed";
                            //await db.UsersBroadcasts.AddAsync(broadcastList);
                        }
                        await db.SaveChangesAsync();
                    }
                }
                await db.SaveChangesAsync();
            }
        }

        private async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Nickname),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name),
                new Claim("email", user.Email),
                new Claim("firstname", user.FirstName),
                new Claim("lastname", user.LastName),
                new Claim("avatar", user.Avatar),
                new Claim("id", user.Id.ToString())
                };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookies", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

    }
}
