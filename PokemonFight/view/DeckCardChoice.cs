using System.Windows.Forms;
using PokemonFight.models;

namespace PokemonFight
{
    public partial class DeckCardChoice : Form
    {
        private User aUser;
        private Deck aDeck;
        public DeckCardChoice(User currentUser, int idDeck)
        {
            
            InitializeComponent();
        }
    }
}