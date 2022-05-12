using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonFight.models
{
    class Deck
    {
        private int idDeck;
        private string name;

        public Deck()
        {
            
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
