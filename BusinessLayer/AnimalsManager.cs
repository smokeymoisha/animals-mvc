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
    public class AnimalsManager : IAnimalsManager
    {
        private readonly IAnimalsRepository _animalsRepository;
        private readonly IMapper _mapper;

        public AnimalsManager(IAnimalsRepository animalsRepository, IMapper mapper)
        {
            _animalsRepository = animalsRepository;
            _mapper = mapper;
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

    public interface IAnimalsManager
    {
        IList<CatModel> GetAllCats();
        IList<HomeModel> GetAllHomes();
    }
}
