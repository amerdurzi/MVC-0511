using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_CodeAlong_110518_Amer.Models;

namespace MVC_CodeAlong_110518_Amer.DataAccessLayer
{
    public class RegisterContext:DbContext
    {
        public RegisterContext() : base("CodeAlong-110518")
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}