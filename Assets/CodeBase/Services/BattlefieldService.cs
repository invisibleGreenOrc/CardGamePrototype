using CodeBase.Entities;
using CodeBase.GameSystem;
using System;
using System.Collections.Generic;

namespace CodeBase.Services
{
    public class BattlefieldService : IBattlefieldService
    {
        public Dictionary<Player, Deck> PlayerDecks { get; private set; }

        public Dictionary<Player, Hand> PlayerHands { get; private set; } = new();

        public Dictionary<Player, Board> PlayerBoards { get; private set; }

        private IStaticDataService _staticDataService;

        public event Action DecksLoaded;

        public event Action HandsFilled;

        public BattlefieldService(IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
        }

        public void LoadCardResources()
        {
            _staticDataService.LoadCardResources();
        }

        public void LoadPlayerDecks()
        {
            PlayerDecks = _staticDataService.GetDecks();
            
            DecksLoaded?.Invoke();
        }

        public void FillPlayerHands()
        {
            PlayerHands.Add(Player.First, new Hand(PlayerDecks[Player.First].TakeCards(10)));
            PlayerHands.Add(Player.Second, new Hand(PlayerDecks[Player.Second].TakeCards(10)));

            HandsFilled?.Invoke();
        }
    }
}
