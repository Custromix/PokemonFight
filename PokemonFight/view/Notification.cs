using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PokemonFight.controllers;

namespace PokemonFight
{
    public partial class Notification : Form
    {
        private User currentUser;
        private UserController userController;
        public Notification(User _user)
        {
            InitializeComponent();
            this.userController = new UserController(_user);
            this.currentUser = _user;
            this.showAllRequest();
        }

        public void showAllRequest(){
        
            int y = 28;

            List<User> allUsersRequest = this.userController.getAllRequest();

            foreach (User aUser in allUsersRequest)
            {
                Label nickName = new Label();
                Button accept = new Button();
                Button reject = new Button();

                nickName.Text = aUser.Nickname;
                accept.Text = "Accepter";
                reject.Text = "Rejeter";

                nickName.Location = new System.Drawing.Point(44, y);
                nickName.Size = new System.Drawing.Size(113, 23);
                nickName.Text = aUser.Nickname;

                accept.Location = new System.Drawing.Point(339, y);
                accept.Size = new System.Drawing.Size(75, 23);
                accept.Tag = aUser.IdUser;
                accept.Click += acceptRequest;
                
                reject.Location = new System.Drawing.Point(164, y);
                reject.Size = new System.Drawing.Size(75, 23);
                reject.Tag = aUser.IdUser;
                reject.Click += rejectRequest;
                
                panelAllNotif.Controls.Add(nickName);
                panelAllNotif.Controls.Add(accept);
                panelAllNotif.Controls.Add(reject);
                y += 30;
            }
        }

        public void acceptRequest(object aButton, EventArgs e)
        {
            int id = int.Parse((aButton as Button).Tag.ToString());
            this.userController.acceptFriend(id);
            this.gotoNotif();
        }
        
        public void rejectRequest(object aButton, EventArgs e)
        {
            int id = int.Parse((aButton as Button).Tag.ToString());
            this.userController.rejectFriend(id);
            this.gotoNotif();
        }

        public void gotoNotif()
        {
            Notification appNotif = new Notification(this.currentUser);
            this.Hide();
            appNotif.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home appHome = new Home(this.currentUser);
            this.Hide();
            appHome.ShowDialog();
            this.Close();
        }
    }
}