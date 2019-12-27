using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public class TopToys
    {
        public int numToys;
        public int topToys;
        public string[] toys;
        public int numQuotes;
        public string[] quotes;


        public string[] GetPopularToys()
        {
            string[] result = new string[this.topToys];

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string toy in this.toys)
            {
                counts.Add(toy, 0);
            }

            foreach (string quote in this.quotes)
            {
                var words = quote.ToLower().Split(" ");

                foreach (string word in words)
                {
                    foreach (string toy in toys)
                    {
                        if (toy == word)
                        {
                            counts[toy]++;
                        }
                    }
                }
            }

            var ordered = counts.OrderByDescending(count => count.Value);
            for (int i = 0; i < this.topToys; i++)
            {
                result[i] = (ordered.ElementAt(i).Key);
            }

            return result;
        }

    }
}
