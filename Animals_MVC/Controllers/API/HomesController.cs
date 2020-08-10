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
        private readonly IMapper _mapper;
        private readonly IAnimalsManager _animalsManager;
        private readonly IJsonConverter _jsonConverter;

        public HomesController(IAnimalsManager animalsManager, IJsonConverter jsonConverter,
            IMapper mapper)
        {
            _animalsManager = animalsManager;
            _jsonConverter = jsonConverter;
            _mapper = mapper;
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
