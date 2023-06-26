using CodeBase.GameSystem;
using CodeBase.Services;
using Reflex.Attributes;
using UnityEngine;

namespace CodeBase.Unity
{
    public class BattlefieldController : MonoBehaviour
    {
        private Game _game;

        private IBattlefieldService _battlefieldService;

        [Inject]
        public void Construct(Game game, IBattlefieldService battlefieldService)
        {
            _game = game;
            _battlefieldService = battlefieldService;

            _game.LoadingStarted += OnLoadingStarted;
            _game.HandSelectionStarted += OnHandSelectionStarted;
        }

        private void OnLoadingStarted()
        {
            _battlefieldService.LoadCardResources();
            _battlefieldService.LoadPlayerDecks();
        }

        private void OnHandSelectionStarted()
        {
            _battlefieldService.FillPlayerHands();
        }
    }
}