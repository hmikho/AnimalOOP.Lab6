namespace Lab6_OOPArv;

public class Owl : Animal
{
    public string FeatherColor { get; set; }

    public Owl(string name, string behaviour, string diet, string habitat, string featherColor)
        : base(name, behaviour, diet, habitat, "Owl")
    {
        FeatherColor = featherColor;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Behaviour: {Behaviour}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Habitat: {Habitat}");
        Console.WriteLine($"Feathercolor: {FeatherColor}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} hoots, and says 'hoo-hoo-ho'!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} flies over the sky.");
    }
}