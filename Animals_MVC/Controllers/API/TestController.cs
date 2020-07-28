using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Animals_MVC.Models;
using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;

namespace Animals_MVC.Controllers.API
{
    public class TestController : ApiController
    {
        private readonly Mapper _mapper;
        private readonly AnimalsManager _animalsManager;

        public TestController()
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

        // GET: api/Test
        public IEnumerable<CatViewModel> Get()
        {
            var catList = _animalsManager.GetAllCats();

            var result = _mapper.Map<IEnumerable<CatViewModel>>(catList);

            return result;
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
