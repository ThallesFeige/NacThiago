using Microsoft.EntityFrameworkCore;
using Rm82099.Nac1.Bruno.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Rm82099.Nac1.Bruno.Web.Persistencia
{
    public class marketContext : DbContext
    {

        public DbSet<Mercado> Mercadinhos { get; set; }

        
        public marketContext(DbContextOptions options) : base(options) { }


    }
}
