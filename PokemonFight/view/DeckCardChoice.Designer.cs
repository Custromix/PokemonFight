using System.ComponentModel;

namespace PokemonFight
{
    partial class DeckCardChoice
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
            this.labelNameDeck = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameDeck
            // 
            this.labelNameDeck.Location = new System.Drawing.Point(31, 28);
            this.labelNameDeck.Name = "labelNameDeck";
            this.labelNameDeck.Size = new System.Drawing.Size(100, 23);
            this.labelNameDeck.TabIndex = 0;
            this.labelNameDeck.Text = "Deck n°";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DeckCardChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelNameDeck);
            this.Name = "DeckCardChoice";
            this.Text = "DeckCardChoice";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label labelNameDeck;

        #endregion
    }
}