using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PokemonFight.models;
using BC = BCrypt.Net.BCrypt;

namespace PokemonFight.repository
{
    class CardRepository
    {
        private Card aCard;
        private Connection dbConnect;
        
        public CardRepository()
        {
            this.aCard = new Card();
        }
        
        /// <summary>
        /// Requête permettant la selection de toutes les cartes du jeu
        /// </summary>
        /// <returns>allDeck Type List<![CDATA[<Card>]]></returns>
        public List<Card> selectAll()
        {
            List<Card> allDeck = new List<Card>();
            
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM card", this.dbConnect.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Card newCard = new Card();
                newCard.IdCard = int.Parse(reader["ID_CARD"].ToString());
                newCard.Name = reader["NAME"].ToString();
                newCard.Description = reader["DESCRIPTION"].ToString();
                allDeck.Add(newCard);
            }
            this.dbConnect.getConnection().Close();
            return allDeck;
        }
    }
}