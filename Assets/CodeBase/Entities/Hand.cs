using System.Collections.Generic;

namespace CodeBase.Entities
{
    public class Hand
    {
        private List<Card> _cards = new();

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public Card TakeCard()
        {
            Card card = _cards[0];
            _cards.RemoveAt(0);
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
