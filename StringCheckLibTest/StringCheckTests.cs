using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCheckLib;

namespace StringCheckLibTest
{
    [TestClass]
    public class StringCheckTests
    {

        //Test Email input

        [TestMethod]
        public void CheckEmail_isEngNum_TrueReturned()
        {
                //Arrange
                string stringEmail = "ivanpetrov2002@gmail.com";
                //Act 
                StringCheck isEmail = new StringCheck();
                bool correctEmail = isEmail.CheckEmail(stringEmail);
                //Assert
                Assert.IsTrue(correctEmail);
        }

        [TestMethod]
        public void CheckEmail_isEmpty_falseReturned()
        {
            //Arrange
            string stringEmail = "";
            //Act 
            StringCheck isEmail = new StringCheck();
            bool correctEmail = isEmail.CheckEmail(stringEmail);
            //Assert
            Assert.IsFalse(correctEmail);
        }

        [TestMethod]
        public void CheckEmail_isSpace_falseReturned()
        {
            //Arrange
            string stringEmail = "Skochkov aleksey";
            //Act 
            StringCheck isEmail = new StringCheck();
            bool correctEmail = isEmail.CheckEmail(stringEmail);
            //Assert
            Assert.IsFalse(correctEmail);
        }

        //Test FName input


        [TestMethod]
        public void CheckFName_isRus_TrueReturned()
        {
            //Arrange
            string stringName = "Скочков";
            //Act
            StringCheck isFName = new StringCheck();
            bool correctName = isFName.CheckFName(stringName);
            //Assert
            Assert.IsTrue(correctName);
        }

        [TestMethod]
        public void CheckFName_isEmpty_FalseReturned()
        {
            //Arrange
            string stringName = "";
            //Act
            StringCheck isFName = new StringCheck();
            bool correctName = isFName.CheckFName(stringName);
            //Assert
            Assert.IsFalse(correctName);
        }


        [TestMethod]
        public void CheckFName_isNumbers_FalseReturned()
        {
            //Arrange
            string stringName = "12345";
            //Act
            StringCheck isFName = new StringCheck();
            bool correctName = isFName.CheckFName(stringName);
            //Assert
            Assert.IsFalse(correctName);
        }

        [TestMethod]
        public void CheckFName_isNumbersWord_FalseReturned()
        {
            //Arrange
            string stringName = "Скочков123";
            //Act
            StringCheck isFName = new StringCheck();
            bool correctName = isFName.CheckFName(stringName);
            //Assert
            Assert.IsFalse(correctName);
        }

        [TestMethod]
        public void CheckLName_isRus_TrueReturned()
        {
            //Arrange
            string stringLName = "Скочков";
            //Act
            StringCheck isLName = new StringCheck();
            bool correctLName = isLName.CheckFName(stringLName);
            //Assert
            Assert.IsTrue(correctLName);
        }

        //Test LName input

        [TestMethod]
        public void CheckLName_isEmpty_FalseReturned()
        {
            //Arrange
            string stringLName = "";
            //Act
            StringCheck isLName = new StringCheck();
            bool correctLName = isLName.CheckFName(stringLName);
            //Assert
            Assert.IsFalse(correctLName);
        }

        [TestMethod]
        public void CheckLName_isNumbers_FalseReturned()
        {
            //Arrange
            string stringLName = "12345";
            //Act
            StringCheck isLName = new StringCheck();
            bool correctLName = isLName.CheckLName(stringLName);
            //Assert
            Assert.IsFalse(correctLName);
        }

        [TestMethod]
        public void CheckLName_isNumbersWord_FalseReturned()
        {
            //Arrange
            string stringLName = "Скочков123";
            //Act
            StringCheck isLName = new StringCheck();
            bool correctLName = isLName.CheckFName(stringLName);
            //Assert
            Assert.IsFalse(correctLName);
        }

        //Test Password input

        [TestMethod]
        public void CheckPassword_isEmpty_FalseReturned()
        {
            //Arrange
            string stringPassword = "";
            //Act
            StringCheck isPassword = new StringCheck();
            bool correctPassword = isPassword.CheckFName(stringPassword);
            //Assert
            Assert.IsFalse(correctPassword);
        }

        [TestMethod]
        public void CheckPassword_isNotCorrect_FalseReturned()
        {
            //Arrange
            string stringPassword = "zxc123";
            //Act
            StringCheck isPassword = new StringCheck();
            bool correctPassword = isPassword.CheckFName(stringPassword);
            //Assert
            Assert.IsFalse(correctPassword);
        }

        [TestMethod]
        public void CheckPassword_isNotEnough_FalseReturned()
        {
            //Arrange
            string stringPassword = "At45_";
            //Act
            StringCheck isPassword = new StringCheck();
            bool correctPassword = isPassword.CheckFName(stringPassword);
            //Assert
            Assert.IsFalse(correctPassword);
        }

        [TestMethod]
        public void CheckPassword_isCorrect_TrueReturned()
        {
            //Arrange
            string stringPassword = "qwRg467g@#";
            //Act
            StringCheck isPassword = new StringCheck();
            bool correctPassword = isPassword.CheckPassword(stringPassword);
            //Assert
            Assert.IsTrue(correctPassword);
        }
    }
}

