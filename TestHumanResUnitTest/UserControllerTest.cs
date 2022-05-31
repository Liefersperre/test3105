using System;
using System.Linq;
using TestHR.Model;
using TestHR.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HRUnitTest
{
    [TestClass]
    public class UserControllerTest
    {
        HumanResDBEntities DB = new HumanResDBEntities();
        //UserController userObj = new UserController();

        [TestMethod]
        public void GetUser_trueReturned()
        {
            //Arrange
            //userObj = new UserController();
            //Act
            //bool result = userObj.GetUsers().Count() > 0;
            //Assert
            //Assert.IsTrue(result);
        }
    }
}
