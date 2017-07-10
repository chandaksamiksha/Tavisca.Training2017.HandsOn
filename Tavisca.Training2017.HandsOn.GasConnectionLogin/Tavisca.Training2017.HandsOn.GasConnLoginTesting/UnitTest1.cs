using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.Training2017.HandsOn.GasConnectionLogin;

namespace Tavisca.Training2017.HandsOn.GasConnLoginTesting
{
    [TestClass]
    public class UnitTest1
    {
        int number;
        Input input = new Input();

        [TestMethod]
        public void ValidateAdharCardCarachterCount()
        {
             number=input.GetAdharNumber();
            Assert.Equals(number.ToString().Length,12);
        }
        public void ValidateOtpCount()
        {
            number = input.GetOtp();
            Assert.Equals(number.ToString().Length,6);
        }
        public void IsOtpSame()
        {
            number = input.GetOtp();
            Assert.AreSame(number, 123456);
        }
        public void ValidateMobileNumberCount()
        {
            number = input.GetMobileNumber();
            Assert.Equals(number.ToString().Length, 10);

        }
       
    }
}
