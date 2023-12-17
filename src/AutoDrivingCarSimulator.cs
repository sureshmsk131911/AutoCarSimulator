using CarSimulationProject.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Xunit;

// Use MSTest Assert class
//Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);




namespace CarSimulationProject.Domain
{
    public class AutoDrivingCarSimulator
    {
        private int x;
        private int y;
        private char direction;

        public AutoDrivingCarSimulator(int x, int y, char direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        //public IEnumerable<object> direction { get; internal set; }
        //public object X { get; internal set; }
        //public IEnumerable<object> Y { get; internal set; }

        //public void ExecuteCommands(string commands, int v1, int v2)
        //{

        //    //AutoDrivingCarSimulator car = new AutoDrivingCarSimulator(0, 0, 'E');
        //    //car.ExecuteCommands("FFRFFFRRLF", 5, 5);
        //    //Console.WriteLine($"Final position: {car.X} {car.Y}, Final direction: {car.direction}");
        //    //Console.ReadLine();

        //}


        // Method to execute a sequence of commands on the car
        public Tuple<int, int, char> ExecuteCommands(string commands, int width, int height)
        {
            // Iterate through each command in the input sequence
            foreach (char command in commands)
            {
                // Switch statement to handle different types of commands
                switch (command)
                {
                    // Rotate the car 90 degrees to the left
                    case 'L':
                        RotateLeft();
                        break;
                    // Rotate the car 90 degrees to the right
                    case 'R':
                        RotateRight();
                        break;
                    // Move the car forward by 1 grid point
                    case 'F':
                        MoveForward(width, height);
                        break;
                        // Ignore unknown commands
                }
            }
            return Tuple.Create(x, y, direction);
        }
        // Helper method to rotate the car 90 degrees to the right
        private void RotateLeft()
        {
            switch (direction)
            {
                case 'N':
                    direction = 'W';
                    break;
                case 'E':
                    direction = 'N';
                    break;
                case 'S':
                    direction = 'E';
                    break;
                case 'W':
                    direction = 'S';
                    break;
            }
        }

        private void RotateRight()
        {
            switch (direction)
            {
                case 'N':
                    direction = 'E';
                    break;
                case 'E':
                    direction = 'S';
                    break;
                case 'S':
                    direction = 'W';
                    break;
                case 'W':
                    direction = 'N';
                    break;
            }


        }
        // Helper method to move the car forward by 1 grid point
        private void MoveForward(int width, int height)
        {
            switch (direction)
            {
                // Move North if facing North and within the height boundary
                case 'N':
                    if (y < height - 1) y++;
                    break;
                // Move East if facing East and within the width boundary
                case 'E':
                    if (x < width - 1) x++;
                    break;
                // Move South if facing South and above the bottom boundary
                case 'S':
                    if (y > 0) y--;
                    break;
                // Move West if facing West and above the left boundary
                case 'W':
                    if (x > 0) x--;
                    break;

            }
        }
    }




   

//namespace CarSimulationProject.Tests
//    {
//        [TestClass]
//        public class AutoDrivingCarSimulatorTests
//        {
//            [TestMethod]
//            public void ExecuteCommands_ShouldMoveCarToCorrectPositionAndDirection()
//            {
//                // Arrange
//                var car = new AutoDrivingCarSimulator(1, 2, 'N');

//                // Act
//                car.ExecuteCommands("FFRFFFRRLF", 10, 10);

//                // Assert
//                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, car.X);
//                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, car.Y);
//                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual('S', car.direction);
//            }

//            //[TestMethod]
//            //public void ExecuteCommands_ShouldNotMoveCarOutOfBounds()
//            //{
//            //    // Arrange
//            //    var car = new AutoDrivingCarSimulator(0, 0, 'S');

//            //    // Act
//            //    car.ExecuteCommands("F", 10, 10);

//            //    // Assert
//            //    Assert.AreEqual(0, car.X);
//            //    Assert.AreEqual(0, car.Y);
//            //    Assert.AreEqual('S', car.Direction);
//            //}

//           // [TestMethod]
//            //public void ExecuteCommands_ShouldRotateCarToLeft()
//            //{
//            //    // Arrange
//            //    var car = new AutoDrivingCarSimulator(3, 3, 'N');

//            //    // Act
//            //    car.ExecuteCommands("L", 5, 5);

//            //    // Assert
//            //    Assert.AreEqual(3, car.X);
//            //    Assert.AreEqual(3, car.Y);
//            //    Assert.AreEqual('W', car.Direction);
//            //}

//            //[TestMethod]
//            //public void ExecuteCommands_ShouldRotateCarToRight()
//            //{
//            //    // Arrange
//            //    var car = new AutoDrivingCarSimulator(2, 2, 'S');

//            //    // Act
//            //    car.ExecuteCommands("R", 5, 5);

//            //    // Assert
//            //    Assert.AreEqual(2, car.X);
//            //    Assert.AreEqual(2, car.Y);
//            //    Assert.AreEqual('W', car.Direction);
//            //}

            
//        }
//    }

}










