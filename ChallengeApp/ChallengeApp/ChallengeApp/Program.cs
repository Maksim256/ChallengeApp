//var myAge = 33;
using System.Linq;

int myAge = 120;
int newAge = myAge
    +5;
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
string name = "Andrzej";
string surename = "Maks";
string result = name + surename  + myAge;
Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

//zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);

