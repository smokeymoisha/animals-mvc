﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_MVC.Models
{
    public interface IGetAll
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
