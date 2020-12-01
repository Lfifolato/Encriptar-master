using Encriptar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Encriptar.Data
{
    public class DataContext : DbContext
    {
        public DbSet<crip> crips { get; set; }
    }
}