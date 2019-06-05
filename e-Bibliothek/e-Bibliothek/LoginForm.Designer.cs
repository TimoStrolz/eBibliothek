namespace e_Bibliothek
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBUserN = new System.Windows.Forms.TextBox();
            this.tBPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.bRegistrieren = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBUserN
            // 
            this.tBUserN.Location = new System.Drawing.Point(12, 30);
            this.tBUserN.Name = "tBUserN";
            this.tBUserN.Size = new System.Drawing.Size(115, 26);
            this.tBUserN.TabIndex = 0;
            // 
            // tBPasswd
            // 
            this.tBPasswd.Location = new System.Drawing.Point(12, 98);
            this.tBPasswd.Name = "tBPasswd";
            this.tBPasswd.PasswordChar = '*';
            this.tBPasswd.Size = new System.Drawing.Size(115, 26);
            this.tBPasswd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(13, 131);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(81, 30);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bRegistrieren
            // 
            this.bRegistrieren.Location = new System.Drawing.Point(146, 25);
            this.bRegistrieren.Name = "bRegistrieren";
            this.bRegistrieren.Size = new System.Drawing.Size(145, 31);
            this.bRegistrieren.TabIndex = 5;
            this.bRegistrieren.Text = "Neu registrieren";
            this.bRegistrieren.UseVisualStyleBackColor = true;
            this.bRegistrieren.Click += new System.EventHandler(this.bRegistrieren_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(146, 63);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(145, 32);
            this.btnKatalog.TabIndex = 6;
            this.btnKatalog.Text = "Katalog ansehen";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Location = new System.Drawing.Point(146, 102);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(145, 52);
            this.btnMitarbeiter.TabIndex = 7;
            this.btnMitarbeiter.Text = "als Mitarbeiter anmelden";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            this.btnMitarbeiter.Click += new System.EventHandler(this.btnMitarbeiter_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 180);
            this.Controls.Add(this.btnMitarbeiter);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.bRegistrieren);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPasswd);
            this.Controls.Add(this.tBUserN);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBPasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bRegistrieren;
        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Button btnMitarbeiter;
        public System.Windows.Forms.TextBox tBUserN;
    }
}

