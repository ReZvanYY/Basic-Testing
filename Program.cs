namespace basic testing
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hva heter du?");
        var name = Console.ReadLine();
        Console.WriteLine($"Hei {name}!");

        Console.WriteLine("hvor gammel er du?");
        var age = Console.ReadLine();
        Console.WriteLine($"Du er {age} år gammel!");

        Console.WriteLine("Hvor bor du");
        var location = Console.ReadLine();
        Console.WriteLine($"Du bor på {location}");

        Console.WriteLine("Hvilket hobby har du?");
        var hobbies = Console.ReadLine();
        Console.WriteLine($"Du liker {hobbies}!");
    }

}

}