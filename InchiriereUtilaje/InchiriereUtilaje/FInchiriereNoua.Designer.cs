namespace InchiriereUtilaje
{
    partial class FInchiriereNoua
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
            this.lblNrInchiriere = new System.Windows.Forms.Label();
            this.lblSocietate = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNrInchiriere = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.utilajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new InchiriereUtilaje.DataSet1();
            this.cmbSocietate = new System.Windows.Forms.ComboBox();
            this.societatiComercialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.utilajeTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.UtilajeTableAdapter();
            this.inchirieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inchirieriTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.InchirieriTableAdapter();
            this.societatiComercialeTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.SocietatiComercialeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireUtilajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nrZileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtilajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inchiriereContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.utilajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.societatiComercialeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereContinutManevraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrInchiriere
            // 
            this.lblNrInchiriere.AutoSize = true;
            this.lblNrInchiriere.Location = new System.Drawing.Point(16, 9);
            this.lblNrInchiriere.Name = "lblNrInchiriere";
            this.lblNrInchiriere.Size = new System.Drawing.Size(67, 13);
            this.lblNrInchiriere.TabIndex = 0;
            this.lblNrInchiriere.Text = "Nr. Inchiriere";
            // 
            // lblSocietate
            // 
            this.lblSocietate.AutoSize = true;
            this.lblSocietate.Location = new System.Drawing.Point(16, 79);
            this.lblSocietate.Name = "lblSocietate";
            this.lblSocietate.Size = new System.Drawing.Size(52, 13);
            this.lblSocietate.TabIndex = 1;
            this.lblSocietate.Text = "Societate";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 45);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(350, 74);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(546, 9);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(95, 13);
            this.lblOp.TabIndex = 4;
            this.lblOp.Text = "COMANDA NOUA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtNrInchiriere
            // 
            this.txtNrInchiriere.Location = new System.Drawing.Point(94, 6);
            this.txtNrInchiriere.Name = "txtNrInchiriere";
            this.txtNrInchiriere.Size = new System.Drawing.Size(100, 20);
            this.txtNrInchiriere.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(387, 71);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // utilajeBindingSource
            // 
            this.utilajeBindingSource.DataMember = "Utilaje";
            this.utilajeBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSocietate
            // 
            this.cmbSocietate.DataSource = this.societatiComercialeBindingSource;
            this.cmbSocietate.DisplayMember = "DenumireSocietate";
            this.cmbSocietate.FormattingEnabled = true;
            this.cmbSocietate.Location = new System.Drawing.Point(94, 76);
            this.cmbSocietate.Name = "cmbSocietate";
            this.cmbSocietate.Size = new System.Drawing.Size(121, 21);
            this.cmbSocietate.TabIndex = 10;
            this.cmbSocietate.ValueMember = "IdSocietate";
            this.cmbSocietate.SelectedIndexChanged += new System.EventHandler(this.cmbSocietate_SelectedIndexChanged);
            // 
            // societatiComercialeBindingSource
            // 
            this.societatiComercialeBindingSource.DataMember = "SocietatiComerciale";
            this.societatiComercialeBindingSource.DataSource = this.dataSet1;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(549, 69);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 11;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // utilajeTableAdapter
            // 
            this.utilajeTableAdapter.ClearBeforeFill = true;
            // 
            // inchirieriTableAdapter
            // 
            this.inchirieriTableAdapter.ClearBeforeFill = true;
            // 
            // societatiComercialeTableAdapter
            // 
            this.societatiComercialeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCrtDataGridViewTextBoxColumn,
            this.denumireUtilajDataGridViewTextBoxColumn,
            this.nrZileDataGridViewTextBoxColumn,
            this.tarifZiDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.idUtilajDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inchiriereContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 214);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            // 
            // denumireUtilajDataGridViewTextBoxColumn
            // 
            this.denumireUtilajDataGridViewTextBoxColumn.DataPropertyName = "DenumireUtilaj";
            this.denumireUtilajDataGridViewTextBoxColumn.DataSource = this.utilajeBindingSource;
            this.denumireUtilajDataGridViewTextBoxColumn.DisplayMember = "DenumireUtilaj";
            this.denumireUtilajDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.denumireUtilajDataGridViewTextBoxColumn.HeaderText = "DenumireUtilaj";
            this.denumireUtilajDataGridViewTextBoxColumn.Name = "denumireUtilajDataGridViewTextBoxColumn";
            this.denumireUtilajDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireUtilajDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.denumireUtilajDataGridViewTextBoxColumn.ValueMember = "DenumireUtilaj";
            // 
            // nrZileDataGridViewTextBoxColumn
            // 
            this.nrZileDataGridViewTextBoxColumn.DataPropertyName = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.HeaderText = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.Name = "nrZileDataGridViewTextBoxColumn";
            // 
            // tarifZiDataGridViewTextBoxColumn
            // 
            this.tarifZiDataGridViewTextBoxColumn.DataPropertyName = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.HeaderText = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.Name = "tarifZiDataGridViewTextBoxColumn";
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUtilajDataGridViewTextBoxColumn
            // 
            this.idUtilajDataGridViewTextBoxColumn.DataPropertyName = "IdUtilaj";
            this.idUtilajDataGridViewTextBoxColumn.HeaderText = "IdUtilaj";
            this.idUtilajDataGridViewTextBoxColumn.Name = "idUtilajDataGridViewTextBoxColumn";
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Visible = false;
            // 
            // inchiriereContinutManevraBindingSource
            // 
            this.inchiriereContinutManevraBindingSource.DataMember = "InchiriereContinutManevra";
            this.inchiriereContinutManevraBindingSource.DataSource = this.dataSet1;
            this.inchiriereContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.inchiriereContinutManevraBindingSource_CurrentChanged);
            this.inchiriereContinutManevraBindingSource.PositionChanged += new System.EventHandler(this.inchirieriBindingSource_PositionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.utilajeBindingSource, "SpImagine", true));
            this.pictureBox1.Location = new System.Drawing.Point(668, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FInchiriereNoua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.cmbSocietate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNrInchiriere);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSocietate);
            this.Controls.Add(this.lblNrInchiriere);
            this.Name = "FInchiriereNoua";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.societatiComercialeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriereContinutManevraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrInchiriere;
        private System.Windows.Forms.Label lblSocietate;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNrInchiriere;
        private System.Windows.Forms.TextBox txtTotal;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ComboBox cmbSocietate;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.BindingSource utilajeBindingSource;
        private DataSet1TableAdapters.UtilajeTableAdapter utilajeTableAdapter;
        private System.Windows.Forms.BindingSource inchirieriBindingSource;
        private DataSet1TableAdapters.InchirieriTableAdapter inchirieriTableAdapter;
        private System.Windows.Forms.BindingSource societatiComercialeBindingSource;
        private DataSet1TableAdapters.SocietatiComercialeTableAdapter societatiComercialeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource inchiriereContinutManevraBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireUtilajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
    }
}