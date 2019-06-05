namespace e_Bibliothek
{
    partial class VerfügbarkeitsForm
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
            this.comboBoxVerfügbarkeit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxCgy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxVerfügbarkeit
            // 
            this.comboBoxVerfügbarkeit.FormattingEnabled = true;
            this.comboBoxVerfügbarkeit.Items.AddRange(new object[] {
            "reserviert",
            "ausgeliehen",
            "zurückgebracht",
            "verfügbar (Reservation storniert)"});
            this.comboBoxVerfügbarkeit.Location = new System.Drawing.Point(8, 168);
            this.comboBoxVerfügbarkeit.Name = "comboBoxVerfügbarkeit";
            this.comboBoxVerfügbarkeit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxVerfügbarkeit.TabIndex = 1;
            this.comboBoxVerfügbarkeit.SelectedIndexChanged += new System.EventHandler(this.comboBoxVerfügbarkeit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bei dem Gegenstand handelt es sich um ein(e):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Der Gegenstand wird:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Änderungen übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 318);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name des Gegenstands:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            // 
            // comboBoxCgy
            // 
            this.comboBoxCgy.FormattingEnabled = true;
            this.comboBoxCgy.Items.AddRange(new object[] {
            "Buch",
            "Konsolenspiel",
            "DVD",
            "Zeitung"});
            this.comboBoxCgy.Location = new System.Drawing.Point(16, 37);
            this.comboBoxCgy.Name = "comboBoxCgy";
            this.comboBoxCgy.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCgy.TabIndex = 8;
            this.comboBoxCgy.SelectedIndexChanged += new System.EventHandler(this.comboBoxCgy_SelectedIndexChanged);
            // 
            // VerfügbarkeitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCgy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVerfügbarkeit);
            this.Name = "VerfügbarkeitsForm";
            this.Text = "VerfügbarkeitsForm";
            this.Load += new System.EventHandler(this.VerfügbarkeitsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVerfügbarkeit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxCgy;
    }
}