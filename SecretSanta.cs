using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        private static Random _random = new Random();

        public static Dictionary<string, string> SecretSantaDraw(HashSet<string> people)
        {
            var result = new Dictionary<string, string>();
            if (people == null || people.Count < 2) return result;
            List<string> givers = people.ToList();
            List<string> receivers = people.ToList();
            bool validDraw = false;

            while (!validDraw)
            {
                for (int i = receivers.Count - 1; i > 0; i--)
                {
                    int j = _random.Next(i + 1);
                    string temp = receivers[i];
                    receivers[i] = receivers[j];
                    receivers[j] = temp;
                }
                validDraw = true;
                for (int i = 0; i < givers.Count; i++)
                {
                    if (givers[i] == receivers[i])
                    {
                        validDraw = false;
                        break;
                    }
                }
            }
            for (int i = 0; i < givers.Count; i++)
            {
                result.Add(givers[i], receivers[i]);
            }

            return result;
        }
    }
}