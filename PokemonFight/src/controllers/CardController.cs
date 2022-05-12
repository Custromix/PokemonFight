using System.Collections.Generic;
using PokemonFight.repository;

namespace PokemonFight.controllers
{
    public class CardController
    {
        private CardRepository cardRepository;
        
        public CardController()
        {
            this.cardRepository = new CardRepository();
        }

        public List<Card> getAll()
        {
            return this.cardRepository.selectAll();
        }
    }
}