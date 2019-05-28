namespace e_Bibliothek
{
    partial class Registration
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
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBPasswort1 = new System.Windows.Forms.TextBox();
            this.tBPasswort2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bWeiter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tBEmail
            // 
            this.tBEmail.Location = new System.Drawing.Point(12, 38);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(100, 26);
            this.tBEmail.TabIndex = 6;
            this.tBEmail.TextChanged += new System.EventHandler(this.tBEmail_TextChanged);
            // 
            // tBPasswort1
            // 
            this.tBPasswort1.Location = new System.Drawing.Point(12, 117);
            this.tBPasswort1.Name = "tBPasswort1";
            this.tBPasswort1.PasswordChar = '*';
            this.tBPasswort1.Size = new System.Drawing.Size(100, 26);
            this.tBPasswort1.TabIndex = 1;
            // 
            // tBPasswort2
            // 
            this.tBPasswort2.Location = new System.Drawing.Point(12, 194);
            this.tBPasswort2.Name = "tBPasswort2";
            this.tBPasswort2.PasswordChar = '*';
            this.tBPasswort2.Size = new System.Drawing.Size(100, 26);
            this.tBPasswort2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email-Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwort bestätigen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort eingeben";
            // 
            // bWeiter
            // 
            this.bWeiter.Location = new System.Drawing.Point(12, 251);
            this.bWeiter.Name = "bWeiter";
            this.bWeiter.Size = new System.Drawing.Size(75, 38);
            this.bWeiter.TabIndex = 7;
            this.bWeiter.Text = "weiter";
            this.bWeiter.UseVisualStyleBackColor = true;
            this.bWeiter.Click += new System.EventHandler(this.bWeiter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresse";
            // 
            // tBAdresse
            // 
            this.tBAdresse.Location = new System.Drawing.Point(222, 117);
            this.tBAdresse.Name = "tBAdresse";
            this.tBAdresse.Size = new System.Drawing.Size(200, 26);
            this.tBAdresse.TabIndex = 8;
            this.tBAdresse.TextChanged += new System.EventHandler(this.tBAdresse_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Geburtsdatum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 342);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBAdresse);
            this.Controls.Add(this.bWeiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPasswort2);
            this.Controls.Add(this.tBPasswort1);
            this.Controls.Add(this.tBEmail);
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBPasswort1;
        private System.Windows.Forms.TextBox tBPasswort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bWeiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}