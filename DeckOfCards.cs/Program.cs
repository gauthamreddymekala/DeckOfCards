using System;

namespace DeckOfCards
{
    class Program
    {

        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Deal Random Cards");
            deck.ShuffleCards();
            for (int i = 0; i < 53; i++)
            {
                var selectedCard = deck.DealACard();
                if (selectedCard != null)
                    Console.WriteLine(selectedCard.Suit + " " + selectedCard.Rank);
                else
                    Console.WriteLine("No more card to deal");
            }
            Console.ReadLine();
        }
    }
}
