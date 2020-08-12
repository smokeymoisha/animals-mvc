using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Employee : IdentityUser
    {
        public DateTime BirthdayDate { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
        public string Language { get; set; }
    }
}
