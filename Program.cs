using System;
internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Fordon> fordonlist = new List<Fordon>();
        string ans = new string("y");
        fordonlist.Add(new Fordon("Ford", "Mustang", 2022));
        fordonlist.Add(new Fordon("Honda", "Civic", 2006));
        fordonlist.Add(new Fordon("Toyota", "Camry", 2012));
        while (ans == "y")
        {
            Console.WriteLine("Skriv ett fordon:");
            fordonlist.Add(new Fordon(Console.ReadLine(), Console.ReadLine(), Int32.Parse(Console.ReadLine())));
            Console.WriteLine("Vill du skriva mer? y eller n:");
            ans = Console.ReadLine();
        }
        foreach (Fordon element in fordonlist)
        {
            Console.WriteLine(element.Tillverkare +", "+ element.Modell+", "+ element.Årsmodell+".");
        }
    }
}