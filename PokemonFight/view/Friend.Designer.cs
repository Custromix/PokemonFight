using System.ComponentModel;

namespace PokemonFight
{
    partial class Friend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelSearchFriend = new System.Windows.Forms.Label();
            this.panelFriendList = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSwitchAddFriend = new System.Windows.Forms.Button();
            this.panelAddFriend = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.inputNicknameFriend = new System.Windows.Forms.TextBox();
            this.btnSubmitAddFriend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFriendList.SuspendLayout();
            this.panelAddFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFriends
            // 
            this.labelFriends.Location = new System.Drawing.Point(15, 21);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(70, 18);
            this.labelFriends.TabIndex = 2;
            this.labelFriends.Text = "Liste d\'amis";
            // 
            // labelSearchFriend
            // 
            this.labelSearchFriend.Location = new System.Drawing.Point(165, 23);
            this.labelSearchFriend.Name = "labelSearchFriend";
            this.labelSearchFriend.Size = new System.Drawing.Size(100, 23);
            this.labelSearchFriend.TabIndex = 0;
            this.labelSearchFriend.Text = "Rechercher un ami";
            // 
            // panelFriendList
            // 
            this.panelFriendList.Controls.Add(this.btnHome);
            this.panelFriendList.Controls.Add(this.label1);
            this.panelFriendList.Controls.Add(this.btnSwitchAddFriend);
            this.panelFriendList.Location = new System.Drawing.Point(144, 12);
            this.panelFriendList.Name = "panelFriendList";
            this.panelFriendList.Size = new System.Drawing.Size(533, 426);
            this.panelFriendList.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(38, 386);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(56, 19);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Retour";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste d\'amis";
            // 
            // btnSwitchAddFriend
            // 
            this.btnSwitchAddFriend.Location = new System.Drawing.Point(424, 20);
            this.btnSwitchAddFriend.Name = "btnSwitchAddFriend";
            this.btnSwitchAddFriend.Size = new System.Drawing.Size(87, 23);
            this.btnSwitchAddFriend.TabIndex = 1;
            this.btnSwitchAddFriend.Text = "Ajouter un ami";
            this.btnSwitchAddFriend.UseVisualStyleBackColor = true;
            this.btnSwitchAddFriend.Click += new System.EventHandler(this.btnSwitchAddFriend_Click);
            // 
            // panelAddFriend
            // 
            this.panelAddFriend.Controls.Add(this.btnBack);
            this.panelAddFriend.Controls.Add(this.inputNicknameFriend);
            this.panelAddFriend.Controls.Add(this.btnSubmitAddFriend);
            this.panelAddFriend.Controls.Add(this.label2);
            this.panelAddFriend.Location = new System.Drawing.Point(49, 150);
            this.panelAddFriend.Name = "panelAddFriend";
            this.panelAddFriend.Size = new System.Drawing.Size(726, 229);
            this.panelAddFriend.TabIndex = 0;
            this.panelAddFriend.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(189, 67);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // inputNicknameFriend
            // 
            this.inputNicknameFriend.Location = new System.Drawing.Point(301, 114);
            this.inputNicknameFriend.Name = "inputNicknameFriend";
            this.inputNicknameFriend.Size = new System.Drawing.Size(100, 20);
            this.inputNicknameFriend.TabIndex = 2;
            // 
            // btnSubmitAddFriend
            // 
            this.btnSubmitAddFriend.Location = new System.Drawing.Point(315, 158);
            this.btnSubmitAddFriend.Name = "btnSubmitAddFriend";
            this.btnSubmitAddFriend.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAddFriend.TabIndex = 0;
            this.btnSubmitAddFriend.Text = "Ajouter";
            this.btnSubmitAddFriend.UseVisualStyleBackColor = true;
            this.btnSubmitAddFriend.Click += new System.EventHandler(this.btnSubmitAddFriend_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(315, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ajouter un ami";
            // 
            // Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFriendList);
            this.Controls.Add(this.panelAddFriend);
            this.Name = "Friend";
            this.Text = "Friend";
            this.panelFriendList.ResumeLayout(false);
            this.panelAddFriend.ResumeLayout(false);
            this.panelAddFriend.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelFriendList;
        private System.Windows.Forms.Panel panelAddFriend;
        private System.Windows.Forms.Button btnSwitchAddFriend;
        private System.Windows.Forms.Button btnSubmitAddFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNicknameFriend;
        private System.Windows.Forms.Label labelSearchFriend;
        private System.Windows.Forms.Label labelFriends;

        #endregion
    }
}