namespace App.Space;

using Tools = App.Tools;
using App.Tools;

class World : Astre
{
    static readonly int RANDOM_LIMIT_MIN = 1000;
    static readonly int RANDOM_LIMIT_MAX = 5000;
    static readonly int RANDOM_LIMIT_LIST_MAX_LENGTH = 10;
    static readonly int RANDOM_MOON_LIMIT_LIST_MAX_LENGTH = 5;

    WorldType type = WorldType.Plain;
    List<Object> creatures;
    List<Moon> satellites;

    double limitX = 0;
    double limitY = 0;

    public World(
        string name,
        double limitX,
        double limitY,
        WorldType type
    ) : base(name)
    {
        this.limitX = limitX;
        this.limitY = limitY;
        this.type = type;
        this.creatures = new List<Object>();
        this.satellites = new List<Moon>();
    }

    public World(
        string name,
        double limitX,
        double limitY,
        WorldType type,
        List<Moon> satellites
    ) : base(name)
    {
        this.limitX = limitX;
        this.limitY = limitY;
        this.type = type;
        this.creatures = new List<Object>();
        this.satellites = satellites;
    }

    public override string ToString()
    {
        string s = $"[World] name: {this.name}, limit: [{this.limitX}; {this.limitY}], type: {this.type}\n";
        foreach (var moon in this.satellites)
        {
            s += "\t" + moon.ToString();
        }
        return s;
    }

    public static World CreateRandom()
    {
        Tools.Random rand = new Tools.Random();
        string name = NameGenerator.generate();
        double _limitX = rand.NextDouble(World.RANDOM_LIMIT_MIN, World.RANDOM_LIMIT_MAX);
        double _limitY = rand.NextDouble(World.RANDOM_LIMIT_MIN, World.RANDOM_LIMIT_MAX);

        int typeIndex = rand.Next(0, Enum.GetNames(typeof(WorldType)).Length);
        WorldType _type = Enum.GetValues<WorldType>()[typeIndex];

        var moonLength = rand.Next(0, World.RANDOM_MOON_LIMIT_LIST_MAX_LENGTH);
        var moons =  new List<Moon>();
        for (int i = 0; i < moonLength; i++)
        {
           moons.Add(new Moon($"{name} {Converter.ToRoman(i+1)}"));
        }

        return new World(
            name,
            _limitX,
            _limitY,
            _type,
            moons
        );
    }

    public static List<World> CreateListRandom()
    {
        var rand = new Tools.Random();
        var length = rand.Next(0, World.RANDOM_LIMIT_LIST_MAX_LENGTH);
        var worlds =  new List<World>();
        for (int i = 0; i < length; i++)
        {
           worlds.Add(World.CreateRandom());
        }
        return worlds;
    }
}
