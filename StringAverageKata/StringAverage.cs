using System.Collections.Generic;
using System.Linq;

namespace StringAverageKata
{
    public class StringAverage
    {
        private readonly Dictionary<string, int> _stringNumberLookUp = new Dictionary<string, int>()
        {
            ["zero"] = 0,
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4,
            ["five"] = 5,
            ["six"] = 6,
            ["seven"] = 7,
            ["eight"] = 8,
            ["nine"] = 9,
        };

        public int GetAverage(string numbers)
        {
            var stringNumbers = numbers.Split(' ').ToList();

            var sum = 0;
            stringNumbers.ForEach(number => { sum += _stringNumberLookUp[number]; });

            var avg = (int)sum / stringNumbers.Count;

            return avg;
        }
    }
}