namespace App.Space;

class Universe
{
    List<Astre> astres;

    public Universe()
    {
        this.astres = new List<Astre>();
    }

    public void AddAstre(Astre astre)
    {
        this.astres.Add(astre);
    }

    public override string ToString()
    {
        string s = "[Universe] :\n";
        foreach (var astre in this.astres)
        {
            s += "\t" + astre.ToString().Replace("\t", "\t\t") + "\n";
        }
        return s;
    }
}

