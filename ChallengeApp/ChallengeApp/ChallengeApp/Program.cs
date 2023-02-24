using ChallengeApp;

var employee = new Employee("Adam", "Adamowski");
employee.AddGrade(9223372036854775800);
employee.AddGrade("Adam");
employee.AddGrade("2000");
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

