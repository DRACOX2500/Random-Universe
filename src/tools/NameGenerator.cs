namespace App.Tools;

class NameGenerator
{
    static readonly string[] syllables = new string[] {
        "za", "zo", "ze", "zu", "zi", "zy",
        "ra", "ro", "re", "ru", "ri", "ry",
        "ta", "to", "te", "tu", "ti", "ty",
        "pa", "po", "pe", "pu", "pi", "py",
        "qa", "qo", "qe", "qu", "qi", "qy",
        "sa", "so", "se", "su", "si", "sy",
        "da", "do", "de", "du", "di", "dy",
        "fa", "fo", "fe", "fu", "fi", "fy",
        "ga", "go", "ge", "gu", "gi", "gy",
        "ha", "ho", "he", "hu", "hi", "hy",
        "ja", "jo", "je", "ju", "ji", "jy",
        "ka", "ko", "ke", "ku", "ki", "ky",
        "la", "lo", "le", "lu", "li", "ly",
        "ma", "mo", "me", "mu", "mi", "my",
        "wa", "wo", "we", "wu", "wi", "wy",
        "xa", "xo", "xe", "xu", "xi", "xy",
        "ca", "co", "ce", "cu", "ci", "cy",
        "va", "vo", "ve", "vu", "vi", "vy",
        "ba", "bo", "be", "bu", "bi", "by",
        "na", "no", "ne", "nu", "ni", "ny",
    };

    static string createName(Random random)
    {
        string name = "";
        int length = random.Next(2, 7);
        for (int i = 0; i < length; i++)
        {
            name += syllables[random.Next(0, syllables.Length - 1)];
        }
        name = name.Substring(0, 1).ToUpper() + name.Substring(1, name.Length - 1);
        return name;
    }

    public static string generate()
    {
        Random random = new Random();

        string name = createName(random);
        if (random.Next(0, 2) == 1)
        {
            name += "-" + createName(random);
        }

        return name;
    }
}