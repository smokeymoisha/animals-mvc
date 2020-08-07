using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_MVC.Models
{
    public class CatViewModel : IGetAll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MyIgnore]
        public int Age { get; set; }

        //public HomeViewModel Home { get; set; }
    }
}