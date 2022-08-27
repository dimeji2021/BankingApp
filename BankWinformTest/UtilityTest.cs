using BankAppCore;
using BankAppCore.Helper;
using EasyEncryption;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankWinformTest
{
    public class UtilityTest
    {
        [Fact]
        public void Test1()
        {
            Utilities utility = new Utilities();
            //Arrange
            string password = "Adedimeji@2";
            string password1 = "Adedimeji@2";
            string password2 = "Adedimeji@2";
            //Act
            var actual = utility.ComputeSha256Hash(password);
            var actua2 = utility.ComputeSha256Hash(password1);
            var actua3 = utility.ComputeSha256Hash(password2);


            //Asset
            Assert.Equal(SHA.ComputeSHA256Hash(password), actual);
            Assert.Equal(SHA.ComputeSHA256Hash(password), actua2);
            Assert.Equal(SHA.ComputeSHA256Hash(password), actua3);


        }
    }
}
