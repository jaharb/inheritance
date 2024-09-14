using System.Runtime.CompilerServices;

public class Reptile : Animal
{
    public float Scale { get; set; }
    public Reptile(string name, float s) : base(name)
    {
        Scale = s;
    }

    public override void sound()
    {
        Console.WriteLine($"{Name} makes reptile sound, and is {Scale} scaly");
    }

    public override string Food
    {
        get { return "bugs"; }
    }
}