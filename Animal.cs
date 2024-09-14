public class Animal : LivingThing
{
    public string Name { get; set; }
    public override string Food
    {
        get { return "animal food"; }
    }
    public Animal(string name)
    {
        Name = name;
    }

    public virtual void sound()
    {
        Console.WriteLine($"{Name} makes animal sound");
    }
}

// 1. Animal
// 2. Reptile
// 3. LivingThing
// WHY:
//    inherit functionality (like Monobehavior)
//    Unity can write code to call methods on our class, even
//    though our class didn't exist