namespace e_Bibliothek
{
    partial class LobbyForm
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
            this.btnReservieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKatalog
            // 
            this.btnKatalog.Location = new System.Drawing.Point(12, 12);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(173, 34);
            this.btnKatalog.TabIndex = 0;
            this.btnKatalog.Text = "Katalog ansehen";
            this.btnKatalog.UseVisualStyleBackColor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnReservieren
            // 
            this.btnReservieren.Location = new System.Drawing.Point(12, 53);
            this.btnReservieren.Name = "btnReservieren";
            this.btnReservieren.Size = new System.Drawing.Size(173, 53);
            this.btnReservieren.TabIndex = 1;
            this.btnReservieren.Text = "Gegenstand reservieren";
            this.btnReservieren.UseVisualStyleBackColor = true;
            this.btnReservieren.Click += new System.EventHandler(this.btnReservieren_Click);
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservieren);
            this.Controls.Add(this.btnKatalog);
            this.Name = "LobbyForm";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Button btnReservieren;
    }
}