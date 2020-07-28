﻿using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AnimalsContext : DbContext
    {
        public AnimalsContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Home> Homes { get; set; }
    }
}
