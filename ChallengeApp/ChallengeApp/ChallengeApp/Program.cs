using ChallengeApp;


Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("==============================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę Pracownika");

var employee = new Employee();

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
        var input = Console.ReadLine();
    if(input == "q")
    { 
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistics();
Console.WriteLine($"AVG : {statistics.Average}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");




