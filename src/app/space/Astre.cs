namespace App.Space;

abstract class Astre
{
    protected string name;

    public Astre(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return $"[{base.ToString()}] name: {this.name}\n";
    }
}

