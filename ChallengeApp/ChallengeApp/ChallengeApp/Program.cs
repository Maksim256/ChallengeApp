using ChallengeApp;

var employee = new Employee("Adam", "Adamowski");
employee.AddGrade(9f);
employee.AddGrade("Adam");
employee.AddGrade("20");
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"average: {statistics.Average:n2}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"max: {statistics.Max}");




