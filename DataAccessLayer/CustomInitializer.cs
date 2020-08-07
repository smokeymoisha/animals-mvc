using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomInitializer : CreateDatabaseIfNotExists<AnimalsContext>
    {
        protected override void Seed(AnimalsContext context)
        {
            var cats = new List<Cat>
            {
                new Cat {Name = "Mursik", Age = 3},
                new Cat {Name = "Barsik", Age = 7},
                new Cat {Name = "Basilio", Age = 5}
            };

            var homes = new List<Home>
            {
                new Home {Name = "Pavlovskaya, 5"},
                new Home {Name = "Sumskaya, 34"}
            };

            cats[0].Home = homes[0];
            cats[1].Home = homes[0];
            cats[2].Home = homes[1];

            context.Cats.AddRange(cats);
            context.Homes.AddRange(homes);

            context.SaveChanges();
        }
    }
}
