namespace ChallengeApp.Tests
{
    public class EmployeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCurrentMin()
        {
            //arrange
            var employee = new Employee("Adam1", "Adamowski1");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
            
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCurrentMax() 
        {
            //arrange
            var employee = new Employee("Adam1", "Adamowski1");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();
            
            //assert
            Assert.AreEqual(6, statistics.Max);
        
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCurrentAverage()
        {
            //arrange
            var employee = new Employee("Adam1", "Adamowski1");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2),Math.Round( statistics.Average, 2));
        }



    }
}
