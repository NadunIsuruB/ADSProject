

namespace ADSCodes;

class Program
{
    //string validation
    static Boolean IsUppercase(string s)
    {
        return s.All(char.IsUpper);
    }

    static Boolean IsPasswordComplex(string s) {
        return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
    }


    static void Main(string[] arg)
    {
        Console.WriteLine(IsPasswordComplex("Buddhi12"));
    }
}

