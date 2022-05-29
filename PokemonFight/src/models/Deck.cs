using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight.models
{
    public class Deck
    {
        private User aUser;
        private int idDeck;
        private string name;

        public Deck()
        {
        }

        public User AUser
        {
            get => aUser;
            set => aUser = value;
        }

        public int IdDeck
        {
            get => idDeck;
            set => idDeck = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
