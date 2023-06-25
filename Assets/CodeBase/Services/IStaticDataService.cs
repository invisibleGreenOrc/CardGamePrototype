using CodeBase.Entities;
using CodeBase.GameSystem;
using System.Collections.Generic;

namespace CodeBase.Services
{
    public interface IStaticDataService
    {
        public Dictionary<Player, Deck> GetDecks();
    }
}
