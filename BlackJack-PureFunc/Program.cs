using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack_PureFunc.display;
using BlackJack_PureFunc.logic;

namespace BlackJack_PureFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Display.DisplayWelcomeMessage();

            var deck = Blackjack.ShuffleDeck(Blackjack.CreateDeck());
            Card cardSlot;
            var userHand = new List<Card>();
            var dealerHand = new List<Card>();

            (deck, cardSlot) = Blackjack.DealCard(deck);
            userHand.Add(cardSlot);

            (deck, cardSlot) = Blackjack.DealCard(deck);
            dealerHand.Add(cardSlot);

            (deck, cardSlot) = Blackjack.DealCard(deck);
            userHand.Add(cardSlot);

            (deck, cardSlot) = Blackjack.DealCard(deck);
            dealerHand.Add(cardSlot);


            Display.ShowDealerHand(dealerHand);

            Display.ShowPlayerHand(userHand, Blackjack.GetHandTotal(userHand));
            
            var hit = Display.AskPlayerToHit();

            while (hit && Blackjack.GetHandTotal(userHand) < 21)
            {
                (deck, cardSlot) = Blackjack.DealCard(deck);
                userHand.Add(cardSlot);
                Display.ShowPlayerHand(userHand, Blackjack.GetHandTotal(userHand));
                hit = Display.AskPlayerToHit();
            }
        }
    }
}
