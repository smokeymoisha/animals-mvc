using Animals_MVC.Models;
using BusinessLayer.Managers;
using DataAccessLayer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Animals_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterPostModel model)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            var employee = new Employee
            {
                Email = model.Email,
                UserName = model.Username,
                BirthdayDate = DateTime.Now
            };

            await userManager.CreateAsync(employee, model.Password);

            // s metanita
            //if (result.Succeeded)
            //{
            //    var identityClaim = new IdentityUserClaim { ClaimType = "Language", ClaimValue = "" };

            //    employee.Claims.Add(identityClaim);

            //    await userManager.UpdateAsync(employee);
            //}
            // s metanita

            //var roleManager = HttpContext.GetOwinContext().Get<RoleManager<IdentityRole>>();

            //var adminRole = new IdentityRole { Name = "Admin" };

            //await roleManager.CreateAsync(adminRole);

            var createdUser = await userManager.FindAsync(model.Username, model.Password);
            //await userManager.AddToRoleAsync(createdUser.Id, "Admin");

            return View("Index");
        }
    }
}