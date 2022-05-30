using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonFight.models;
using MySql.Data.MySqlClient;
using BC = BCrypt.Net.BCrypt;

namespace PokemonFight.repository
{
    class UserRepository
    {
        private User aUser;
        private Connection dbConnect;

        /// <summary>
        /// Constructeur et instanciation d'une connection
        /// </summary>
        public UserRepository(User _user) 
        {
            this.aUser = _user;
            this.dbConnect = Connection.GetDBConn();
        }

        /// <summary>
        /// Change l'utilisateur cible
        /// </summary>
        /// <param name="_user">Type User</param>
        public void setUser(User _user)
        {
            this.aUser = _user;
        }

        /// <summary>
        /// Requête permettant la selection d'un utilisateur
        /// </summary>
        /// <param name="id">Type int</param>
        /// <returns>Var _user Type User</returns>
        public User selectOnce(int id)
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE ID_USER = @id", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.aUser.IdUser = int.Parse(reader["ID_USER"].ToString());
                this.aUser.setName(reader["NAME"].ToString());
                this.aUser.setFirstname(reader["FIRSTNAME"].ToString());
                this.aUser.setMail(reader["MAIL"].ToString());
                this.aUser.Password = reader["PASSWORD"].ToString();
                this.aUser.CreationDate = DateTime.Parse(reader["CREATION_DATE"].ToString());
            }
            this.dbConnect.getConnection().Close();

            return this.aUser;
        }
        
        /// <summary>
        /// Requête permettant la selection de tous les utilisateurs
        /// </summary>
        /// <returns>Var allUser Type User</returns>
        public List<User> selectAll()
        {
            List<User> allUser = new List<User>();

            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users", this.dbConnect.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User anUser = new User();
                anUser.IdUser = int.Parse(reader["ID_USER"].ToString());
                anUser.setName(reader["NAME"].ToString());
                anUser.setFirstname(reader["FIRSTNAME"].ToString());
                anUser.setMail(reader["MAIL"].ToString());
                anUser.Password = reader["PASSWORD"].ToString();
                anUser.CreationDate = DateTime.Parse(reader["CREATION_DATE"].ToString());
                allUser.Add(anUser);
            }
            this.dbConnect.getConnection().Close();
            return allUser;
        }
        
        /// <summary>
        /// Requête permettant l'insertion d'un user dans une base de donnée 
        /// </summary>
        public void insert()
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand commandInsert = new MySqlCommand("INSERT INTO users (ID_LEVEL, NAME, FIRSTNAME, NICKNAME, MAIL, PASSWORD, CREATION_DATE)" +
                                                    " VALUES(0, @name, @firstname, @nickname, @mail, @password, @creationDate);", this.dbConnect.getConnection());
            commandInsert.Parameters.Add("@name", MySqlDbType.String).Value = this.aUser.Name;
            commandInsert.Parameters.Add("@firstname", MySqlDbType.String).Value = this.aUser.Firstname;
            commandInsert.Parameters.Add("@nickname", MySqlDbType.String).Value = this.aUser.Nickname;
            commandInsert.Parameters.Add("@mail", MySqlDbType.String).Value = this.aUser.Mail;
            commandInsert.Parameters.Add("@password", MySqlDbType.String).Value = BC.HashPassword(this.aUser.Password);
            commandInsert.Parameters.Add("@creationDate", MySqlDbType.Date).Value = this.aUser.CreationDate;
            commandInsert.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }
        
        /// <summary>
        /// Requête permettant l'ajout du code de sponsor dans la bdd
        /// </summary>
        public void updateSponsorCode()
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand commandUpdate = new MySqlCommand("UPDATE users " +
                                                          "SET SPONSORSHIP_CODE = @sponsorCode", this.dbConnect.getConnection());
            commandUpdate.Parameters.Add("@sponsorCode", MySqlDbType.String).Value = this.aUser.SponsorshipCode;
            commandUpdate.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }

        /// <summary>
        /// Requête permettant la modification d'un utilisateur dans une base de donnée
        /// </summary>
        /// <param name="id">Type int</param>
        public void update(int id)
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("UPDATE user (ID_LEVEL, NAME, FIRSTNAME, MAIL, PASSWORD, CREATION_DATE)" +
                " VALUES(@idLevel, @name, @firstname, @mail, @password, @creationDate)", this.dbConnect.getConnection());
            command.Parameters.Add("@idLevel", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.Parameters.Add("@name", MySqlDbType.String).Value = this.aUser.Name;
            command.Parameters.Add("@firstname", MySqlDbType.String).Value = this.aUser.Firstname;
            command.Parameters.Add("@mail", MySqlDbType.String).Value = this.aUser.Mail;
            command.Parameters.Add("@password", MySqlDbType.String).Value = this.aUser.Password;
            command.Parameters.Add("@creationDate", MySqlDbType.Date).Value = this.aUser.CreationDate;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }

        /// <summary>
        /// Requête permettant de récupérer l'id du potentielle ami ciblé par le pseudonyme
        /// </summary>
        /// <param name="nickname">Type string</param>
        /// <returns>Var idPotentialFriend Type int</returns>
        public int getPotentialFriendId(string nickname)
        {
            int idPotentialFriend = 0;
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT ID_USER FROM users" +
                " WHERE NICKNAME like @nickname", this.dbConnect.getConnection());
            command.Parameters.Add("@nickname", MySqlDbType.String).Value = nickname;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idPotentialFriend = Convert.ToInt32(reader["ID_USER"]);
            }
            this.dbConnect.getConnection().Close();
            return idPotentialFriend;
        }

        /// <summary>
        /// Requête permettant d'avoir la liste complète des amis 
        /// </summary>
        /// <param name="id">Type int</param>
        /// <returns> Collection d'amis. Type List<![CDATA[<user>]]> </returns>
        public List<User> getAllFriendId(int id)
        {
            List<User> allFriends = new List<User>();
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * from users" +
                " WHERE ID_USER IN" +
                "   (SELECT ID_EMITTER from be_friend" +
                "    WHERE (ID_RECEIVER = @id)" +
                "    AND IS_FRIEND = 1)" +
                " OR ID_USER IN" +
                "   (SELECT ID_RECEIVER from be_friend" +
                "   WHERE (ID_EMITTER = @id" +
                "   AND IS_FRIEND = 1)", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User friend = new User();
                friend.IdUser = int.Parse(reader["ID_USER"].ToString());
                friend.setName(reader["NAME"].ToString());
                friend.setFirstname(reader["FIRSTNAME"].ToString());
                friend.setMail(reader["MAIL"].ToString());
                friend.Password = reader["PASSWORD"].ToString();
                friend.CreationDate = DateTime.Parse(reader["CREATION_DATE"].ToString());
                allFriends.Add(friend);
            }
            this.dbConnect.getConnection().Close();
            return allFriends;
        }

        /// <summary>
        /// Requête permettant d'ajouter une nouvelle relation amicale entre deux personne
        /// </summary>
        /// <param name="id">Identifiant de la personne ciblé. Type int</param>
        public void addFriend(int id)
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO be_friend (ID_EMITTER, ID_RECEIVER)" +
                " VALUES(@idEmitter, @idReceiver)", this.dbConnect.getConnection());
            command.Parameters.Add("@idEmitter", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.Parameters.Add("@idReceiver", MySqlDbType.Int64).Value = id;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }

        /// <summary>
        /// Requête permettant de valider la relation amicale entre deux personne
        /// </summary>
        /// <param name="id"> Identifiant </param>
        public void acceptFriendRequest(int id)
        {
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("UPDATE be_friend" +
                " SET IS_FRIEND = 1" +
                " WHERE ID_EMITTER = @idEmitter" +
                " AND ID_RECEIVER = @currentUserId", this.dbConnect.getConnection());
            command.Parameters.Add("@idEmitter", MySqlDbType.Int64).Value = id;
            command.Parameters.Add("@currentUserId", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }

        /// <summary>
        /// Requête permettant de rejeter la relation amicale entre deux personne
        /// </summary>
        /// <param name="id"> Identifiant </param>
        public void rejectFriendRequest(int id)
        {
            MessageBox.Show("emmitter = " + id.ToString() + " " + "receriver = " + this.aUser.IdUser);
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("UPDATE be_friend" +
                " SET IS_FRIEND = 0" +
                " WHERE ID_EMITTER = @idEmitter" +
                " AND ID_RECEIVER = @currentUserId", this.dbConnect.getConnection());
            command.Parameters.Add("@idEmitter", MySqlDbType.Int64).Value = id;
            command.Parameters.Add("@currentUserId", MySqlDbType.Int64).Value = this.aUser.IdUser;
            command.ExecuteNonQuery();
            this.dbConnect.getConnection().Close();
        }
        
        /// <summary>
        /// Requête permettant de savoir s'il y a déjà un lien d'amitié avec une personne
        /// </summary>
        /// <param name="idPotentialFriend">Identifiant Type int</param>
        /// <returns> var isFriend Type bool</returns>
        public bool isFriend(int idPotentialFriend)
        {
            bool isFriend = false;
            int count = 0;
                
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM be_friend" +
                " WHERE (ID_EMITTER = @idUser1" +
                " AND ID_RECEIVER = @idUser2)" +
                " OR (ID_EMITTER = @idUser2" +
                " AND ID_RECEIVER = @idUSer1)", this.dbConnect.getConnection());
            command.Parameters.Add("@idUser1", MySqlDbType.Int64).Value = idPotentialFriend;
            command.Parameters.Add("@idUser2", MySqlDbType.Int64).Value = this.aUser.IdUser;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count++;
            }
            this.dbConnect.getConnection().Close();
            if (count != 0)
            {
                isFriend = true;
            }
            return isFriend;
        }

        /// <summary>
        /// Requête permettant d'obtenir toute les demande d'ami de l'utilisateur en cours.
        /// </summary>
        /// <returns>Var allFriends Type List<![CDATA[<User>]]></returns>
        public List<User> getAllRequest()
        {
            List<User> allFriends = new List<User>();
            this.dbConnect.getConnection().Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users" +
                                                    " INNER JOIN be_friend ON ID_USER = ID_EMITTER" +
                                                    " WHERE ISNULL(IS_FRIEND) AND ID_RECEIVER = @id" +
                                                    " ORDER BY ID_USER DESC", this.dbConnect.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = this.aUser.IdUser;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User _user = new User();
                _user.IdUser = int.Parse(reader["ID_USER"].ToString());
                _user.setName(reader["NAME"].ToString());
                _user.setFirstname(reader["FIRSTNAME"].ToString());
                _user.setNickname(reader["NICKNAME"].ToString());
                _user.setMail(reader["MAIL"].ToString());
                _user.Password = reader["PASSWORD"].ToString();
                _user.CreationDate = DateTime.Parse(reader["CREATION_DATE"].ToString());
                allFriends.Add(_user);
            }

            this.dbConnect.getConnection().Close();
            return allFriends;
        }

        /// <summary>
        /// Requête permettant ed récupérer l'id du parrain grâce à son code
        /// </summary>
        /// <param name="sponsorshipCode">Type string</param>
        /// <returns>var idUser Type int</returns>
        public int getUserBySponsorshipCode(string sponsorshipCode)
        {
            MessageBox.Show(sponsorshipCode.Substring(2, 4));
            MessageBox.Show(sponsorshipCode.Substring(6, 2));
            MessageBox.Show(sponsorshipCode.Substring(2, 4));
            int idUser = -1;
            MySqlCommand command = new MySqlCommand("SELECT * FROM users" +
                                                    " WHERE FIRSTNAME.SUBSTRING(0,1) = @firstnameLetter" +
                                                    " AND ID_USER = @id" +
                                                    " AND CREATION_DATE = @date" +
                                                    " AND NAME.SUBSTRING(0,1) = @nameLetter", this.dbConnect.getConnection());
            command.Parameters.Add("@firstnameLetter", MySqlDbType.String).Value = sponsorshipCode.Substring(0,1);
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = int.Parse(sponsorshipCode.Substring(1,1));
            command.Parameters.Add("@date", MySqlDbType.Date).Value = new DateTime(int.Parse(sponsorshipCode.Substring(2,4)), int.Parse(sponsorshipCode.Substring(6,2)),int.Parse(sponsorshipCode.Substring(8,2)));
            command.Parameters.Add("@nameLetter", MySqlDbType.String).Value = sponsorshipCode.Substring(10,1);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idUser = int.Parse(reader["ID_USER"].ToString());
            }

            return idUser;
        }

        public void updateSponsored()
        {
            
        }

    }
}
