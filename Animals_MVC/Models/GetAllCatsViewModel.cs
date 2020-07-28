using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_MVC.Models
{
    public class GetAllCatsViewModel
    {
        public GetAllCatsViewModel()
        {
            Cats = new List<CatViewModel>();
        }
        public IList<CatViewModel> Cats { get; set; }
    }
}