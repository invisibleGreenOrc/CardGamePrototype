using CodeBase.Entities;
using CodeBase.GameSystem;
using System;
using System.Collections.Generic;

namespace CodeBase.Services
{
    public class BattlefieldService : IBattlefieldService
    {
        public Dictionary<Player, Deck> PlayerDecks { get; private set; }

        public Dictionary<Player, Hand> PlayerHands { get; private set; }

        public Dictionary<Player, Board> PlayerBoards { get; private set; }

        private IStaticDataService _staticDataService;

        public event Action DecksLoaded;

        public BattlefieldService(IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
        }

        public void LoadPlayerDecks()
        {
            PlayerDecks = _staticDataService.GetDecks();
            
            DecksLoaded?.Invoke();
        }
    }
}
