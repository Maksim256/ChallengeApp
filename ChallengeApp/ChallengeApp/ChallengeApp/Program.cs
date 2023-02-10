using ChallengeApp;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

User user1 = new User("Adam", "32432fddf");
User user2 = new User("Monika", "32432fddf");
User user3 = new User("Zuzia", "32432fddf");
User user4 = new User("Damian", "32432fddf");


//user1.password = "password";

Employee employee1 = new Employee("Adam", "Adamowski", 30);
Employee employee2 = new Employee("Ewa", "Ewowska", 18);
Employee employee3 = new Employee("Kamil", "Kamilski", 48);

//user1.AddScore(4);


//Console.WriteLine(employee1.PunktyPrac);

employee1.AddPunty(1);
employee1.AddPunty(2);
employee1.AddPunty(1);
employee1.AddPunty(1);
employee1.AddPunty(1);

employee2.AddPunty(1);
employee2.AddPunty(2);
employee2.AddPunty(1);
employee2.AddPunty(1);
employee2.AddPunty(1);

employee3.AddPunty(1);
employee3.AddPunty(2);
employee3.AddPunty(1);
employee3.AddPunty(1);
employee3.AddPunty(1);

//ten Login dostaje dostep do propercji o tej samej nazwie
//user1.Login = "Marek";
var name = user1.Login;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
var wynik1 = employee1.Wynik;
var wynik2 = employee2.Wynik;
var wynik3 = employee3.Wynik;
//Console.WriteLine(wynik);

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
    Console.WriteLine("punktów " + rekord+" "+ "Zdobył: "+ employee3.Nazwisko);
}
//do zmiennej statycznej odwołujemy sie przez obiekt i nie musimy jej tworzyć
var name1 = User.GameName;

//Console.WriteLine(result);
//Console.WriteLine(name1);


Console.WriteLine(employee1.Imie + " " + employee1.Nazwisko + " Lat " + employee1.Wiek + " wynik "+ wynik1);
Console.WriteLine(employee2.Imie + " " + employee2.Nazwisko + " " + employee2.Wiek + " " + " wynik " + wynik2);
Console.WriteLine(employee3.Imie + " " + employee3.Nazwisko + " " + employee3.Wiek + " " + " wynik " + wynik3);

