using CodeBase.Entities;
using CodeBase.GameSystem;
using CodeBase.Infrastructure.StaticData;
using CodeBase.Infrastructure.StaticData.CardStaticData;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CodeBase.Services
{
    public class StaticDataService : IStaticDataService
    {
        private DeckData[] _decksStaticData;

        private CardPackStaticData[] _cardPackStaticData;

        public void LoadCardResources()
        {
            _decksStaticData = Resources.LoadAll<DeckData>("StaticData/Decks");
            _cardPackStaticData = Resources.LoadAll<CardPackStaticData>("StaticData/Cards");
        }

        public Dictionary<Player, Deck> GetDecks()
        {
            var playerDecks = new Dictionary<Player, Deck>();

            foreach (DeckData deckData in _decksStaticData)
            {
                var deck = CreateDeck(GetCards(deckData.CardIds));
                playerDecks.TryAdd(deckData.Player, deck);
            }

            return playerDecks;
        }

        private List<Card> GetCards(int[] ids)
        {
            var cards = new List<Card>();

            foreach (CardPackStaticData cardPackData in _cardPackStaticData)
            {
                foreach (CardData cardData in cardPackData.Cards.Where(card => ids.Contains(card.Id)))
                {
                    cards.Add(new Card
                    {
                        Id = cardData.Id,
                        Type = cardData.Type,
                        Cost = cardPackData.Cost,
                        Attack = cardData.Attack,
                        Health = cardData.Health
                    });;
                }
            }

            return cards;
        }

        private Deck CreateDeck(List<Card> cards)
        {
            var deck = new Deck();
            deck.AddCards(cards);

            return deck;
        }
    }
}
