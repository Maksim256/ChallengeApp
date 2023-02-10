using ChallengeApp;

Employee employee1 = new Employee("Adam", "Adamowski", 30);
Employee employee2 = new Employee("Ewa", "Ewowska", 18);
Employee employee3 = new Employee("Kamil", "Kamilski", 48);

employee1.AddPunty(1);
employee1.AddPunty(2);
employee1.AddPunty(1);
employee1.AddPunty(1);
employee1.AddPunty(5);

employee2.AddPunty(1);
employee2.AddPunty(2);
employee2.AddPunty(4);
employee2.AddPunty(1);
employee2.AddPunty(8);

employee3.AddPunty(1);
employee3.AddPunty(2);
employee3.AddPunty(4);
employee3.AddPunty(1);
employee3.AddPunty(1);

List<Employee> employees = new List<Employee>()
{
    employee1 ,employee2 ,employee3
};

// przykład wg podpowiedzi z lekcji
int maxPunkty = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Wynik > maxPunkty)
    {
        employeeWithMaxResult = employee;
        maxPunkty= employee.Wynik;
    }
   
}
Console.WriteLine("rekord z listy to:" + employeeWithMaxResult.Nazwisko+" Punktów: "+ employeeWithMaxResult.Wynik);

var wynik1 = employee1.Wynik;
var wynik2 = employee2.Wynik;
var wynik3 = employee3.Wynik;

if(employee1.Wynik > employee2.Wynik && employee1.Wynik > employee3.Wynik)
{
    int rekord = employee1.Wynik;
    Console.WriteLine("punktów " + rekord + " " + "Zdobył: "+employee1.Nazwisko);
}
else if(employee2.Wynik > employee1.Wynik && employee2.Wynik > employee3.Wynik)
{
    int rekord = employee2.Wynik;
    Console.WriteLine("punktów " + rekord + " "+"Zdobył: "+ employee2.Nazwisko);
}
else
{
    int rekord = employee3.Wynik;
    Console.WriteLine("najwięcej punktów " + rekord+" "+ "Zdobył: "+ employee3.Nazwisko);
}
Console.WriteLine(employee1.Imie + " " + employee1.Nazwisko + " Lat " + employee1.Wiek + " wynik "+ wynik1);
Console.WriteLine(employee2.Imie + " " + employee2.Nazwisko + " Lat " + employee2.Wiek + " wynik " + wynik2);
Console.WriteLine(employee3.Imie + " " + employee3.Nazwisko + " Lat " + employee3.Wiek + " wynik " + wynik3);

