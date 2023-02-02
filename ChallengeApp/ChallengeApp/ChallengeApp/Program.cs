//var myAge = 33;
using System.Linq;

int myAge = 120;
int newAge = myAge
    + 5;
Console.WriteLine(newAge);
// liczby całkowite
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
long myVar3 = long.MaxValue;
//liczby zmiennoprzecoinowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

//zmienn string
string name1 = "Andrzej";
string surename = "Maks";
string result = name1 + surename + myAge;
Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name1.ToArray();

//zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);

var number1 = 15;
var number2 = 10;

var name = "Adam";
var age = 53;
//&&  log i
// ||  log lub
// ! negacja
// np:  if(!(age < 50))
if (age > 50)
{
    if (name == "Adama")
    {
        Console.WriteLine("Jestem Adam");
    }
    else
    {
        Console.WriteLine("Mam inne imie");
    }
    // Console.WriteLine("Jestem Adamem i mam mniej niż 50lat");
}
else if (age > 40)
{
    Console.WriteLine("40-50 latek");
}
else if (age > 30)
{
    Console.WriteLine("30 latek");
}
else
{
    Console.WriteLine("inny wiek");
}
