using CodeBase.Entities;
using CodeBase.GameSystem;
using System;
using System.Collections.Generic;

namespace CodeBase.Services
{
    public interface IBattlefieldService
    {
        public Dictionary<Player, Deck> PlayerDecks { get; }

        public Dictionary<Player, Hand> PlayerHands { get; }

        public Dictionary<Player, Board> PlayerBoards { get; }

        public event Action DecksLoaded;

        public void LoadPlayerDecks();
    }
}
