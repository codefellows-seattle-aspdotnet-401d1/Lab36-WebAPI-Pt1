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

        [Fact]
        public void CanChangeDragonDescription()
        {
            //Arrange
            var myDragon = new Dragon("Gold Dragon", "Gold colored scales, breathes fire.");

            // Act
            myDragon.Description = "Gold colored scales, breathes holy fire.";

            // Assert
            Assert.Equal("Gold colored scales, breathes holy fire.", myDragon.Description);
        }
    }
}
