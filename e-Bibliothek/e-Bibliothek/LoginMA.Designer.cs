namespace e_Bibliothek
{
    partial class LoginMA
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
            this.bLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPasswd = new System.Windows.Forms.TextBox();
            this.tBUserN = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(12, 136);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(81, 30);
            this.bLogin.TabIndex = 9;
            this.bLogin.Text = "login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Benutzername";
            // 
            // tBPasswd
            // 
            this.tBPasswd.Location = new System.Drawing.Point(11, 103);
            this.tBPasswd.Name = "tBPasswd";
            this.tBPasswd.PasswordChar = '*';
            this.tBPasswd.Size = new System.Drawing.Size(115, 26);
            this.tBPasswd.TabIndex = 6;
            // 
            // tBUserN
            // 
            this.tBUserN.Location = new System.Drawing.Point(11, 35);
            this.tBUserN.Name = "tBUserN";
            this.tBUserN.Size = new System.Drawing.Size(115, 26);
            this.tBUserN.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 199);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 29);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoginMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 310);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPasswd);
            this.Controls.Add(this.tBUserN);
            this.Name = "LoginMA";
            this.Text = "LoginMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBPasswd;
        private System.Windows.Forms.TextBox tBUserN;
        private System.Windows.Forms.Button btnBack;
    }
}