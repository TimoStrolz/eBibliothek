namespace e_Bibliothek
{
    partial class KatalogForm
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
            this.dVDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new e_Bibliothek.Database1DataSet1();
            this.konsolenspieleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetKSpiele = new e_Bibliothek.Database1DataSetKSpiele();
            this.zeitungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetZeitungen = new e_Bibliothek.Database1DataSetZeitungen();
            this.bücherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBücher = new e_Bibliothek.Database1DataSetBücher();
            this.btnBücher = new System.Windows.Forms.Button();
            this.btnKSpiele = new System.Windows.Forms.Button();
            this.btnZeitungen = new System.Windows.Forms.Button();
            this.btnDVD = new System.Windows.Forms.Button();
            this.bücherTableAdapter = new e_Bibliothek.Database1DataSetBücherTableAdapters.BücherTableAdapter();
            this.zeitungenTableAdapter = new e_Bibliothek.Database1DataSetZeitungenTableAdapters.ZeitungenTableAdapter();
            this.konsolenspieleTableAdapter = new e_Bibliothek.Database1DataSetKSpieleTableAdapters.konsolenspieleTableAdapter();
            this.dVDsTableAdapter = new e_Bibliothek.Database1DataSet1TableAdapters.DVDsTableAdapter();
            this.dataGridViewBücher = new System.Windows.Forms.DataGridView();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seitenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verfügbarkeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewZeitungen = new System.Windows.Forms.DataGridView();
            this.titelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issnnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erscheinungshäufigkeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verfügbarkeitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewKSpiele = new System.Windows.Forms.DataGridView();
            this.titelDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mindestalterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verfügbarkeitDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDVDs = new System.Windows.Forms.DataGridView();
            this.titelDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laufzeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mindestalterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verfügbarkeitDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dVDsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsolenspieleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetKSpiele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeitungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetZeitungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bücherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBücher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBücher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZeitungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKSpiele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDVDs)).BeginInit();
            this.SuspendLayout();
            // 
            // dVDsBindingSource
            // 
            this.dVDsBindingSource.DataMember = "DVDs";
            this.dVDsBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // konsolenspieleBindingSource
            // 
            this.konsolenspieleBindingSource.DataMember = "konsolenspiele";
            this.konsolenspieleBindingSource.DataSource = this.database1DataSetKSpiele;
            // 
            // database1DataSetKSpiele
            // 
            this.database1DataSetKSpiele.DataSetName = "Database1DataSetKSpiele";
            this.database1DataSetKSpiele.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zeitungenBindingSource
            // 
            this.zeitungenBindingSource.DataMember = "Zeitungen";
            this.zeitungenBindingSource.DataSource = this.database1DataSetZeitungen;
            // 
            // database1DataSetZeitungen
            // 
            this.database1DataSetZeitungen.DataSetName = "Database1DataSetZeitungen";
            this.database1DataSetZeitungen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bücherBindingSource
            // 
            this.bücherBindingSource.DataMember = "Bücher";
            this.bücherBindingSource.DataSource = this.database1DataSetBücher;
            // 
            // database1DataSetBücher
            // 
            this.database1DataSetBücher.DataSetName = "Database1DataSetBücher";
            this.database1DataSetBücher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBücher
            // 
            this.btnBücher.Location = new System.Drawing.Point(929, 3);
            this.btnBücher.Name = "btnBücher";
            this.btnBücher.Size = new System.Drawing.Size(152, 34);
            this.btnBücher.TabIndex = 1;
            this.btnBücher.Text = "Bücher ansehen";
            this.btnBücher.UseVisualStyleBackColor = true;
            this.btnBücher.Click += new System.EventHandler(this.btnBücher_Click);
            // 
            // btnKSpiele
            // 
            this.btnKSpiele.Location = new System.Drawing.Point(929, 96);
            this.btnKSpiele.Name = "btnKSpiele";
            this.btnKSpiele.Size = new System.Drawing.Size(152, 51);
            this.btnKSpiele.TabIndex = 2;
            this.btnKSpiele.Text = "Konsolenspiele ansehen";
            this.btnKSpiele.UseVisualStyleBackColor = true;
            this.btnKSpiele.Click += new System.EventHandler(this.btnKSpiele_Click);
            // 
            // btnZeitungen
            // 
            this.btnZeitungen.Location = new System.Drawing.Point(929, 43);
            this.btnZeitungen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnZeitungen.Name = "btnZeitungen";
            this.btnZeitungen.Size = new System.Drawing.Size(152, 50);
            this.btnZeitungen.TabIndex = 3;
            this.btnZeitungen.Text = "Zeitungen ansehen";
            this.btnZeitungen.UseVisualStyleBackColor = true;
            this.btnZeitungen.Click += new System.EventHandler(this.btnZeitungen_Click);
            // 
            // btnDVD
            // 
            this.btnDVD.Location = new System.Drawing.Point(929, 153);
            this.btnDVD.Name = "btnDVD";
            this.btnDVD.Size = new System.Drawing.Size(152, 32);
            this.btnDVD.TabIndex = 4;
            this.btnDVD.Text = "DVDs ansehen";
            this.btnDVD.UseVisualStyleBackColor = true;
            this.btnDVD.Click += new System.EventHandler(this.btnDVD_Click);
            // 
            // bücherTableAdapter
            // 
            this.bücherTableAdapter.ClearBeforeFill = true;
            // 
            // zeitungenTableAdapter
            // 
            this.zeitungenTableAdapter.ClearBeforeFill = true;
            // 
            // konsolenspieleTableAdapter
            // 
            this.konsolenspieleTableAdapter.ClearBeforeFill = true;
            // 
            // dVDsTableAdapter
            // 
            this.dVDsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBücher
            // 
            this.dataGridViewBücher.AutoGenerateColumns = false;
            this.dataGridViewBücher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBücher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autorDataGridViewTextBoxColumn,
            this.titelDataGridViewTextBoxColumn,
            this.isbnnummerDataGridViewTextBoxColumn,
            this.artDataGridViewTextBoxColumn,
            this.seitenDataGridViewTextBoxColumn,
            this.verfügbarkeitDataGridViewTextBoxColumn});
            this.dataGridViewBücher.DataSource = this.bücherBindingSource;
            this.dataGridViewBücher.Location = new System.Drawing.Point(1, -6);
            this.dataGridViewBücher.Name = "dataGridViewBücher";
            this.dataGridViewBücher.ReadOnly = true;
            this.dataGridViewBücher.RowTemplate.Height = 28;
            this.dataGridViewBücher.Size = new System.Drawing.Size(910, 639);
            this.dataGridViewBücher.TabIndex = 5;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "titel";
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            this.titelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnnummerDataGridViewTextBoxColumn
            // 
            this.isbnnummerDataGridViewTextBoxColumn.DataPropertyName = "isbnnummer";
            this.isbnnummerDataGridViewTextBoxColumn.HeaderText = "isbnnummer";
            this.isbnnummerDataGridViewTextBoxColumn.Name = "isbnnummerDataGridViewTextBoxColumn";
            this.isbnnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artDataGridViewTextBoxColumn
            // 
            this.artDataGridViewTextBoxColumn.DataPropertyName = "art";
            this.artDataGridViewTextBoxColumn.HeaderText = "art";
            this.artDataGridViewTextBoxColumn.Name = "artDataGridViewTextBoxColumn";
            this.artDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seitenDataGridViewTextBoxColumn
            // 
            this.seitenDataGridViewTextBoxColumn.DataPropertyName = "seiten";
            this.seitenDataGridViewTextBoxColumn.HeaderText = "seiten";
            this.seitenDataGridViewTextBoxColumn.Name = "seitenDataGridViewTextBoxColumn";
            this.seitenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verfügbarkeitDataGridViewTextBoxColumn
            // 
            this.verfügbarkeitDataGridViewTextBoxColumn.DataPropertyName = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn.HeaderText = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn.Name = "verfügbarkeitDataGridViewTextBoxColumn";
            this.verfügbarkeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewZeitungen
            // 
            this.dataGridViewZeitungen.AutoGenerateColumns = false;
            this.dataGridViewZeitungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZeitungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titelDataGridViewTextBoxColumn1,
            this.verlagDataGridViewTextBoxColumn,
            this.issnnummerDataGridViewTextBoxColumn,
            this.artDataGridViewTextBoxColumn1,
            this.erscheinungshäufigkeitDataGridViewTextBoxColumn,
            this.verfügbarkeitDataGridViewTextBoxColumn1});
            this.dataGridViewZeitungen.DataSource = this.zeitungenBindingSource;
            this.dataGridViewZeitungen.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewZeitungen.Name = "dataGridViewZeitungen";
            this.dataGridViewZeitungen.ReadOnly = true;
            this.dataGridViewZeitungen.RowTemplate.Height = 28;
            this.dataGridViewZeitungen.Size = new System.Drawing.Size(910, 639);
            this.dataGridViewZeitungen.TabIndex = 6;
            // 
            // titelDataGridViewTextBoxColumn1
            // 
            this.titelDataGridViewTextBoxColumn1.DataPropertyName = "titel";
            this.titelDataGridViewTextBoxColumn1.HeaderText = "titel";
            this.titelDataGridViewTextBoxColumn1.Name = "titelDataGridViewTextBoxColumn1";
            this.titelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // verlagDataGridViewTextBoxColumn
            // 
            this.verlagDataGridViewTextBoxColumn.DataPropertyName = "verlag";
            this.verlagDataGridViewTextBoxColumn.HeaderText = "verlag";
            this.verlagDataGridViewTextBoxColumn.Name = "verlagDataGridViewTextBoxColumn";
            this.verlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issnnummerDataGridViewTextBoxColumn
            // 
            this.issnnummerDataGridViewTextBoxColumn.DataPropertyName = " issn-nummer";
            this.issnnummerDataGridViewTextBoxColumn.HeaderText = " issn-nummer";
            this.issnnummerDataGridViewTextBoxColumn.Name = "issnnummerDataGridViewTextBoxColumn";
            this.issnnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artDataGridViewTextBoxColumn1
            // 
            this.artDataGridViewTextBoxColumn1.DataPropertyName = "art";
            this.artDataGridViewTextBoxColumn1.HeaderText = "art";
            this.artDataGridViewTextBoxColumn1.Name = "artDataGridViewTextBoxColumn1";
            this.artDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // erscheinungshäufigkeitDataGridViewTextBoxColumn
            // 
            this.erscheinungshäufigkeitDataGridViewTextBoxColumn.DataPropertyName = "erscheinungshäufigkeit";
            this.erscheinungshäufigkeitDataGridViewTextBoxColumn.HeaderText = "erscheinungshäufigkeit";
            this.erscheinungshäufigkeitDataGridViewTextBoxColumn.Name = "erscheinungshäufigkeitDataGridViewTextBoxColumn";
            this.erscheinungshäufigkeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verfügbarkeitDataGridViewTextBoxColumn1
            // 
            this.verfügbarkeitDataGridViewTextBoxColumn1.DataPropertyName = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn1.HeaderText = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn1.Name = "verfügbarkeitDataGridViewTextBoxColumn1";
            this.verfügbarkeitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewKSpiele
            // 
            this.dataGridViewKSpiele.AutoGenerateColumns = false;
            this.dataGridViewKSpiele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKSpiele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titelDataGridViewTextBoxColumn2,
            this.systemDataGridViewTextBoxColumn,
            this.mindestalterDataGridViewTextBoxColumn,
            this.verfügbarkeitDataGridViewTextBoxColumn2});
            this.dataGridViewKSpiele.DataSource = this.konsolenspieleBindingSource;
            this.dataGridViewKSpiele.Location = new System.Drawing.Point(1, 3);
            this.dataGridViewKSpiele.Name = "dataGridViewKSpiele";
            this.dataGridViewKSpiele.ReadOnly = true;
            this.dataGridViewKSpiele.RowTemplate.Height = 28;
            this.dataGridViewKSpiele.Size = new System.Drawing.Size(911, 639);
            this.dataGridViewKSpiele.TabIndex = 7;
            this.dataGridViewKSpiele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKSpiele_CellContentClick);
            // 
            // titelDataGridViewTextBoxColumn2
            // 
            this.titelDataGridViewTextBoxColumn2.DataPropertyName = "titel";
            this.titelDataGridViewTextBoxColumn2.HeaderText = "titel";
            this.titelDataGridViewTextBoxColumn2.Name = "titelDataGridViewTextBoxColumn2";
            this.titelDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // systemDataGridViewTextBoxColumn
            // 
            this.systemDataGridViewTextBoxColumn.DataPropertyName = "system";
            this.systemDataGridViewTextBoxColumn.HeaderText = "system";
            this.systemDataGridViewTextBoxColumn.Name = "systemDataGridViewTextBoxColumn";
            this.systemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mindestalterDataGridViewTextBoxColumn
            // 
            this.mindestalterDataGridViewTextBoxColumn.DataPropertyName = "mindestalter";
            this.mindestalterDataGridViewTextBoxColumn.HeaderText = "mindestalter";
            this.mindestalterDataGridViewTextBoxColumn.Name = "mindestalterDataGridViewTextBoxColumn";
            this.mindestalterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verfügbarkeitDataGridViewTextBoxColumn2
            // 
            this.verfügbarkeitDataGridViewTextBoxColumn2.DataPropertyName = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn2.HeaderText = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn2.Name = "verfügbarkeitDataGridViewTextBoxColumn2";
            this.verfügbarkeitDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewDVDs
            // 
            this.dataGridViewDVDs.AllowUserToAddRows = false;
            this.dataGridViewDVDs.AllowUserToDeleteRows = false;
            this.dataGridViewDVDs.AutoGenerateColumns = false;
            this.dataGridViewDVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDVDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titelDataGridViewTextBoxColumn3,
            this.artDataGridViewTextBoxColumn2,
            this.laufzeitDataGridViewTextBoxColumn,
            this.mindestalterDataGridViewTextBoxColumn1,
            this.verfügbarkeitDataGridViewTextBoxColumn3});
            this.dataGridViewDVDs.DataSource = this.dVDsBindingSource;
            this.dataGridViewDVDs.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewDVDs.Name = "dataGridViewDVDs";
            this.dataGridViewDVDs.ReadOnly = true;
            this.dataGridViewDVDs.RowTemplate.Height = 28;
            this.dataGridViewDVDs.Size = new System.Drawing.Size(910, 639);
            this.dataGridViewDVDs.TabIndex = 8;
            this.dataGridViewDVDs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDVDs_CellContentClick);
            // 
            // titelDataGridViewTextBoxColumn3
            // 
            this.titelDataGridViewTextBoxColumn3.DataPropertyName = "titel";
            this.titelDataGridViewTextBoxColumn3.HeaderText = "titel";
            this.titelDataGridViewTextBoxColumn3.Name = "titelDataGridViewTextBoxColumn3";
            this.titelDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // artDataGridViewTextBoxColumn2
            // 
            this.artDataGridViewTextBoxColumn2.DataPropertyName = "art";
            this.artDataGridViewTextBoxColumn2.HeaderText = "art";
            this.artDataGridViewTextBoxColumn2.Name = "artDataGridViewTextBoxColumn2";
            this.artDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // laufzeitDataGridViewTextBoxColumn
            // 
            this.laufzeitDataGridViewTextBoxColumn.DataPropertyName = "laufzeit";
            this.laufzeitDataGridViewTextBoxColumn.HeaderText = "laufzeit";
            this.laufzeitDataGridViewTextBoxColumn.Name = "laufzeitDataGridViewTextBoxColumn";
            this.laufzeitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mindestalterDataGridViewTextBoxColumn1
            // 
            this.mindestalterDataGridViewTextBoxColumn1.DataPropertyName = "mindestalter";
            this.mindestalterDataGridViewTextBoxColumn1.HeaderText = "mindestalter";
            this.mindestalterDataGridViewTextBoxColumn1.Name = "mindestalterDataGridViewTextBoxColumn1";
            this.mindestalterDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // verfügbarkeitDataGridViewTextBoxColumn3
            // 
            this.verfügbarkeitDataGridViewTextBoxColumn3.DataPropertyName = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn3.HeaderText = "verfügbarkeit";
            this.verfügbarkeitDataGridViewTextBoxColumn3.Name = "verfügbarkeitDataGridViewTextBoxColumn3";
            this.verfügbarkeitDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(929, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 33);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // KatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 663);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewDVDs);
            this.Controls.Add(this.dataGridViewKSpiele);
            this.Controls.Add(this.dataGridViewZeitungen);
            this.Controls.Add(this.dataGridViewBücher);
            this.Controls.Add(this.btnZeitungen);
            this.Controls.Add(this.btnDVD);
            this.Controls.Add(this.btnKSpiele);
            this.Controls.Add(this.btnBücher);
            this.Name = "KatalogForm";
            this.Text = "Katalog";
            this.Load += new System.EventHandler(this.Katalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVDsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konsolenspieleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetKSpiele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zeitungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetZeitungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bücherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBücher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBücher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZeitungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKSpiele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDVDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBücher;
        private System.Windows.Forms.Button btnKSpiele;
        private System.Windows.Forms.Button btnZeitungen;
        private System.Windows.Forms.Button btnDVD;
        private Database1DataSetBücher database1DataSetBücher;
        private System.Windows.Forms.BindingSource bücherBindingSource;
        private Database1DataSetBücherTableAdapters.BücherTableAdapter bücherTableAdapter;
        private Database1DataSetZeitungen database1DataSetZeitungen;
        private System.Windows.Forms.BindingSource zeitungenBindingSource;
        private Database1DataSetZeitungenTableAdapters.ZeitungenTableAdapter zeitungenTableAdapter;
        private Database1DataSetKSpiele database1DataSetKSpiele;
        private System.Windows.Forms.BindingSource konsolenspieleBindingSource;
        private Database1DataSetKSpieleTableAdapters.konsolenspieleTableAdapter konsolenspieleTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource dVDsBindingSource;
        private Database1DataSet1TableAdapters.DVDsTableAdapter dVDsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewBücher;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seitenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verfügbarkeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewZeitungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn verlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issnnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn erscheinungshäufigkeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verfügbarkeitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewKSpiele;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mindestalterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verfügbarkeitDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridViewDVDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn laufzeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mindestalterDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn verfügbarkeitDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnBack;
    }
}