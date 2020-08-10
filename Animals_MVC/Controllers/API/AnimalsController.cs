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
        private readonly IMapper _mapper;
        private readonly IAnimalsManager _animalsManager;
        private readonly IJsonConverter _jsonConverter;

        public AnimalsController(IAnimalsManager animalsManager, IJsonConverter jsonConverter,
            IMapper mapper)
        {
            _animalsManager = animalsManager;
            _jsonConverter = jsonConverter;
            _mapper = mapper;
        }

        // GET: api/Test
        public string Get()
        {
            var catList = _animalsManager.GetAllCats();

            var result = _mapper.Map<IEnumerable<CatViewModel>>(catList);

            return _jsonConverter.Convert(result);
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
