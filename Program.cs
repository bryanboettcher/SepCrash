using System.Globalization;
using nietras.SeparatedValues;

namespace POC;

internal class Program
{
    static void Main(string[] args)
    {
        using var reader = Sep.Reader( o => o with
        {
            ColNameComparer = StringComparer.OrdinalIgnoreCase,
            CultureInfo = CultureInfo.InvariantCulture,
            Unescape = true,
            DisableQuotesParsing = false,
            DisableColCountCheck = true
        } ).FromFile( "broken.csv" );

        foreach ( var row in reader )
        {
        }
    }
}
