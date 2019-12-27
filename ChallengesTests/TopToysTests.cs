using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges.Tests
{
    [TestClass()]
    public class TopToysTests
    {
        [TestMethod()]
        public void GetPopularToysTest()
        {
            TopToys topToys = new TopToys
            {
                numToys = 6,
                topToys = 2,
                toys = new[] {
                    "elmo",
                    "elsa",
                    "legos",
                    "drone",
                    "tablet",
                    "warcraft"
                },
                numQuotes = 6,
                quotes = new[] {
                    "Emo is the hottest of the season! Elmo will be on every kid's wishlist!",
                    "The new Elmo dolls are super high quality",
                    "Expect the Elsa dolls to be very popular this year",
                    "Elsa and Elmo are the toys I'll be buying for my kids",
                    "For parents of older kids, look into buying them a drone",
                    "Warcraft is slowly rising in popularity ahead of the holiday season"
               }
            };

            CollectionAssert.AreEqual(topToys.GetPopularToys(), new[] { "elmo", "elsa" });
        }
    }
}