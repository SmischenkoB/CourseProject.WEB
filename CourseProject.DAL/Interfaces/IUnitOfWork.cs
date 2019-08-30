using CourseProject.DAL.Entenies;
using CourseProject.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Message> Messages { get; }
        IRepository<Info> Infos { get; }
        IRepository<User> Users { get; }
        IRepository<Role> Roles { get; }
        void Save();
    }
}
