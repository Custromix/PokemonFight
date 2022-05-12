using System;
using System.Windows.Forms;
using PokemonFight.controllers;
using PokemonFight.models;


namespace PokemonFight
{
    public partial class Friend : Form
    {
        private User currentUser;
        private UserController userController;
        public Friend(User _user)
        {
            InitializeComponent();
            this.userController = new UserController(_user);
            this.currentUser = _user;
        }

        private void btnSwitchAddFriend_Click(object sender, EventArgs e)
        {
            this.panelFriendList.Visible = false;
            this.panelAddFriend.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.panelFriendList.Visible = true;
            this.panelAddFriend.Visible = false;
        }

        private void btnSubmitAddFriend_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.userController.addFriend(this.inputNicknameFriend.Text))
                {
                    MessageBox.Show("Demande envoyé");
                }
                else
                {
                    MessageBox.Show("Demande non envoyée");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home appHome = new Home(this.currentUser);
            this.Hide();
            appHome.ShowDialog();
            this.Close();
        }

        private void btnSponsore_Click(object sender, EventArgs e)
        {
            
        }
    }
}