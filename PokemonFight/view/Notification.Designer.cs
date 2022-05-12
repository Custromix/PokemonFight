using System.ComponentModel;

namespace PokemonFight
{
    partial class Notification
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
            this.panelAllNotif = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAllNotif
            // 
            this.panelAllNotif.Location = new System.Drawing.Point(124, 80);
            this.panelAllNotif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAllNotif.Name = "panelAllNotif";
            this.panelAllNotif.Size = new System.Drawing.Size(556, 338);
            this.panelAllNotif.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(70, 36);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Retour";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panelAllNotif);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Notification";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.Panel panelAllNotif;

        #endregion
    }
}