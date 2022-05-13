using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonFight.repository;

namespace PokemonFight.controllers
{
    public class CardController
    {
        private CardRepository cardRepository;
        
        public CardController(User _user)
        {
            this.cardRepository = new CardRepository(_user);
        }

        public List<Card> buyCards()
        {
            List<Card> allCard = new List<Card>();
            this.cardRepository.selectPokemonByRand(898);
            
            return allCard;
        }
    }
}