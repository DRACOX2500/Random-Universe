namespace App.Space;

using App.Tools;

class Galaxy : Astre
{
    Star star;
    List<World> worlds;

    public Galaxy(string name, Star star) : base(name)
    {
        this.name = name;
        this.star = star;
        this.worlds = new List<World>();
    }

    public Galaxy(string name, Star star, List<World> worlds) : base(name)
    {
        this.name = name;
        this.star = star;
        this.worlds = worlds;
    }

    public override string ToString()
    {
        string s = $"[Galaxy] name: {this.name} :\n";
        s += "\t" + this.star.ToString();
        s += "\t----------------\n";
        foreach (var world in this.worlds)
        {
            s += "\t" + world.ToString().Replace("\t", "\t\t");
        }
        return s;
    }

    public static Galaxy CreateRandom()
    {
        Tools.Random rand = new Tools.Random();
        return new Galaxy(
            Tools.NameGenerator.generate(),
            Star.CreateRandom(),
            World.CreateListRandom()
        );
    }
}

