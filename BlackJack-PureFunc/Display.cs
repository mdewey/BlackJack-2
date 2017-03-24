using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_PureFunc
{
    public class Display
    {
        private static void DisplayHand(string message, List<Card> hand, bool showOnlyFirst = false)
        {
            Console.WriteLine(message);
            for (int i = 0; i < hand.Count; i++)
            {
                if (i >= 1 && showOnlyFirst)
                {
                    Console.WriteLine("[ Face down ]");
                }
                else
                {
                    Console.WriteLine(hand[i]);
                }
            }
        }

        private static void DisplayHandTotal(List<Card> hand)
        {
            Console.Write("Your total is");
            var sum = hand.Sum(card => card.GetCardValue());
            Console.WriteLine(sum);
        }

        private static void Spacer()
        {
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();
        }

        public static bool AskPlayerToHit()
        {
            Spacer();
            Console.WriteLine("Do you want to hit?  y/n");
            var input = Console.ReadLine();
            return String.Compare(input.ToLower(), "y") == 0;
        }

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to blackjack");
        }
        
        public static void ShowPlayerHand(List<Card> hand)
        {

            Spacer();
            DisplayHand("Your Hand", hand);
            DisplayHandTotal(hand);
        }

        public static void ShowDealerHand(List<Card> hand, bool showOnlyFirst = true)
        {
            Spacer();
            DisplayHand("Dealer's Hand", hand, showOnlyFirst);
        }
    }
}
