using System;
using System.Diagnostics.Metrics;

namespace Miscelaneous
{
    public static class Utilities
	{
        public static List<int> Anagrams(List<string> sentencesSource, List<string> sentencesTarget)
        {
            if (sentencesSource.Count != sentencesTarget.Count)
            {
                throw new Exception("The lists have different elements number.");
            }
            var output = new List<int>();
            for (int i = 0; i < sentencesSource.Count; i++)
            {
                output.Add(Anagrams(sentencesSource[i], sentencesTarget[i]));
            }
            return output;
        }

        public static int Anagrams(string source, string target)
        {
            if (source.Length != target.Length)
            {
                return -1;
            }

            var sourceDictionary = GetDictionary(source);
            var targetDictionary = GetDictionary(target);

            var counter = 0;
            var i = 0;
            var j = 0;
            while (i < sourceDictionary.Count && j < targetDictionary.Count)
            {
                if (sourceDictionary.ElementAt(i).Key == targetDictionary.ElementAt(j).Key)
                {
                    counter += Math.Abs(sourceDictionary.ElementAt(i).Value - targetDictionary.ElementAt(j).Value);
                    i++;
                    j++;
                }
                else if (sourceDictionary.ElementAt(i).Key < targetDictionary.ElementAt(j).Key)
                {
                    counter += sourceDictionary.ElementAt(i).Value;
                    i++;
                }
                else
                {
                    counter += targetDictionary.ElementAt(j).Value;
                    j++;
                }
            }
            while (i < sourceDictionary.Count)
            {
                counter += sourceDictionary.ElementAt(i).Value;
                i++;
            }
            while (j < targetDictionary.Count)
            {
                counter += targetDictionary.ElementAt(j).Value;
                j++;
            }

            return counter / 2;
        }

        private static SortedDictionary<char, int> GetDictionary(string sentence)
        {
            var dictionary = new SortedDictionary<char, int>();
            foreach (var character in sentence.ToLower())
            {
                if (dictionary.ContainsKey(character))
                {
                    dictionary[character]++;
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }
            return dictionary;
        }

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

