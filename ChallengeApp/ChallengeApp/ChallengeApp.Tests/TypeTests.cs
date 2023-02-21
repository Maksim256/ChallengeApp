namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TypeTestsOfVariable_ReferenceMustBeNotEqual()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            int number1 = 4;
            int number2 = 4;
            
           
            //assert
            Assert.AreNotEqual(user1, user2);
            Assert.AreEqual(number1, number2);
           
           ;
        }

        [Test]
        public void FloatVaiablesChecks_ValueMustBeEqual()
        {
            float number3 = 5.51f;
            float number4 = 5.51f;
            Assert.AreEqual( number3, number4);

         float   number8 = number3 + number4;

            Assert.AreEqual(11.02f , number8);
        }

        [Test]
        public void StringVariablesChecks_ValueMustBeEual()
        {
            string nazwa = "nazwaa20";
            string nazwa2 = "nazwaa20";
            string nazwa3 = nazwa+ nazwa2;

            Assert.AreEqual(nazwa, nazwa2);

            Assert.AreEqual("nazwaa20nazwaa20", nazwa3);

        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
