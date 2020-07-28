using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Home Home { get; set; }
    }
}
