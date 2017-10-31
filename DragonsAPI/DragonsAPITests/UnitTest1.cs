using DragonsAPI.Models;
using System;
using Xunit;

namespace DragonsAPITests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateValidDragon()
        {
            // Arrange
            var myDragon = new Dragon("Gold Dragon", "Gold colored scales, breathes fire.");

            // Act

            // Assert
            Assert.IsType(typeof(Dragon), myDragon);
        }
    }
}
