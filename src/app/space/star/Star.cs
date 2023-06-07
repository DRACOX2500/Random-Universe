namespace App.Space;

using Tools = App.Tools;

class Star : Astre
{
    StarDangerLevel dangerLevel = StarDangerLevel.Gentle;

    public Star(string name, StarDangerLevel dangerLevel) : base(name)
    {
        this.dangerLevel = dangerLevel;
    }

    public override string ToString()
    {
        return $"[Star] name: {this.name}, danger: {this.dangerLevel}\n";
    }

    public static Star CreateRandom()
    {
        Tools.Random rand = new Tools.Random();

        int dangerIndex = rand.Next(0, Enum.GetNames(typeof(StarDangerLevel)).Length);
        StarDangerLevel _danger = Enum.GetValues<StarDangerLevel>()[dangerIndex];
        return new Star(
            Tools.NameGenerator.generate(),
            _danger
        );
    }
}

