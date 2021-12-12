using LTD_Asm.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTD_Asm.Data
{
    public class MyDbContext :DbContext
    {
        public MyDbContext():base("name=MyDbContext")
        {

        }
        public DbSet<Student> MyProperty { get; set; }
    }
}