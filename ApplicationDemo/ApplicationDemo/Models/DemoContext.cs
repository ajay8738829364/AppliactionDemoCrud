using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDemo.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext>options):base(options)
        { }
        public DbSet<Demo> Demos { get; set; }
    }
}
