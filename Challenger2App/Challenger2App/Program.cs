string name = "Mirko";
bool kobieta = false;
int age = 40;

if (kobieta == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else if (kobieta == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
    Console.WriteLine("Dane poza zakresem programu");
