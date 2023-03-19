using ChallengeApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void NumberShouldReturnDifferentValue()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            //assert 
            Assert.AreNotEqual(number1, number2);
        }

        [Test]

        public void NumberShouldReturnDifferentFloatNumber()
        {
            //arrange
            float number1 = 1.34f;
            float number2 = 2.56f;

            //act

            //assert 
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void GetUserShouldReturnDifferentObject()
        {
            //arrange
            var user1 = GetUser(" Artur");
            var user2 = GetUser(" Monika");

            //act

                        //assert 
            Assert.AreNotEqual(user1, user2);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }

    }
}
    

