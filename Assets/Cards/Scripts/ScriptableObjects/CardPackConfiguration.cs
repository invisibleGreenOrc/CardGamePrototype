using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cards.ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewCardPackConfiguration", menuName = "CardConfigs/Card Pack Configuration")]
    public class CardPackConfiguration : ScriptableObject
    {
        private bool _isConstruct;

        [SerializeField]
        private SideType _sideType;
        [SerializeField]
        private ushort _cost;
        [SerializeField]
        private CardPropertiesData[] _cards;

        public IEnumerable<CardPropertiesData> UnionProperties(IEnumerable<CardPropertiesData> array)
        {
            TryToContruct();

            return array.Union(_cards);
        }

        private void TryToContruct()
        {
            if (_isConstruct)
                return;

            for (int i = 0; i < _cards.Length; i++)
            {
                _cards[i].Cost = _cost;
            }

            _isConstruct = true;
        }
    }
}