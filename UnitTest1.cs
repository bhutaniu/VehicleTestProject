using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Http;
using VehicleApi.Controllers;
using VehicleApi.Interfaces;

namespace VehicleTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetVehicleCount()
        {
            //throw new NotImplementedException("Not implemented.");
            var controller = new VehicleController();
          
            // Act
            var response = controller.GetAllVehicles();

            // Assert
            Assert.AreEqual(3, response.Result.Count);
        }
        [TestMethod]
        public void DeleteVehicle()
        {
            //throw new NotImplementedException("Not implemented.");
            var controller = new VehicleController();

            // Act
            var response = controller.DeleteVehicle(2);

            // Assert
            Assert.AreEqual(2, response.Result.Count);
        }
    }
}
