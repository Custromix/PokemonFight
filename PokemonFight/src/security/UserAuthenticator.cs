using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonFight.models;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace PokemonFight.security
{
    class UserAuthenticator
    {
        private Connection dbConnect;

        public UserAuthenticator()
        {
            this.dbConnect = Connection.GetDBConn();
        }
        
        /// <summary>
        /// Retourne true si le nom d'utilisateur ou mail existe false sinon
        /// </summary>
        /// <param name="_user">Type User</param>
        /// <returns>var isExist type bool</returns>
        public bool isExist(User _user)
        {
            bool isExist = true;
            int result = 0;

            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE MAIL LIKE @mail OR NICKNAME LIKE @pseudonym", this.dbConnect.getConnection());
            command.Parameters.Add("@mail", MySqlDbType.String).Value = _user.Mail;
            command.Parameters.Add("@pseudonym", MySqlDbType.String).Value = _user.Nickname;
            MySqlDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                result++;
            }

            if (result == 0)
            {
                isExist = false;
            }
            this.dbConnect.getConnection().Close();
            return isExist;
        }
        
        /// <summary>
        /// Recupère l'utilisateur avec une requête sql select par son mail
        /// </summary>
        /// <param name="_user">User</param>
        /// <returns>var aUser type User</returns>
        public User getPotentialLogUser(User _user)
        {
            User aUser = new User();
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE MAIL = @mail", this.dbConnect.getConnection());
            command.Parameters.Add("@mail", MySqlDbType.String).Value = _user.Mail;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                aUser.IdUser = int.Parse(reader["ID_USER"].ToString());
                aUser.setName(reader["NAME"].ToString());
                aUser.setFirstname(reader["FIRSTNAME"].ToString());
                aUser.setNickname(reader["NICKNAME"].ToString());
                aUser.setMail(reader["MAIL"].ToString());
                aUser.Password = reader["PASSWORD"].ToString();
                aUser.CreationDate = DateTime.Parse(reader["CREATION_DATE"].ToString());
            }
            this.dbConnect.getConnection().Close();

            return aUser;
        }

    }
}
