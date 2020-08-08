using Animals_MVC.Models;
using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Animals_MVC.Controllers.API
{
    public class HomesController : ApiController
    {
        private readonly Mapper _mapper;
        private readonly AnimalsManager _animalsManager;
        private readonly JsonConverter _jsonConverter;

        public HomesController()
        {
            _animalsManager = new AnimalsManager();
            _jsonConverter = new JsonConverter();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CatModel, CatViewModel>();
                cfg.CreateMap<HomeModel, HomeViewModel>();
                cfg.CreateMap<CatViewModel, CatModel>();
                cfg.CreateMap<HomeViewModel, HomeModel>();
            });

            _mapper = new Mapper(config);
        }

        // GET: api/Homes
        public string Get()
        {
            var homeList = _animalsManager.GetAllHomes();

            var result = _mapper.Map<IEnumerable<HomeViewModel>>(homeList);

            return _jsonConverter.Convert(result);
        }

        // GET: api/Homes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Homes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Homes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Homes/5
        public void Delete(int id)
        {
        }
    }
}
