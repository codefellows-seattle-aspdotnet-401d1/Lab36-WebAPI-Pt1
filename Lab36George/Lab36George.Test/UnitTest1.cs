using Lab36George.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using Xunit;

namespace Lab36George.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var controller = new PartsController();

            // Act
            var result = controller.Get(5);
            ObjectResult statusCode = (ObjectResult)result;

            // Assert
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)statusCode.StatusCode.Value);
            // need to figure out the type
            //Assert.IsType(typeof(figureoutthetype),);
        }
    }
}
