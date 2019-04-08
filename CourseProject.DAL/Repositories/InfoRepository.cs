using CourseProject.DAL.Entenies;
using CourseProject.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Repositories
{
    public class InfoRepository : IRepository<Info>
    {
        private SocialNetworkContext db;

        public InfoRepository(SocialNetworkContext context)
        {
            db = context;
        }

        public void Create(Info item)
        {
            db.Infos.Add(item);
        }

        public void Delete(int id)
        {
            Info obj = db.Infos.Find(id);
            if (obj != null)
            {
                db.Infos.Remove(obj);
            }
        }

        public IEnumerable<Info> Find(Func<Info, bool> predicate)
        {
            return db.Infos.Where(predicate).ToList();
        }

        public Info Get(int id)
        {
            return db.Infos.Find(id);
        }

        public IEnumerable<Info> GetAll()
        {
            return db.Infos;
        }

        public void Update(Info item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
