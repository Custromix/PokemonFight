using System.ComponentModel;

namespace PokemonFight
{
    partial class DeckView
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
            this.btnAddDeck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDeck
            // 
            this.btnAddDeck.Location = new System.Drawing.Point(29, 28);
            this.btnAddDeck.Name = "btnAddDeck";
            this.btnAddDeck.Size = new System.Drawing.Size(79, 48);
            this.btnAddDeck.TabIndex = 0;
            this.btnAddDeck.Text = "Ajouter un deck";
            this.btnAddDeck.UseVisualStyleBackColor = true;
            this.btnAddDeck.Click += new System.EventHandler(this.btnAddDeck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DeckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddDeck);
            this.Name = "DeckView";
            this.Text = "DeckView";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAddDeck;

        #endregion

        private System.Windows.Forms.Button button1;
    }
}