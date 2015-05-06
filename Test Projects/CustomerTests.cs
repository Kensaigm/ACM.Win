﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNull()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNotNumeric()
        {
            // Arrange
            Customer customer = new Customer();
            string goalSteps = "one";
            string actualSteps = "2000";

            // Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }
            

            // Assert

        }

        //[TestMethod()]
        //public void CalculatePercentOfGoalStepsTest()
        //{
        //    Assert.Fail();
        //}

    }
}
