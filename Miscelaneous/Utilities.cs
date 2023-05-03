using System;
using System.Diagnostics.Metrics;

namespace Miscelaneous
{
    public static class Utilities
	{
        public static List<int> GetModas(List<int> numbers)
        {
            var counters = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (counters.ContainsKey(number))
                {
                    counters[number]++; 
                }
                else
                {
                    counters.Add(number, 1);
                }
            }
            var maxValue = counters.Max(x => x.Value);
            return counters
                .Where(x => x.Value == maxValue)
                .Select(x => x.Key)
                .ToList();
        }

        public static List<int> Fill(int n, int min, int max)
        {
            var random = new Random();
            var numbers = new List<int>();
            max++;
            for (int i = 0; i < n; i++)
            {
                numbers.Add(random.Next(min, max));
            }
            return numbers;
        }

        public static string ToString(List<int> numbers)
        {
            var output = string.Empty;
            foreach (var number in numbers)
            {
                output += $"{number}\t";
            }
            return output + "\n";
        }
    }
}

