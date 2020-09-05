using DA.Cantons;
using Microsoft.EntityFrameworkCore;
using System;

namespace DA
{
    public class AppContext : DbContext
    {
        public DbSet<Canton> Cantons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=.;Database=AndreyQuesadaDB;Trusted_Connection=True;MultipleActiveResultSets=True;Integrated Security=true");
            }
        }

    }
}
