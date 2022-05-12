using System;

namespace PokemonFight
{
    public class Card
    {
        private int idCard;
        private string name;
        private string description;

        public Card()
        {
            
        }

        public int IdCard
        {
            get => idCard;
            set => idCard = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}