using Microsoft.VisualStudio.TestTools.UnitTesting;

using CourseProject.DAL.Repositories;
using System.Collections.Generic;
using CourseProject.DAL.Entenies;
using System.Linq;

namespace CouresProject.DAL.TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EFUnitOfWork unitOfWork = new EFUnitOfWork();
            //unitOfWork.Users.Create(new User { Id = 1, Name = "Ibragim", Role = "User" });
            List<User> obj = unitOfWork.Users.GetAll().ToList();
            System.Console.WriteLine(obj.Count);
            Assert.AreEqual(obj.Count, 3);
        }
    }
}
