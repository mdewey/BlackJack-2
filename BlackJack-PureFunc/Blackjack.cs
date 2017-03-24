using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_PureFunc.logic
{
    public static class Blackjack
    {
        public static List<Card> CreateDeck(int NumberOfDecks = 1)
        {

            var deck = new List<Card>();
            for (int i = 0; i < NumberOfDecks; i++)
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    foreach (Suit s in Enum.GetValues(typeof(Suit)))
                    {
                        deck.Add(new Card(s, r));
                    }
                }
            }
            return deck;
        }

        public static List<Card> ShuffleDeck(List<Card> unShuffledDeck)
        {
            return unShuffledDeck.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static (List<Card>, Card) DealCard(List<Card> deck)
        {
            var cardToReturn = deck[0];
            deck.RemoveAt(0);
            return (deck, cardToReturn);
        }

       public static int GetHandTotal (List<Card> hands)
        {
            return hands.Sum(card => card.GetCardValue());
        }
    }
}
