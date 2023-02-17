namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            int number1 = 1;
            int number2 = 2;
            //act

            //assert
            Assert.AreNotEqual(user1, user2);
            Assert.AreEqual(number1, number2);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
