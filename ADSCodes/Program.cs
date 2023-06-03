

namespace ADSCodes;

class Program
{
    static void Main(string[] arg)
    {
        Console.WriteLine(StringValidate.IsPasswordComplex("Buddhi12"));
        Console.WriteLine(StringValidate.NormalizeString("     This is a text for the trim, remove comma and to LOWER"));
    }
}

