using CodeBase.Entities;
using CodeBase.GameSystem;
using UnityEngine;

namespace CodeBase.Infrastructure.StaticData
{
    [CreateAssetMenu(fileName = "DeckData", menuName = "Static Data/Deck Data")]
    public class DeckData : ScriptableObject
    {
        [field: SerializeField]
        public Player Player { get; private set; }

        [SerializeField]
        private HeroClass _class;

        [field: SerializeField]
        public int[] CardIds { get; private set; }
    }
}
