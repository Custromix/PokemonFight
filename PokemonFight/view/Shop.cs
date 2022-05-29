using System;
using System.Windows.Forms;
using PokemonFight.controllers;

namespace PokemonFight
{
    public partial class Shop : Form
    {
        private User currentUser;
        private CardController cardController;
        public Shop(User _user)
        {
            this.currentUser = _user;
            this.cardController = new CardController(_user);
            InitializeComponent();
        }


        private void btnBuyCard_Click(object sender, EventArgs e)
        {
            this.cardController.buyCards();
        }
    }
}