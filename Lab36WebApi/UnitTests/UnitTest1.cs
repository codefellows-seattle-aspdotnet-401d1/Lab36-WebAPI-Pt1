using Lab36WebApi.Models;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetTask()
        {
            //Arrange
            BirthdayPlanner PlanA = new BirthdayPlanner
            {
                Task = "Get Cake from costco"
            };

            //Act
            string test = PlanA.Task;

            //Assert
            Assert.Equal(test, "Get Cake from costco");
        }

        [Fact]
        public void TestGetIsDone()
        {
            //Arrange
            BirthdayPlanner PlanC = new BirthdayPlanner
            {
                IsComplete = false
            };

            //Act
            bool test = PlanC.IsComplete;

            //Assert
            Assert.Equal(test, false);
        }

        [Fact]
        public void TestSetTask()
        {
            //Arrange
            BirthdayPlanner PlanD = new BirthdayPlanner
            {
            //Act
                Task = "Stressing out over data structures"
            };

            

            //Assert
            Assert.Equal(PlanD.Task, "Stressing out over data structures");

        }
    }
}
