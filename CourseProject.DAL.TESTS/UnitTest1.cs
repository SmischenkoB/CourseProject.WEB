using System;
using CourseProject.DAL.Entenies;
using CourseProject.DAL.Enteties;
using CourseProject.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseProject.DAL.TESTS
{
 
     [TestClass]
     public class UnitTest1
     {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    
        //    EFUnitOfWork unitOfWork = new EFUnitOfWork();
        //    User obj = unitOfWork.Users.Get(1);
        //    Assert.AreEqual(obj.Name, "ibragim");
        //}

         [TestMethod]
         public void Test2()
         {
             Assert.AreEqual(true, true);
         }

        [TestMethod]
        public void addingUser()
        {
            EFUnitOfWork unitOfWork = new EFUnitOfWork();
            User obj = new User { Name = "sec", Password ="123" };
            unitOfWork.Users.Create(obj);
            var u2 = unitOfWork.Users.
                Find(u => u.Name == "sec" && u.Password == "123").GetEnumerator();
            u2.MoveNext();
            Assert.AreEqual(obj.Name + obj.Password, u2.Current.Name + obj.Password);
            unitOfWork.Users.Delete(obj.Id);
        }
     }
    
}
