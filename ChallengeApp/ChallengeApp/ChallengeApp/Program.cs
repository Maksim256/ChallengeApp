using ChallengeApp;

var employee = new Employee("Adam", "Adamowski");
employee.AddGrade(9f);
employee.AddGrade("Adam");
employee.AddGrade("20");
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"average: {statistics1.Average:n2}");
Console.WriteLine($"min: {statistics1.Min}");
Console.WriteLine($"max: {statistics1.Max}");




