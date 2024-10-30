namespace Lab6_OOPArv;

public class Dog : Animal
{
    public string TrainedLevel { get; set; }

    public Dog(string name, string behaviour, string diet, string habitat, string trainedLevel)
        : base(name, behaviour, diet, habitat, "Dog")
    {
        TrainedLevel = trainedLevel;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Species: {Species}");
        Console.WriteLine($"Behaviour: {Behaviour}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Habitat: {Habitat}");
        Console.WriteLine($"Trained Level: {TrainedLevel}");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} barks, and says 'woof-woof'!");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} runs and fetches the ball!");
    }

    public void ShowTrainedLevel()
    {
        Console.WriteLine($"{Name} has the trained level: {TrainedLevel}");
    }
}