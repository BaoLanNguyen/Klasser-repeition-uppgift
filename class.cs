class Fordon
{
    private string tillverkare;
    private string modell;
    private int årsmodell;
    public void setTill(string t) {tillverkare = t;}
    public string getTill() {return tillverkare;}
    public void setMod(string m) {modell = m;}
    public string getMod() {return modell;}
    public void setArs(int a) {årsmodell = a;}
    public int getArs() {return årsmodell;}
}