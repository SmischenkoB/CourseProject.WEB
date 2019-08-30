using CourseProject.DAL.Entenies;
using CourseProject.DAL.Enteties;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories
{
    class RoleRepository : IRepository<Role>
    {
        private SocialNetworkContext db;

        public RoleRepository(SocialNetworkContext context)
        {
            db = context;
        }
       
        public void Create(Role item)
        {
            db.Roles.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Role obj = db.Roles.Find(id);
            if (obj != null)
            {
                db.Roles.Remove(obj);
                db.SaveChanges();
            }
        }

        public IEnumerable<Role> Find(Func<Role, bool> predicate)
        {
            
            return db.Roles.Where(predicate).ToList();
        }

        public Role Get(int id)
        {
            return db.Roles.Find(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return db.Roles;
        }

        public void Update(Role item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
