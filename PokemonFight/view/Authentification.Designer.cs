
namespace PokemonFight
{
    partial class Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelIdLogin;
            System.Windows.Forms.Label label2;
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelPasswordLogin = new System.Windows.Forms.Label();
            this.btnLoginConnect = new System.Windows.Forms.Button();
            this.inputPasswordLogin = new System.Windows.Forms.TextBox();
            this.inputIdLogin = new System.Windows.Forms.TextBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMailRegister = new System.Windows.Forms.TextBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.inputFirstnameRegister = new System.Windows.Forms.TextBox();
            this.labelNameRegister = new System.Windows.Forms.Label();
            this.inputNameRegister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.inputPasswordRegister = new System.Windows.Forms.TextBox();
            this.inputNicknameRegister = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.autoConnect = new System.Windows.Forms.Button();
            this.labelSponsorship = new System.Windows.Forms.Label();
            this.inputSponsor = new System.Windows.Forms.TextBox();
            labelIdLogin = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIdLogin
            // 
            labelIdLogin.AutoSize = true;
            labelIdLogin.Location = new System.Drawing.Point(44, 41);
            labelIdLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelIdLogin.Name = "labelIdLogin";
            labelIdLogin.Size = new System.Drawing.Size(64, 16);
            labelIdLogin.TabIndex = 2;
            labelIdLogin.Text = "Identifiant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 214);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 16);
            label2.TabIndex = 2;
            label2.Text = "Identifiant";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelPasswordLogin);
            this.panelLogin.Controls.Add(this.btnLoginConnect);
            this.panelLogin.Controls.Add(labelIdLogin);
            this.panelLogin.Controls.Add(this.inputPasswordLogin);
            this.panelLogin.Controls.Add(this.inputIdLogin);
            this.panelLogin.Location = new System.Drawing.Point(329, 151);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(329, 197);
            this.panelLogin.TabIndex = 0;
            // 
            // labelPasswordLogin
            // 
            this.labelPasswordLogin.AutoSize = true;
            this.labelPasswordLogin.Location = new System.Drawing.Point(44, 102);
            this.labelPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswordLogin.Name = "labelPasswordLogin";
            this.labelPasswordLogin.Size = new System.Drawing.Size(68, 16);
            this.labelPasswordLogin.TabIndex = 4;
            this.labelPasswordLogin.Text = "Password";
            // 
            // btnLoginConnect
            // 
            this.btnLoginConnect.Location = new System.Drawing.Point(136, 154);
            this.btnLoginConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginConnect.Name = "btnLoginConnect";
            this.btnLoginConnect.Size = new System.Drawing.Size(137, 28);
            this.btnLoginConnect.TabIndex = 3;
            this.btnLoginConnect.Text = "Se connecter";
            this.btnLoginConnect.UseVisualStyleBackColor = true;
            this.btnLoginConnect.Click += new System.EventHandler(this.btnLoginConnect_Click);
            // 
            // inputPasswordLogin
            // 
            this.inputPasswordLogin.Location = new System.Drawing.Point(140, 98);
            this.inputPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.inputPasswordLogin.Name = "inputPasswordLogin";
            this.inputPasswordLogin.Size = new System.Drawing.Size(132, 22);
            this.inputPasswordLogin.TabIndex = 1;
            // 
            // inputIdLogin
            // 
            this.inputIdLogin.Location = new System.Drawing.Point(140, 37);
            this.inputIdLogin.Margin = new System.Windows.Forms.Padding(4);
            this.inputIdLogin.Name = "inputIdLogin";
            this.inputIdLogin.Size = new System.Drawing.Size(132, 22);
            this.inputIdLogin.TabIndex = 0;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.inputSponsor);
            this.panelRegister.Controls.Add(this.labelSponsorship);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.inputMailRegister);
            this.panelRegister.Controls.Add(this.labelFirstname);
            this.panelRegister.Controls.Add(this.inputFirstnameRegister);
            this.panelRegister.Controls.Add(this.labelNameRegister);
            this.panelRegister.Controls.Add(this.inputNameRegister);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(label2);
            this.panelRegister.Controls.Add(this.inputPasswordRegister);
            this.panelRegister.Controls.Add(this.inputNicknameRegister);
            this.panelRegister.Location = new System.Drawing.Point(329, 151);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(496, 393);
            this.panelRegister.TabIndex = 6;
            this.panelRegister.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mail";
            // 
            // inputMailRegister
            // 
            this.inputMailRegister.Location = new System.Drawing.Point(140, 160);
            this.inputMailRegister.Margin = new System.Windows.Forms.Padding(4);
            this.inputMailRegister.Name = "inputMailRegister";
            this.inputMailRegister.Size = new System.Drawing.Size(132, 22);
            this.inputMailRegister.TabIndex = 10;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Location = new System.Drawing.Point(44, 113);
            this.labelFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(55, 16);
            this.labelFirstname.TabIndex = 9;
            this.labelFirstname.Text = "Prenom";
            // 
            // inputFirstnameRegister
            // 
            this.inputFirstnameRegister.Location = new System.Drawing.Point(140, 110);
            this.inputFirstnameRegister.Margin = new System.Windows.Forms.Padding(4);
            this.inputFirstnameRegister.Name = "inputFirstnameRegister";
            this.inputFirstnameRegister.Size = new System.Drawing.Size(132, 22);
            this.inputFirstnameRegister.TabIndex = 8;
            // 
            // labelNameRegister
            // 
            this.labelNameRegister.AutoSize = true;
            this.labelNameRegister.Location = new System.Drawing.Point(44, 58);
            this.labelNameRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameRegister.Name = "labelNameRegister";
            this.labelNameRegister.Size = new System.Drawing.Size(45, 16);
            this.labelNameRegister.TabIndex = 7;
            this.labelNameRegister.Text = "Name";
            // 
            // inputNameRegister
            // 
            this.inputNameRegister.Location = new System.Drawing.Point(140, 58);
            this.inputNameRegister.Margin = new System.Windows.Forms.Padding(4);
            this.inputNameRegister.Name = "inputNameRegister";
            this.inputNameRegister.Size = new System.Drawing.Size(132, 22);
            this.inputNameRegister.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(136, 300);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(137, 28);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "S\'enregistrer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // inputPasswordRegister
            // 
            this.inputPasswordRegister.Location = new System.Drawing.Point(140, 254);
            this.inputPasswordRegister.Margin = new System.Windows.Forms.Padding(4);
            this.inputPasswordRegister.Name = "inputPasswordRegister";
            this.inputPasswordRegister.Size = new System.Drawing.Size(132, 22);
            this.inputPasswordRegister.TabIndex = 1;
            // 
            // inputNicknameRegister
            // 
            this.inputNicknameRegister.Location = new System.Drawing.Point(140, 210);
            this.inputNicknameRegister.Margin = new System.Windows.Forms.Padding(4);
            this.inputNicknameRegister.Name = "inputNicknameRegister";
            this.inputNicknameRegister.Size = new System.Drawing.Size(132, 22);
            this.inputNicknameRegister.TabIndex = 0;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(852, 305);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(160, 28);
            this.btnSwitch.TabIndex = 5;
            this.btnSwitch.Text = "Créer un compte";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // autoConnect
            // 
            this.autoConnect.Location = new System.Drawing.Point(133, 74);
            this.autoConnect.Name = "autoConnect";
            this.autoConnect.Size = new System.Drawing.Size(141, 35);
            this.autoConnect.TabIndex = 7;
            this.autoConnect.Text = "guestConnection";
            this.autoConnect.UseVisualStyleBackColor = true;
            this.autoConnect.Click += new System.EventHandler(this.autoConnect_Click);
            // 
            // labelSponsorship
            // 
            this.labelSponsorship.Location = new System.Drawing.Point(336, 130);
            this.labelSponsorship.Name = "labelSponsorship";
            this.labelSponsorship.Size = new System.Drawing.Size(131, 23);
            this.labelSponsorship.TabIndex = 12;
            this.labelSponsorship.Text = "Code de parainage";
            // 
            // inputSponsor
            // 
            this.inputSponsor.Location = new System.Drawing.Point(336, 166);
            this.inputSponsor.Name = "inputSponsor";
            this.inputSponsor.Size = new System.Drawing.Size(131, 22);
            this.inputSponsor.TabIndex = 13;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 554);
            this.Controls.Add(this.autoConnect);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authentification";
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox inputSponsor;

        private System.Windows.Forms.Label labelSponsorship;

        private System.Windows.Forms.Button autoConnect;

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPasswordLogin;
        private System.Windows.Forms.Button btnLoginConnect;
        private System.Windows.Forms.TextBox inputPasswordLogin;
        private System.Windows.Forms.TextBox inputIdLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox inputPasswordRegister;
        private System.Windows.Forms.TextBox inputNicknameRegister;
        private System.Windows.Forms.Label labelNameRegister;
        private System.Windows.Forms.TextBox inputNameRegister;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.TextBox inputFirstnameRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputMailRegister;
    }
}

