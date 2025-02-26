using CSharpNet8Login.Entities;
using CSharpNet8Login.Models;
using Microsoft.AspNetCore.Mvc;

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
                _context.UserAccounts.Add(account);
                _context.SaveChanges();

                ModelState.Clear();

                //return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
