using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class AnimalsRepository : IAnimalsRepository
    {
        public IList<Cat> GetAllCats()
        {
            using(var ctx = new AnimalsContext())
            {
                return ctx.Cats.Include(cat => cat.Home).ToList();
            }
        }

        public IList<Home> GetAllHomes()
        {
            using (var ctx = new AnimalsContext())
            {
                return ctx.Homes.Include(home => home.Cats).ToList();
            }
        }
    }

    public interface IAnimalsRepository
    {
        IList<Cat> GetAllCats();
        IList<Home> GetAllHomes();
    }
}
