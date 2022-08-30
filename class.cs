class Fordon
{
    private string tillverkare;
    private string modell;
    private int årsmodell;
    public string Tillverkare {
        get { return tillverkare;}
        set {tillverkare = value;}
    }
        public string Modell {
        get { return modell;}
        set {modell = value;}
    }
        public int Årsmodell {
        get { return årsmodell;}
        set {årsmodell = value;}
    }
    public Fordon(string t, string m, int å){
        tillverkare = t;
        modell = m;
        årsmodell = å;
    }
    public Fordon(){}
}