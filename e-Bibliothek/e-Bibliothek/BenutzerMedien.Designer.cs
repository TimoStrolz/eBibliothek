namespace e_Bibliothek
{
    partial class BenutzerMedien
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet3 = new e_Bibliothek.Database1DataSet3();
            this.benutzerMedienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benutzerMedienTableAdapter = new e_Bibliothek.Database1DataSet3TableAdapters.BenutzerMedienTableAdapter();
            this.benutzerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gegenstandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerMedienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.benutzerDataGridViewTextBoxColumn,
            this.gegenstandDataGridViewTextBoxColumn,
            this.kategorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.benutzerMedienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benutzerMedienBindingSource
            // 
            this.benutzerMedienBindingSource.DataMember = "BenutzerMedien";
            this.benutzerMedienBindingSource.DataSource = this.database1DataSet3;
            // 
            // benutzerMedienTableAdapter
            // 
            this.benutzerMedienTableAdapter.ClearBeforeFill = true;
            // 
            // benutzerDataGridViewTextBoxColumn
            // 
            this.benutzerDataGridViewTextBoxColumn.DataPropertyName = "Benutzer";
            this.benutzerDataGridViewTextBoxColumn.HeaderText = "Benutzer";
            this.benutzerDataGridViewTextBoxColumn.Name = "benutzerDataGridViewTextBoxColumn";
            // 
            // gegenstandDataGridViewTextBoxColumn
            // 
            this.gegenstandDataGridViewTextBoxColumn.DataPropertyName = "Gegenstand";
            this.gegenstandDataGridViewTextBoxColumn.HeaderText = "Gegenstand";
            this.gegenstandDataGridViewTextBoxColumn.Name = "gegenstandDataGridViewTextBoxColumn";
            // 
            // kategorieDataGridViewTextBoxColumn
            // 
            this.kategorieDataGridViewTextBoxColumn.DataPropertyName = "Kategorie";
            this.kategorieDataGridViewTextBoxColumn.HeaderText = "Kategorie";
            this.kategorieDataGridViewTextBoxColumn.Name = "kategorieDataGridViewTextBoxColumn";
            // 
            // BenutzerMedien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BenutzerMedien";
            this.Text = "BenutzerMedien";
            this.Load += new System.EventHandler(this.BenutzerMedien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benutzerMedienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource benutzerMedienBindingSource;
        private Database1DataSet3TableAdapters.BenutzerMedienTableAdapter benutzerMedienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn benutzerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gegenstandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorieDataGridViewTextBoxColumn;
    }
}