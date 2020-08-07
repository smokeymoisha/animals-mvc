using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Animals_MVC.Models;
using AutoMapper;
using BusinessLayer;
using BusinessLayer.Managers;
using BusinessLayer.Models;
using DataAccessLayer.Models;
using Microsoft.AspNet.Identity.Owin;

namespace Animals_MVC.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly Mapper _mapper;
        private readonly AnimalsManager _animalsManager;

        public AnimalsController()
        {
            _animalsManager = new AnimalsManager();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CatViewModel, CatModel>();
                cfg.CreateMap<HomeViewModel, HomeModel>();
                cfg.CreateMap<CatModel, CatViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();
            });

            _mapper = new Mapper(config);
        }

        public async Task<ActionResult> Cats()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<EmployeeManager>();
            var authManager = HttpContext.GetOwinContext().Authentication;

            var auth = User.Identity.IsAuthenticated;

            //var createdUser = await userManager.CreateAsync(new Employee
            //{
            //    LastName = "Magula",
            //    City = "Kharkov",
            //    BirthdayDate = DateTime.Now,
            //    Email = "allcity@gmail.com",
            //    UserName = "sanya"
            //}, "qwerty");

            var catList = _animalsManager.GetAllCats();

            var result = new GetAllCatsViewModel();
            result.Cats = _mapper.Map<IList<CatViewModel>>(catList);

            return View(result);
        }

        public ActionResult Homes()
        {
            var homeList = _animalsManager.GetAllHomes();

            var result = new GetAllHomesViewModel();
            result.Homes = _mapper.Map<IList<HomeViewModel>>(homeList);

            return View(result);
        }
    }
}