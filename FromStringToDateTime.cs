using System;
using System.Globalization;

namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            string format = "dd/MM/yyyy HH:mm";
            return DateTime.ParseExact(dateStr, format, CultureInfo.InvariantCulture);
        }
    }
}