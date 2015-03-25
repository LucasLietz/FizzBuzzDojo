using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void App_Should_Return_Fizz_At_Multiple_Of_Three()
        {
            //Arrange
            var testNumber = 3;
            var buzzer = new FizzBuzzer();

            //Act
            var result = buzzer.FizzIt(testNumber);
            //Assert
            Assert.AreEqual("Fizz", result);
        }
    }
}