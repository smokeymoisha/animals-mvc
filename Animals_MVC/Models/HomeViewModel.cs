using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_MVC.Models
{
    public class HomeViewModel : IGetAll
    {
        public HomeViewModel()
        {
            //Cats = new List<CatViewModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<CatViewModel> Cats { get; set; }
    }
}