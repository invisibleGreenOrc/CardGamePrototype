namespace CodeBase.Entities
{
    public class Card
    {
        public int Id { get; set; }

        //public HeroClass Class { get; private set; }

        public MinionType Type { get; set; }

        public int Cost { get; set; }

        public int Attack { get; set; }

        public int Health { get; set; }
    }
}