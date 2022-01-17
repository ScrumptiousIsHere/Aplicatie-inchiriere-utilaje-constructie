namespace InchiriereUtilaje
{
    partial class FInchirieri
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idInchiriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSocietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrInchiriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inchirieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new InchiriereUtilaje.DataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInchiriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtilajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrZileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inchirieriContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInchiriere = new System.Windows.Forms.Button();
            this.btnModificaInchiriere = new System.Windows.Forms.Button();
            this.btnStergeInchiriere = new System.Windows.Forms.Button();
            this.txtIdInchiriere = new System.Windows.Forms.TextBox();
            this.inchirieriTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.InchirieriTableAdapter();
            this.inchirieriContinutTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.InchirieriContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInchiriereDataGridViewTextBoxColumn,
            this.dataImprumutDataGridViewTextBoxColumn,
            this.idSocietateDataGridViewTextBoxColumn,
            this.nrInchiriereDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inchirieriBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(447, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // idInchiriereDataGridViewTextBoxColumn
            // 
            this.idInchiriereDataGridViewTextBoxColumn.DataPropertyName = "IdInchiriere";
            this.idInchiriereDataGridViewTextBoxColumn.HeaderText = "IdInchiriere";
            this.idInchiriereDataGridViewTextBoxColumn.Name = "idInchiriereDataGridViewTextBoxColumn";
            this.idInchiriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataImprumutDataGridViewTextBoxColumn
            // 
            this.dataImprumutDataGridViewTextBoxColumn.DataPropertyName = "DataImprumut";
            this.dataImprumutDataGridViewTextBoxColumn.HeaderText = "DataImprumut";
            this.dataImprumutDataGridViewTextBoxColumn.Name = "dataImprumutDataGridViewTextBoxColumn";
            this.dataImprumutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSocietateDataGridViewTextBoxColumn
            // 
            this.idSocietateDataGridViewTextBoxColumn.DataPropertyName = "DenumireSocietate";
            this.idSocietateDataGridViewTextBoxColumn.HeaderText = "DenumireSocietate";
            this.idSocietateDataGridViewTextBoxColumn.Name = "idSocietateDataGridViewTextBoxColumn";
            this.idSocietateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrInchiriereDataGridViewTextBoxColumn
            // 
            this.nrInchiriereDataGridViewTextBoxColumn.DataPropertyName = "NrInchiriere";
            this.nrInchiriereDataGridViewTextBoxColumn.HeaderText = "NrInchiriere";
            this.nrInchiriereDataGridViewTextBoxColumn.Name = "nrInchiriereDataGridViewTextBoxColumn";
            this.nrInchiriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inchirieriBindingSource
            // 
            this.inchirieriBindingSource.DataMember = "Inchirieri";
            this.inchirieriBindingSource.DataSource = this.dataSet1;
            this.inchirieriBindingSource.PositionChanged += new System.EventHandler(this.inchirieriBindingSource_PositionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInchiriereDataGridViewTextBoxColumn1,
            this.idUtilajDataGridViewTextBoxColumn,
            this.nrZileDataGridViewTextBoxColumn,
            this.tarifZiDataGridViewTextBoxColumn,
            this.nrCrtDataGridViewTextBoxColumn,
            this.Valoare});
            this.dataGridView1.DataSource = this.inchirieriContinutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 174);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idInchiriereDataGridViewTextBoxColumn1
            // 
            this.idInchiriereDataGridViewTextBoxColumn1.DataPropertyName = "IdInchiriere";
            this.idInchiriereDataGridViewTextBoxColumn1.HeaderText = "IdInchiriere";
            this.idInchiriereDataGridViewTextBoxColumn1.Name = "idInchiriereDataGridViewTextBoxColumn1";
            this.idInchiriereDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idUtilajDataGridViewTextBoxColumn
            // 
            this.idUtilajDataGridViewTextBoxColumn.DataPropertyName = "IdUtilaj";
            this.idUtilajDataGridViewTextBoxColumn.HeaderText = "IdUtilaj";
            this.idUtilajDataGridViewTextBoxColumn.Name = "idUtilajDataGridViewTextBoxColumn";
            this.idUtilajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrZileDataGridViewTextBoxColumn
            // 
            this.nrZileDataGridViewTextBoxColumn.DataPropertyName = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.HeaderText = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.Name = "nrZileDataGridViewTextBoxColumn";
            this.nrZileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarifZiDataGridViewTextBoxColumn
            // 
            this.tarifZiDataGridViewTextBoxColumn.DataPropertyName = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.HeaderText = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.Name = "tarifZiDataGridViewTextBoxColumn";
            this.tarifZiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Valoare
            // 
            this.Valoare.DataPropertyName = "Valoare";
            this.Valoare.HeaderText = "Valoare";
            this.Valoare.Name = "Valoare";
            this.Valoare.ReadOnly = true;
            // 
            // inchirieriContinutBindingSource
            // 
            this.inchirieriContinutBindingSource.DataMember = "InchirieriContinut";
            this.inchirieriContinutBindingSource.DataSource = this.dataSet1;
            // 
            // btnInchiriere
            // 
            this.btnInchiriere.Location = new System.Drawing.Point(516, 60);
            this.btnInchiriere.Name = "btnInchiriere";
            this.btnInchiriere.Size = new System.Drawing.Size(128, 23);
            this.btnInchiriere.TabIndex = 2;
            this.btnInchiriere.Text = "Inchiriere noua";
            this.btnInchiriere.UseVisualStyleBackColor = true;
            this.btnInchiriere.Click += new System.EventHandler(this.btnInchiriereNoua_Click);
            // 
            // btnModificaInchiriere
            // 
            this.btnModificaInchiriere.Location = new System.Drawing.Point(516, 89);
            this.btnModificaInchiriere.Name = "btnModificaInchiriere";
            this.btnModificaInchiriere.Size = new System.Drawing.Size(128, 23);
            this.btnModificaInchiriere.TabIndex = 3;
            this.btnModificaInchiriere.Text = "Modifica Inchiriere";
            this.btnModificaInchiriere.UseVisualStyleBackColor = true;
            this.btnModificaInchiriere.Click += new System.EventHandler(this.btnModificareInchiriere_Click);
            // 
            // btnStergeInchiriere
            // 
            this.btnStergeInchiriere.Location = new System.Drawing.Point(516, 118);
            this.btnStergeInchiriere.Name = "btnStergeInchiriere";
            this.btnStergeInchiriere.Size = new System.Drawing.Size(128, 23);
            this.btnStergeInchiriere.TabIndex = 4;
            this.btnStergeInchiriere.Text = "Sterge Inchiriere";
            this.btnStergeInchiriere.UseVisualStyleBackColor = true;
            this.btnStergeInchiriere.Click += new System.EventHandler(this.btnStergeInchiriere_Click);
            // 
            // txtIdInchiriere
            // 
            this.txtIdInchiriere.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inchirieriBindingSource, "IdInchiriere", true));
            this.txtIdInchiriere.Location = new System.Drawing.Point(544, 34);
            this.txtIdInchiriere.Name = "txtIdInchiriere";
            this.txtIdInchiriere.ReadOnly = true;
            this.txtIdInchiriere.Size = new System.Drawing.Size(100, 20);
            this.txtIdInchiriere.TabIndex = 5;
            // 
            // inchirieriTableAdapter
            // 
            this.inchirieriTableAdapter.ClearBeforeFill = true;
            // 
            // inchirieriContinutTableAdapter
            // 
            this.inchirieriContinutTableAdapter.ClearBeforeFill = true;
            // 
            // FInchirieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 363);
            this.Controls.Add(this.txtIdInchiriere);
            this.Controls.Add(this.btnStergeInchiriere);
            this.Controls.Add(this.btnModificaInchiriere);
            this.Controls.Add(this.btnInchiriere);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inchirieriBindingSource, "IdInchiriere", true));
            this.Name = "FInchirieri";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FInchirieri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInchiriere;
        private System.Windows.Forms.Button btnModificaInchiriere;
        private System.Windows.Forms.Button btnStergeInchiriere;
        private System.Windows.Forms.TextBox txtIdInchiriere;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource inchirieriBindingSource;
        private DataSet1TableAdapters.InchirieriTableAdapter inchirieriTableAdapter;
        private System.Windows.Forms.BindingSource inchirieriContinutBindingSource;
        private DataSet1TableAdapters.InchirieriContinutTableAdapter inchirieriContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInchiriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoare;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInchiriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrInchiriereDataGridViewTextBoxColumn;
    }
}