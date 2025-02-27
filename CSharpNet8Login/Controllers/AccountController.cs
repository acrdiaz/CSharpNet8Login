using CSharpNet8Login.Entities;
using CSharpNet8Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpNet8Login.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserAccount account = new UserAccount
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Username = model.Username,
                    Password = model.Password
                };
                try
                {
                    _context.UserAccounts.Add(account);
                    _context.SaveChanges();

                    ModelState.Clear();
                    ViewBag.Message = $"{account.FirstName} {account.LastName} registered successfully. Proceed to login.";

                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "Please enter unique email");
                    return View(model);
                }
                //return RedirectToAction("Index");
                return View();
            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.UserAccounts.Where(
                        u => (u.Email == model.UsernameOrEmail || u.Username == model.UsernameOrEmail)
                        && u.Password == model.Password
                    ).FirstOrDefault();

                if (user != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password"); // AA1 does this message require imrpovements?
                }

                ModelState.AddModelError("", "Invalid email or password");
            }
            return View(model);
        }

        public IActionResult SecurePage()
        {
            //return RedirectToAction("Login");
            return View();
        }
    }
}
