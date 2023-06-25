using CodeBase.Entities;
using System;
using UnityEngine;

namespace CodeBase.Infrastructure.StaticData.CardStaticData
{
    [Serializable]
    public struct CardData
    {
        [field: SerializeField]
        public int Id {  get; private set; }

        //public HeroClass Class { get; private set; }

        [field: SerializeField]
        public MinionType Type { get; private set; }

        //public int Cost { get; private set; }

        [field: SerializeField]
        public int Attack { get; private set; }

        [field: SerializeField]
        public int Health { get; private set; }

        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public string Description { get; private set; }

        [field: SerializeField]
        public Texture Image { get; private set; }
    }
}