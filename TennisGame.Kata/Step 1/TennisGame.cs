using NUnit.Framework;

namespace TennisGame.Kata
{
    /* Basic
     *      This Kata is about implementing a simple tennis game. The rules are simplified, so the winner is decided after one game.
     *      A game lasts until one player has scored at least 4 times, and has scored at least 2 more times than the opponent.
     *  Assert
     *      Assert That(4-0, Winner is A)
     *      Assert That(4-4, No winner)
     *      Assert That(2-0, No winner)
     *      Assert That(5-7, Winner is B)
     */
    /* Advanced
     *      Write the score for every point with the standard terminology for tennis.
     *      Instead of using scores from 0-3, use the tennis terminology of 0-40, advantage
     *  Assert
     *      Assert That(5-4, AD-40)
     *      Assert That(2-1, 30-15)
     *      Assert That(7-7, Deuce)
     *      Assert That(7-9, Winner is B)
     */
    /* References 
     * http://codingdojo.org/cgi-bin/wiki.pl?KataTennis
     * http://en.wikipedia.org/wiki/Tennis_score
     */
    [TestFixture]
    public class TennisGame
    {
        [Test]
        public void TestMethod()
        {
        }
    }
}