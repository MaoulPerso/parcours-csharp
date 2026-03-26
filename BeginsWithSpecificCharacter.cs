namespace CSharpDiscovery.Quest01
{
    public class BeginsWithSpecificCharacter_Exercice
    {
        public static bool BeginsWithSpecificCharacter(string str, char begin)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            return str.StartsWith(begin);
        }
    }
}