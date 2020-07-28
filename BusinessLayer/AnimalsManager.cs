using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Models;

namespace BusinessLayer
{
    public class AnimalsManager
    {
        private readonly AnimalsRepository _animalsRepository;
        private readonly Mapper _mapper;

        public AnimalsManager()
        {
            _animalsRepository = new AnimalsRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cat, CatModel>();
                cfg.CreateMap<Home, HomeModel>();
                cfg.CreateMap<CatModel, Cat>();
                cfg.CreateMap<HomeModel, Home>();
            });

            _mapper = new Mapper(config);
        }

        public IList<CatModel> GetAllCats()
        {
            var catList = _animalsRepository.GetAllCats();

            var result = _mapper.Map<IList<CatModel>>(catList);

            return result;
        }

        public IList<HomeModel> GetAllHomes()
        {
            var homeList = _animalsRepository.GetAllHomes();

            var result = _mapper.Map<IList<HomeModel>>(homeList);

            return result;
        }
    }
}
