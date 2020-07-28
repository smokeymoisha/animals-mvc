using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class HomeModel
    {
        public HomeModel()
        {
            Cats = new List<CatModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CatModel> Cats { get; set; }
    }
}
