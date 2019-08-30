using CourseProject.DAL.Entenies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Enteties
{
    public class SocialNetworkContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public SocialNetworkContext() : base("SocialNDB")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>().HasMany(p => p.Messages).WithRequired(p => p.User);
            //modelBuilder.Entity<Info>().HasRequired(p => p.).WithOptional(p => p.Info);
            modelBuilder.Entity<User>().HasMany(s => s.Roles).WithMany(s => s.Users);

            modelBuilder.Entity<Message>().HasRequired(r => r.User)
               .WithMany(r => r.Messages).HasForeignKey((u) => u.User1);

            //modelBuilder.Entity<Message>().HasRequired(r => r.Useru2)
            //    .WithMany(r => r.Messages).HasForeignKey(u => u.User2);
            //modelBuilder.Entity<User>().HasMany(u => u.Messages).WithRequired(u => u.User).HasForeignKey(u =>  u.User2, );

            //modelBuilder.Entity<User>().HasMany(r => r.Messages).WithMany(r => r.Recievers);

           // modelBuilder.Entity<User>().HasMany(r => r.Messages2).WithMany(r => r.Users);

            modelBuilder.Entity<User>().HasOptional(r => r.Info).WithRequired(r => r.User);

            base.OnModelCreating(modelBuilder);
        }

    }
}
