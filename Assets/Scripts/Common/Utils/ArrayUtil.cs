using System;
using System.Collections.Generic;

namespace Common.Utils
{
    public static class ArrayUtil
    {
        private static readonly Random Rand = new Random();

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Rand.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}