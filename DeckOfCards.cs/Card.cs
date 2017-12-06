using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOfCards
{
    public class Card
    {

        public string Suit { get; protected set; }
        public string Rank { get; protected set; }

        public Card(string rank,string suit)
        {
            Suit = suit;
            Rank = rank;
        }
    }

    public class Deck
    {
        protected Random Random
        {
            get
            {
                return new Random();
            }
        }
        private List<Card> cards;
        List<Card> dealedCards = new List<Card>();
        private List<string> suitList = new List<string>() { "Spades", "Hearts", "Clubs", "Diamonds" };
        private List<string> rankList = new List<string>() { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K", };

        public Deck()
        {
            cards = suitList.SelectMany(
                        suit =>rankList,
                        (suit, rank) => new Card(rank, suit))
                    .ToList();
        }

        public void ShuffleCards()
        {
            cards = cards.OrderBy(a => Random.Next()).ToList();
        }

        public Card DealACard()
        {
            Card selectedCard = null;
            int cardCount = cards.Count;
            int cardIndex = Random.Next(cardCount);
            if(cardCount > 0)
            {
                selectedCard = cards[cardIndex];
                cards.Remove(selectedCard);
            }
            return selectedCard;
        }
    }
}
