using System.Collections.Generic;

namespace CodeBase.Entities
{
    public class Hand
    {
        public List<Card> Cards { get; private set; } = new();

        public Hand(List<Card> cards)
        {
            Cards.AddRange(cards);
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public Card TakeCard()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        //private void OnHandSelectionStarted()
        //{
        //    _cards = _deck.TakeCards(10);
        //}

        //private void ExchangeCard(Card card)
        //{
        //    var cardIndex = _cards.IndexOf(card);
        //    Card newCard = _deck.TakeCard();
            
        //    _deck.AddCard(card);
        //    _cards[cardIndex] = newCard;
        //}
    }
}
