using ChallengeApp;


Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("==============================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę Pracownika z zakresu 1 - 100 lub A - E");

//var employee = new Employee("jajaj" , "jjj");

//var employee = new Employee("Adam", "Kowalewski");
var employee = new EmployeeInFile("InAdam", "InKowalewski");

//var employee = new EmployeeInMemory("InAdam", "InKowalewski");

employee.AddGrade(1.67f);
employee.AddGrade(1.18f);
//while(true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: aby zakończyć wprowadż q ");
//        var input = Console.ReadLine();
//    if(input == "q")
//    { 
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch(Exception e) 
//    {        
//         Console.WriteLine($"Exception catched :  {e.Message}");
//    }

//}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG : {statistics.Average}");
Console.WriteLine($"Min : {statistics.Min}");
Console.WriteLine($"Max : {statistics.Max}");




