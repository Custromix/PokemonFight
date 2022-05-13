using System;
using System.Collections.Generic;
using PokemonFight.models;
using PokemonFight.repository;

namespace PokemonFight.controllers
{
    public class DeckController
    {
        private DeckRepository deckRepository;
        
        public DeckController(User _user)
        {
            this.deckRepository = new DeckRepository(_user);
        }
        
        public void addNewDeck()
        {
            try
            {
                this.deckRepository.insert();
            }
            catch (Exception e)
            {
                throw new Exception("Problème lors de l'insertion du deck");
            }
        }

        public List<Deck> getAllDeckByUser()
        {
            return this.deckRepository.selectAllById();
        }
    }
}