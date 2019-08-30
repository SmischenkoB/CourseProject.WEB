using CourseProject.DAL.Entenies;
using CourseProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EFUnitOfWork ef = new EFUnitOfWork();
           // ef.Users.Create(new User() { Id = 7, Name = "ibragim", Phone = "as" });

            Console.WriteLine(ef.Users.Find( u => u.Id == 7));
        }
    }
}
