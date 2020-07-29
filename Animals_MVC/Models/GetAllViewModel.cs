using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_MVC.Models
{
    public class GetAllViewModel
    {
        public GetAllViewModel()
        {
            Cats = new List<CatViewModel>();
            Homes = new List<HomeViewModel>();
        }

        public IList<CatViewModel> Cats { get; set; }
        public IList<HomeViewModel> Homes { get; set; }
    }
}