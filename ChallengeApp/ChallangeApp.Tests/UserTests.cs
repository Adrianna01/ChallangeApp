using ChallengeApp;
using System.Text.Json.Serialization;

namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenScoresAdded_ShouldReturnUserResult()
        {
            //arrange
            var user = new User("Artur", "32877ffg");
            user.AddScore(7);
            user.AddScore(6);
            user.AddScore(8);
            user.AddScore(-2);
            //act
            var result = user.Result;

            //assert 
            Assert.AreEqual(19, result);
        }
    }
} 