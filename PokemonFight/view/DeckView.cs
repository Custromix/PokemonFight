using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PokemonFight.controllers;
using PokemonFight.models;

namespace PokemonFight
{
    public partial class DeckView : Form
    {
        private User currentUser;
        private Deck aDeck;
        private DeckController aDeckController;
        
        public DeckView(User _user)
        {
            this.currentUser = _user;
            this.aDeckController = new DeckController(_user);
            this.showAllDeck();
            InitializeComponent();
        }

        private void showAllDeck()
        {
            int y = 106;
            int x = 201;
            
            int count = 0;

            List<Deck> allDecksUser = this.aDeckController.getAllDeckByUser();
            foreach (Deck aDeck in allDecksUser)
            {
                if (count == 4)
                {
                    count = 0;
                    x = 201;
                    y += 134;
                }
                
                Label deckName = new Label();
                Button btnDeck = new Button();

                deckName.Text = aDeck.Name;
                btnDeck.Text = "Voir le deck";

                deckName.Location = new System.Drawing.Point(x, y-50);
                deckName.Size = new System.Drawing.Size(113, 23);
                deckName.Text = aDeck.Name;

                btnDeck.Location = new System.Drawing.Point(x, y);
                btnDeck.Size = new System.Drawing.Size(75, 23);
                btnDeck.Tag = aDeck.IdDeck;
                btnDeck.Click += goToDeck;

                this.Controls.Add(deckName);
                this.Controls.Add(btnDeck);

                x += 150;
                count++;
            }
        }
        
        private void goToDeck (object btnDeck, EventArgs e)
        {
            DeckCardChoice appDeckChoice = new DeckCardChoice(this.currentUser, int.Parse((btnDeck as Button).Tag.ToString()));
            this.Hide();
            appDeckChoice.ShowDialog();
            this.Close();
        }

        private void btnAddDeck_Click(object sender, EventArgs e)
        {
            this.aDeckController.addNewDeck();
            DeckView appDeck = new DeckView(this.currentUser);
            this.Hide();
            appDeck.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home appHome = new Home(this.currentUser);
            this.Hide();
            appHome.ShowDialog();
            this.Close();
        }
    }
}