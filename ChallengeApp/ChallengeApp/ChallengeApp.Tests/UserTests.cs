using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void WhenTwoNumberAreAdded_ShouldReturnSum()
        {

            //arrange
            int age1 = 10;
            int age2 = 3;

            //act
            int result = age1 + age2;

            //assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult() 
        {
            //arrange
            var employe = new Employee("Adam", "asddas324",30);
            employe.AddScore(5);
            employe.AddScore(6);

            //act
            var result = employe.Wynik;
            //assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void UserScoresWereSubstracted_ShouldReturnCorrectResuult()
        {
            //arrange
            var employe = new Employee("Tomasz", "Tomaszewski", 36);
            employe.AddScore(5);
            employe.AddScore(15);
            employe.SubstractScore(5);
            employe.SubstractScore(5);
            //act
            var result = employe.Wynik;
            //assert
            Assert.AreEqual(10, result);
        }
    }
}