using System;

var name = "Ewa";
int age = 33;
bool isFemale = true;

if (isFemale && age < 30)
{
    Console.WriteLine(" KOBIETA PONIZEJ 30 LAT");
}
if (name == "Ewa" && age == 33)
{
    Console.WriteLine(" EWA, LAT 33");
}
if (!isFemale && age < 18)
{
    Console.WriteLine(" NIEPELNOLETNI MEZCZYZNA");
}