using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;
using Animals_MVC.Models;
using AutoMapper;
using BusinessLayer;
using BusinessLayer.Models;

namespace Animals_MVC.Controllers.API
{
    public class AnimalsController : ApiController
    {
        private readonly Mapper _mapper;
        private readonly AnimalsManager _animalsManager;
        private readonly JsonConverter _jsonConverter;

        public AnimalsController()
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

        // GET: api/Test
        public IHttpActionResult Get()
        {
            var catList = _animalsManager.GetAllCats();

            var result = _mapper.Map<IEnumerable<CatViewModel>>(catList);

            //var sb = new StringBuilder();
            //sb.Append("[");

            //foreach(var cat in result)
            //{
            //    var json = _jsonConverter.Convert(cat);

            //    sb.Append(json);
            //}

            //sb.Append("]");

            return Json(result);
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
