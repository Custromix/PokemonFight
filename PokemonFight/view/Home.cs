using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonFight.models;

namespace PokemonFight
{
    public partial class Home : Form
    {
        private User currentUser;
        public Home(User _user)
        {
            InitializeComponent();
            this.currentUser = _user;
            this.labelNickname.Text = _user.Nickname;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        /* Activation du jeu sous unity */
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            Friend appFriend = new Friend(this.currentUser);
            this.Hide();
            appFriend.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            Notification appNotif = new Notification(this.currentUser);
            this.Hide();
            appNotif.ShowDialog();
            this.Close();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Shop appShop = new Shop(this.currentUser);
            this.Hide();
            appShop.ShowDialog();
            this.Close();
        }

        private void btnDeck_Click(object sender, EventArgs e)
        {
            DeckView appDeck = new DeckView(this.currentUser);
            this.Hide();
            appDeck.ShowDialog();
            this.Close();
        }
    }
}
