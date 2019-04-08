using CourseProject.DAL.Entenies;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private SocialNetworkContext db;

        public UserRepository(SocialNetworkContext context)
        {
            db = context;
        }

        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            User obj = db.Users.Find(id);
            if (obj != null)
            {
                db.Users.Remove(obj);
            }
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return db.Users.Include(o => o.Info).Include(o => o.Messages).Where(predicate).ToList();                        
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public void Update(User item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;            
        }
    }
}
