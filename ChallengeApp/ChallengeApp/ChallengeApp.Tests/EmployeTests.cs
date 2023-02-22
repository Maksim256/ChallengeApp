namespace ChallengeApp.Tests
{
    public class EmployeTests
    {
        [Test]
        public void TestMin_shouldBeMin()
        {
            //arrange
            var employee = new Employee("Adam1", "Adamowski1");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();
            
            //act

            //assert
            Assert.AreEqual(2, statistics.Min);
            
        }
        [Test]
        public void TestMax_shouldBeMax() 
        {
            var employee = new Employee("Adam1", "Adamowski1");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();
            Assert.AreEqual(6, statistics.Max);
        
        }
        [Test]
        public void TestAvg_SouldBeOK()
        {
            var employee = new Employee("Adam1", "Adamowski1");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();
            Assert.AreEqual(4, statistics.Average);
        }



    }
}
