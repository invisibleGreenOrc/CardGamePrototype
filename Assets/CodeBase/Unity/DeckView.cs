using CodeBase.GameSystem;
using CodeBase.Services;
using Reflex.Attributes;
using UnityEngine;

namespace CodeBase.Unity
{
    public class DeckView : MonoBehaviour
    {
        private Player _player;

        private IBattlefieldService _battlefieldService;

        [Inject]
        public void Construct(IBattlefieldService battlefieldService)
        {
            _battlefieldService = battlefieldService;
            _battlefieldService.DecksLoaded += OnDecksLoaded;
        }

        private void OnDecksLoaded()
        {
            Debug.Log(_battlefieldService.PlayerDecks[Player.First].CardsCount);
            Debug.Log(_battlefieldService.PlayerDecks[Player.Second].CardsCount);
        }
    }
}