using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Animals_MVC.Models
{
    public class GetAllHomesViewModel
    {
        public GetAllHomesViewModel()
        {
            Homes = new List<HomeViewModel>();
        }
        public IList<HomeViewModel> Homes { get; set; }
    }
}