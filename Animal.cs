namespace Lab6_OOPArv;

public class Animal
{
    public string Name { get; set; }
    public string Behaviour { get; set; }
    public string Diet { get; set; }
    public string Habitat { get; set; }
    public string Species { get; set; }

    public Animal(string name, string behaviour, string diet, string habitat, string species)
    {
        Name = name;
        Behaviour = behaviour;
        Diet = diet;
        Habitat = habitat;
        Species = species;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} eats {Diet}");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} sleeps.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}
