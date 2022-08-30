using System;
internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Fordon> fordonlist = new List<Fordon>();
        fordonlist.Add(new Fordon("Ford", "Mustang", 2022));
        fordonlist.Add(new Fordon("Honda", "Civic", 2006));
        fordonlist.Add(new Fordon("Toyota", "Camry", 2012));
        foreach (Fordon element in fordonlist)
        {
            Console.WriteLine(element.Tillverkare +", "+ element.Modell+", "+ element.Årsmodell+".");
        }
    }
}