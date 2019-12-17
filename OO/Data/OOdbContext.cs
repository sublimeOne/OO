using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OO.Models;

namespace OO.Models.Data
{
    public class OOdbContext : DbContext
    {
        public OOdbContext (DbContextOptions<OOdbContext> options)
            : base(options)
        {
        }

        public DbSet<OO.Models.User> User { get; set; }
    }
}
