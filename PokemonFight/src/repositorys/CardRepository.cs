using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PokemonFight.models;
using BC = BCrypt.Net.BCrypt;
using PokeAPI;

namespace PokemonFight.repository
{
    class CardRepository
    {
        private const string URL_POKEMON_ID = "https://pokeapi.co/api/v2/pokemon/";
        private User aUser;
        private Connection dbConnect;
        
        public CardRepository(User currentUser)
        {
            this.aUser = currentUser;
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Card> selectPokemonByRand(int id)
        {
            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_POKEMON_ID);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(id.ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                object Objects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
            
            return new List<Card>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCard"></param>
        /// <param name="nbrCard"></param>
        public void insertCatch(int idCard, int nbrCard)
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (ID_USER, ID_CARD, NBR_CARD)" +
                                                    " VALUES(@idUser, @idCard, @nbrCard);", this.dbConnect.getConnection());
            command.Parameters.Add("@idUser", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.Parameters.Add("@idCard", MySqlDbType.Int64).Value = idCard;
            command.Parameters.Add("@nbrCard", MySqlDbType.Int64).Value = nbrCard;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Card> SelectAllUserCard()
        {
            List<Card> allDeck = new List<Card>();
            
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM catch WHERE ID_USER = @id", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
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