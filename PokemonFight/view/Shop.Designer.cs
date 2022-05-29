using System.ComponentModel;

namespace PokemonFight
{
    partial class Shop
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
            this.btnBuyCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuyCard
            // 
            this.btnBuyCard.Location = new System.Drawing.Point(321, 309);
            this.btnBuyCard.Name = "btnBuyCard";
            this.btnBuyCard.Size = new System.Drawing.Size(149, 25);
            this.btnBuyCard.TabIndex = 0;
            this.btnBuyCard.Text = "Obtenir le pack";
            this.btnBuyCard.UseVisualStyleBackColor = true;
            this.btnBuyCard.Click += new System.EventHandler(this.btnBuyCard_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuyCard);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBuyCard;

        #endregion
    }
}