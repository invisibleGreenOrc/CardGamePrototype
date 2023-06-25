using System.Collections.Generic;

namespace CodeBase.Entities
{
    public class Deck
    {
        private List<Card> _cards = new();

        public int CardsCount => _cards.Count;

        public Card TakeCard()
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public List<Card> TakeCards(int amount)
        {
            var cards = _cards.GetRange(0, amount);
            _cards.RemoveRange(0, amount);
            return cards;
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
            Shuffle();
        }

        public void AddCards(List<Card> cards)
        {
            _cards.AddRange(cards);
            Shuffle();
        }

        private void FillWithCards()
        {

            Shuffle();
        }

        private void Shuffle()
        {
            FisherYatesShuffle(_cards);
        }

        private void FisherYatesShuffle<T>(IList<T> list)
        {
            var rng = new System.Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
