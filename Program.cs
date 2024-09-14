using System.Runtime.CompilerServices;

namespace inheritance;

class Program
{
    static void Main(string[] args)
    {
        Animal a = new Animal("beast");
        Reptile reptile= new Reptile("lizzy", 0.5f);
        Animal a2;
        a2 = reptile;

        a.sound();
        reptile.sound();
        a2.sound();
        Console.WriteLine("reptile eats: " + reptile.Food);
    }
}
