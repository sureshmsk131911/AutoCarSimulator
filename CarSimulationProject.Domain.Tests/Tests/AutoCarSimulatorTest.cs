using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSimulationProject.Domain.Tests.Tests;
using System;
//using NUnit.Framework;
using CarSimulationProject.Domain;


namespace CarSimulationProject.Domain.Tests.Tests
{
    public class AutoDrivingCarSimulatorTests
    {
        [Fact]
        public void ExecuteCommands_ValidInput_ReturnsExpectedOutput()
        {
            // Arrange
            AutoDrivingCarSimulator car = new AutoDrivingCarSimulator(0, 0, 'E');
            string commands = "FFRFFFRRLF";
            int width = 5;
            int height = 5;

            // Act
            Tuple<int, int, char> result = car.ExecuteCommands(commands, width, height);

            // Assert
           // Assert.Equal(1, result.Item1);
            //Assert.Equal(2, result.Item2);
            Assert.Equal('S', result.Item3);
        }
        [Fact]
        public void ExecuteCommands_MoveOffMap_DoesNotMove()
        {
            // Arrange
            AutoDrivingCarSimulator car = new AutoDrivingCarSimulator(0, 0, 'N');
            string commands = "FFF";
            int width = 5;
            int height = 5;

            // Act
            Tuple<int, int, char> result = car.ExecuteCommands(commands, width, height);

            // Assert
            Assert.Equal(0, result.Item1);
            Assert.Equal(2, result.Item2);
            Assert.Equal('N', result.Item3);
        }

        [Fact]
        public void ExecuteCommands_InvalidCommand_ThrowsException()
        {
            // Arrange
            AutoDrivingCarSimulator car = new AutoDrivingCarSimulator(0, 0, 'E');
            string commands = "FFFFG";
            int width = 5;
            int height = 5;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => car.ExecuteCommands(commands, width, height));
        }
    }



}

