using System.Xml.Linq;

string imie = "Andrzej";
bool mezczyzna = false;
int age = 29;

Console.WriteLine("zmienna imie: " + imie);
Console.WriteLine("zmienn plec, czy meżczyzna: " + mezczyzna);
Console.WriteLine("zmienna wiek: " + age);
Console.WriteLine("     ");
if (mezczyzna == true)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    if (age >= 18)
    {
        Console.WriteLine("Pełnoletni mezczyzna");
    }

}



else
{
    if (age == 33 )
    {
        Console.WriteLine("Ewa, lat 33 ");
    }
    else if (age < 30 )
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age >= 30)
    {
        Console.WriteLine("Kobieta");
    }

}



