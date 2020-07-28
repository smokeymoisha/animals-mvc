using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Home
    {
        public Home()
        {
            Cats = new List<Cat>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Cat> Cats { get; set; }
    }
}
