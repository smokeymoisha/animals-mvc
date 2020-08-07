using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using DataAccessLayer;

namespace BusinessLayer.Managers
{
    public class EmployeeManager : UserManager<Employee>
    {
        public EmployeeManager(IUserStore<Employee> store) : base(store)
        {

        }

        public static EmployeeManager Create(IdentityFactoryOptions<EmployeeManager> options,
            IOwinContext context)
        {
            AnimalsContext db = context.Get<AnimalsContext>();
            EmployeeManager manager = new EmployeeManager(new UserStore<Employee>(db));

            return manager;
        }
    }
}
