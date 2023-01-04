using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using TrPo.Models;
using System.Security.Claims;
using System;
using MimeKit;
using Microsoft.AspNetCore.Authorization;

namespace TrPo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserContext db;

        static private int code = 0;

        public object Assert { get; private set; }

        public AccountController(UserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Authorization()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authorization(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("err", "Неверный логин и(или) пароль");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    return await SendEmail(model.Email, model.Nickname, model.FirstName, model.Password, model.LastName);
                }
                else
                {
                    ModelState.AddModelError("addr", "Введённый адрес уже зарегистрирован!");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ConfirmEmail()
        {
            if (!TempData.ContainsKey("email"))
            {
                return RedirectToAction("Authorization", "Account");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmEmail(string emailcode, string Email, string Nickname,
            string FirstName, string Password, string LastName)
        {
            if (ModelState.IsValid)
            {
                if (code.ToString() == emailcode)
                {
                    User user = new User
                    {
                        Email = Email,
                        Password = Password,
                        Nickname = Nickname,
                        FirstName = FirstName,
                        LastName = LastName,
                        Avatar = ""
                    };

                    Role userRole = await db.Roles.FirstOrDefaultAsync(r => r.Name == "user");
                    if (userRole != null)
                    {
                        user.Role = userRole;
                    }

                    db.Users.Add(user);

                    await db.SaveChangesAsync();

                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("InvalidCode", "Код подтверждения введён неверно!");
                    TempData["email"] = Email;
                    TempData["nickname"] = Nickname;
                    TempData["firstname"] = FirstName;
                    TempData["password"] = Password;
                    TempData["lastname"] = LastName;
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SendEmail(string email, string nickname,
            string firstName, string password, string lastName)
        {
            var rand = new Random();
            code = rand.Next(100000, 999999);

            EmailService emailService = new EmailService();
            MimeMessage emailMessage = new MimeMessage()
            {
                Subject = "Подтверждение почты",
                Body = new BodyBuilder() { HtmlBody = $"<div style=\"font-size: 20px;\">{code}</div>" }.ToMessageBody()
            };

            await emailService.SendEmailAsync(email, "LookToHelper@gmail.com", emailMessage);

            TempData["email"] = email;
            TempData["nickname"] = nickname;
            TempData["firstname"] = firstName;
            TempData["password"] = password;
            TempData["lastname"] = lastName;

            return RedirectToAction("ConfirmEmail", "Account");
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

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
