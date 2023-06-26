using CodeBase.Entities;
using CodeBase.GameSystem;
using CodeBase.Services;
using Reflex.Attributes;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Unity
{
    public class HandView : MonoBehaviour
    {
        [SerializeField]
        private Player _player;

        [SerializeField]
        private Transform[] _cardPlaceholders;

        [SerializeField]
        private CardView _cardViewPrefab;

        private List<CardView> _cardViews = new();

        private IBattlefieldService _battlefieldService;

        [Inject]
        public void Construct(IBattlefieldService battlefieldService)
        {
            _battlefieldService = battlefieldService;
            _battlefieldService.HandsFilled += OnHandsFilled;
        }

        private void OnHandsFilled()
        {
            var handCards = _battlefieldService.PlayerHands[_player].Cards;

            for (int i = 0; i < handCards.Count; i++)
            {
                var cardView = CreateCardView(handCards[i], _cardPlaceholders[i].position);
                _cardViews.Add(cardView);
            }
        }

        private CardView CreateCardView(Card card, Vector3 position)
        {
            var cardView = Instantiate(_cardViewPrefab, position, Quaternion.identity, transform);
            cardView.Construct(card);

            return cardView;
        }
    }
}
