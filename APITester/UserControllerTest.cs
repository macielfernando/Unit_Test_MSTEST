using APITestUnitario.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using APITestUnitario.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace APITester
{
    [TestClass]
    public class UserControllerTest
    {
        UserController controller;
        User user;


        [TestInitialize]
        public void Start()
        {
            controller = new UserController();
            user = new User();  
        }

        [TestMethod]
        public void Post_Test_Ok()
        {
            var responseAPI = controller.Post(user);
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }
    }
}