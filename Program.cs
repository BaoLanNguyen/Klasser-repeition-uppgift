using System;
internal class Program
{
    static void fordonmet(List<string> fordonwri){
        for (int i = 0; i < fordonwri.Count; i++)
        {
            Console.WriteLine(fordonwri[i]);
        }
    }
    private static void Main(string[] args)
    {
       Fordon f = new Fordon();
       f.setTill("Ford");
       f.setMod("Mustang");
       f.setArs(2022);
       List<string> fordonli = new List<string>(){f.getTill(), f.getMod(), f.getArs().ToString()};
       fordonmet(fordonli);
    }
}