using PokemonFight.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonFight.controllers;
using MySql.Data.MySqlClient;


namespace PokemonFight
{
    public partial class Authentification : Form
    {
        private AuthenticatorController Authenticator;
        private User currentUser;

        public Authentification()
        {
            InitializeComponent();
            this.Authenticator = new AuthenticatorController();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            
            if (panelRegister.Visible == false)
            {
                btnSwitch.Text = "Se connecter";
                panelRegister.Visible = true;
                panelLogin.Visible = false;
            }
            else
            {
                btnSwitch.Text = "Créer un compte";
                panelRegister.Visible = false;
                panelLogin.Visible = true;
            }
            
        }
        
        /// <summary>
        /// Récupère les valeurs du formulaire de connection puis connecte la personne
        /// </summary>
        /// <param name="sender">Type object</param>
        /// <param name="e">Type EventArgs</param>
        private void btnLoginConnect_Click(object sender, EventArgs e)
        {
            try
            {
                User aUser = new User();
                aUser.setMail(inputIdLogin.Text);
                aUser.Password = inputPasswordLogin.Text;
                this.Authenticator.setController(aUser);
                if (this.Authenticator.login())
                {
                    this.currentUser = this.Authenticator.getUser();
                    Home appHome = new Home(currentUser);
                    this.Hide();
                    appHome.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Le mot de passe ou l'identifiant n'est pas bon");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
        
        /// <summary>
        /// Récupère les valeurs du formulaire de création de compte puis enregistre le nouveau compte
        /// </summary>
        /// <param name="sender">Type object</param>
        /// <param name="e">Type EventArgs</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User aUser = new User(this.inputNameRegister.Text, this.inputFirstnameRegister.Text, this.inputNicknameRegister.Text, this.inputMailRegister.Text, this.inputPasswordRegister.Text);
                this.Authenticator.setController(aUser);
                if (this.Authenticator.register(this.inputSponsor.Text))
                {
                    MessageBox.Show("Vous êtes bien inscrit veuillez vous connecter");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// AutoConnect sur le User 3
        /// </summary>
        /// <param name="sender">Type object</param>
        /// <param name="e">Type EventArgs</param>
        private void autoConnect_Click(object sender, EventArgs e)
        {
            Connection dbConnect = Connection.GetDBConn();
            User aUser = new User();
            
            dbConnect.getConnection().Open();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE ID_USER = 1", dbConnect.getConnection());
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
            dbConnect.getConnection().Close();
            
            Home appHome = new Home(aUser);
            this.Hide();
            appHome.ShowDialog();
            this.Close();

        }
    }
}
