using System;
using System.Windows.Forms;
using PokemonFight.models;

namespace PokemonFight
{
    public partial class DeckCardChoice : Form
    {
        private User currentUser;
        private Deck aDeck;
        public DeckCardChoice(User currentUser, int idDeck)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.labelNameDeck.Text = "Deck N°" + idDeck;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeckView appDeck = new DeckView(this.currentUser);
            this.Hide();
            appDeck.ShowDialog();
            this.Close();        
        }
    }
}