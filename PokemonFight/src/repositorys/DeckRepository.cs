using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PokemonFight.models;
using BC = BCrypt.Net.BCrypt;


namespace PokemonFight.repository
{
    class DeckRepository
    {
        private User aUser;
        private Deck aDeck;
        private Connection dbConnect;
        
        public DeckRepository(Deck _deck, User _user) 
        {
            this.aDeck = _deck;
            this.aUser = _user;
            this.dbConnect = Connection.GetDBConn();
        }
        
        /// <summary>
        /// Requête permettant la selection de tous les deck d'un utilisateurs
        /// </summary>
        /// <returns>Var allDeck Type Deck</returns>
        public List<Deck> selectAllById()
        {
            List<Deck> allDeck = new List<Deck>();

            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM deck" +
                                                    "WHERE ID_USER = @id", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.aDeck.IdDeck = int.Parse(reader["ID_DECK"].ToString());
                //this.aUser.IdUser = int.Parse(reader["ID_USER"].ToString());
                //allDeck.Add(this.aUser);
            }
            this.dbConnect.getConnection().Close();
            return allDeck;
        }
        
        
        /// <summary>
        /// Requête permettant d'insérer un deck à la base de donnée.
        /// </summary>
        public void insert()
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO deck (ID_USER)" +
                                                    " VALUES(@id)", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }
        
    }
}