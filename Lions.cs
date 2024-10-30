namespace Lab6_OOPArv;

public class Lion : Animal
{
    public string Color { get; set; }

    public Lion(string name, string behaviour, string diet, string habitat, string color)
        : base(name, behaviour, diet, habitat, "Lion")
    {
        Color = color;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Behaviour: {Behaviour}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Habitat: {Habitat}");
        Console.WriteLine($"Color: {Color}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars loudly!");
    }

    public void Hunt()
    {
        Console.WriteLine($"{Name} hunts in the {Habitat}.");
    }
}


public class AsianLion : Lion
{
    public AsianLion(string name, string behaviour, string diet, string habitat, string color)
        : base(name, behaviour, diet, habitat, color)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the asian lion, roars with a growl!");
    }

    public void ClimbMountain()
    {
        Console.WriteLine($"{Name} climbs moutains in {Habitat}.");
    }
}

public class AfricanLion : Lion
{
    public AfricanLion(string name, string behaviour, string diet, string habitat, string color)
        : base(name, behaviour, diet, habitat, color)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}, the african lion, roars with a growl!");
    }

    public void RunFast()
    {
        Console.WriteLine($"{Name} is running swiftly across the savannah.");
    }
}
