using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Entenies
{
    public class SocialNetworkContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<User> Users { get; set; }
        

        public SocialNetworkContext() : base("SocialNDB")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(p => p.Messages).WithRequired(p => p.User);
            modelBuilder.Entity<Info>().HasRequired(p => p.User).WithOptional(p => p.Info);
            base.OnModelCreating(modelBuilder);
        }

    }
}
