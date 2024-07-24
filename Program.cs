using System.Globalization;
using nietras.SeparatedValues;

namespace POC;

internal class Program
{
    static void Main(string[] args)
    {
        ReadFile("valid.csv");
        ReadFile("broken.csv");
    }

    private static void ReadFile(string filename)
    {
        using var reader = Sep.Reader( o => o with
        {
            ColNameComparer = StringComparer.OrdinalIgnoreCase,
            CultureInfo = CultureInfo.InvariantCulture,
            Unescape = true,
            DisableQuotesParsing = false,
            DisableColCountCheck = true
        } ).FromFile( filename );

        foreach (var row in reader)
        {
        }
    }
}
