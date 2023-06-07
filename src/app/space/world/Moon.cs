namespace App.Space;

class Moon: Astre
{
    public Moon(string name): base(name)
    {
    }

    public override string ToString()
    {
        return $"[Moon] name: {this.name}\n";
    }
}