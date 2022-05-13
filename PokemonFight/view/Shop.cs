using System.Windows.Forms;

namespace PokemonFight
{
    public partial class Shop : Form
    {
        private User currentUser;
        public Shop(User _user)
        {
            this.currentUser = _user;
            InitializeComponent();
        }
        
        
    }
}