using FormaOne_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormaOne_MVC.DataContext
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DataConnection")
        {

        }
        public DbSet<FormaOneTeam> Teams { get; set; }
    }
}