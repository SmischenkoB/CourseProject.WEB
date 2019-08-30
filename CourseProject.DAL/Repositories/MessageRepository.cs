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
    public class MessageRepository : IRepository<Message>
    {
        private SocialNetworkContext db;
        

        public MessageRepository(SocialNetworkContext context)
        {
            db = context;
        }

        public void Create(Message item)
        {
            db.Messages.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Message obj = db.Messages.Find(id);
            if (obj != null)
            {
                db.Messages.Remove(obj);
                db.SaveChanges();
            }
        }

        public IEnumerable<Message> Find(Func<Message, bool> predicate)
        {
            return db.Messages.Where(predicate).ToList();
        }

        public Message Get(int id)
        {
            return db.Messages.Find(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return db.Messages;
        }

        public void Update(Message item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
