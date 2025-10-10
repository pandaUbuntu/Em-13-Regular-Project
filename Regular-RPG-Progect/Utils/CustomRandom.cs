using System;

namespace Regular_RPG_Progect.Utils
{
    class CustomRandom
    {
        private static Random random = new Random();
        public static int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
