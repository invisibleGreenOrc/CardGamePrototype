using CodeBase.Entities;
using UnityEngine;

namespace CodeBase.Infrastructure.StaticData.CardStaticData
{
    [CreateAssetMenu(fileName = "CardPackData", menuName = "Static Data/Card Pack Data")]
    public class CardPackStaticData : ScriptableObject
    {
        [SerializeField]
        private HeroClass _class;

        [field: SerializeField]
        public int Cost { get; set; }

        [SerializeField]
        public CardData[] Cards;
    }
}