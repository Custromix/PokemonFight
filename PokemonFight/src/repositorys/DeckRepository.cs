using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;
using PokemonFight.models;


namespace PokemonFight.repository
{
    class DeckRepository
    {
        private User aUser;
        private Connection dbConnect;
        
        public DeckRepository(User _user) 
        {
            this.aUser = _user;
            this.dbConnect = Connection.GetDBConn();
        }
        
        /// <summary>
        /// Requête permettant la selection de tous les deck d'un utilisateurs
        /// </summary>
        /// <returns>Var allDeck Type Deck</returns>
        public List<Deck> selectAllById()
        {

            List<Deck> allDecksUser = new List<Deck>();

            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM deck", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Deck aDeck = new Deck();
                aDeck.IdDeck = int.Parse(reader["ID_DECK"].ToString());
                aDeck.Name = reader["NAME"].ToString();
                allDecksUser.Add(aDeck);
            }
            this.dbConnect.getConnection().Close();
            return allDecksUser;
        }

        /// <summary>
        /// Requête permettant d'insérer un deck à la base de donnée.
        /// </summary>
        public void insert()
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO deck (ID_USER, NAME)" +
                                                    " VALUES(@id, 'Nouveau Deck')", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }
        
    }
}