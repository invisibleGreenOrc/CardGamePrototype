using System.Collections.Generic;

namespace CodeBase.Entities
{
    public class Board
    {
        private List<Card> _cards = new();

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public void RemoveCard(int id)
        {
            _cards.RemoveAll(card => card.Id == id);
        }
    }
}