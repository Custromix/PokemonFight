
namespace PokemonFight
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnDeck = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnNotif = new System.Windows.Forms.Button();
            this.labelNickname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(74, 108);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Jouer";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(74, 290);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(75, 23);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Boutique";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnDeck
            // 
            this.btnDeck.Location = new System.Drawing.Point(74, 197);
            this.btnDeck.Name = "btnDeck";
            this.btnDeck.Size = new System.Drawing.Size(75, 23);
            this.btnDeck.TabIndex = 2;
            this.btnDeck.Text = "Deck";
            this.btnDeck.UseVisualStyleBackColor = true;
            this.btnDeck.Click += new System.EventHandler(this.btnDeck_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(548, 33);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(75, 23);
            this.btnFriends.TabIndex = 3;
            this.btnFriends.Text = "Amis";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(683, 33);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Mon compte";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnNotif
            // 
            this.btnNotif.Location = new System.Drawing.Point(410, 33);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(75, 23);
            this.btnNotif.TabIndex = 5;
            this.btnNotif.Text = "Notification";
            this.btnNotif.UseVisualStyleBackColor = true;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click);
            // 
            // labelNickname
            // 
            this.labelNickname.Location = new System.Drawing.Point(74, 38);
            this.labelNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(75, 19);
            this.labelNickname.TabIndex = 6;
            this.labelNickname.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.btnNotif);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnDeck);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnPlay);
            this.Name = "Home";
            this.Text = "Homecs";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelNickname;

        private System.Windows.Forms.Button btnNotif;

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnDeck;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Button btnAccount;
    }
}