using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_TeamAywan.Data
{
    public class GMemberDbContext : DbContext
    {
        public GMemberDbContext(DbContextOptions<GMemberDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Members> Member { get; set; }
    }
}
