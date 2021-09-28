using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Autos;

namespace WebApiEjemplo
{
    public class ApplicationDbContent : DbContext
    {
        public ApplicationDbContent( DbContextOptions options) : base(options)
        {
        }
        public DbSet <Automovil> Automoviles{ get; set; }
    }
}
