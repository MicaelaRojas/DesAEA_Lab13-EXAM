using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace APITecsup.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = MyContextDB") { }

     

        public DbSet<Producto> Producto { get; set; }

        

    }

}