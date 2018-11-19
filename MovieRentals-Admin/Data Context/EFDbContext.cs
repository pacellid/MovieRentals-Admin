using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Domonic.Models;

namespace Domonic.Data_Context
{
    public class EFDbContext : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }

        public EFDbContext() : base("name=movieRentalDbContext")
        {

        }
    }
}
