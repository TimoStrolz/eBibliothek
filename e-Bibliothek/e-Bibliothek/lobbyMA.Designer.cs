namespace e_Bibliothek
{
    partial class lobbyMA
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
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnVerfügbarkeit = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(13, 13);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(183, 45);
            this.btnKatalog.TabIndex = 0;
            this.btnKatalog.Text = "Katalog ansehen";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(13, 122);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(184, 43);
            this.btnHinzufügen.TabIndex = 1;
            this.btnHinzufügen.Text = "Medien hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnVerfügbarkeit
            // 
            this.btnVerfügbarkeit.Location = new System.Drawing.Point(13, 64);
            this.btnVerfügbarkeit.Name = "btnVerfügbarkeit";
            this.btnVerfügbarkeit.Size = new System.Drawing.Size(184, 52);
            this.btnVerfügbarkeit.TabIndex = 3;
            this.btnVerfügbarkeit.Text = "Verfügbarkeit für Gegenstand anpassen";
            this.btnVerfügbarkeit.UseVisualStyleBackColor = true;
            this.btnVerfügbarkeit.Click += new System.EventHandler(this.btnVerfügbarkeit_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(13, 172);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(183, 49);
            this.btnBD.TabIndex = 4;
            this.btnBD.Text = "Benutzerdaten ansehen";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // lobbyMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnVerfügbarkeit);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnKatalog);
            this.Name = "lobbyMA";
            this.Text = "lobbyMA";
            this.Load += new System.EventHandler(this.lobbyMA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnVerfügbarkeit;
        private System.Windows.Forms.Button btnBD;
    }
}