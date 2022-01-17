namespace InchiriereUtilaje
{
    partial class FUtilaje
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
            this.idUtilajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireUtilajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new InchiriereUtilaje.DataSet1();
            this.utilajeTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.UtilajeTableAdapter();
            this.PB = new System.Windows.Forms.PictureBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.txtIdUtilaj = new System.Windows.Forms.TextBox();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSpImagine = new System.Windows.Forms.Label();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilajDataGridViewTextBoxColumn,
            this.denumireUtilajDataGridViewTextBoxColumn,
            this.tarifZiDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilajeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // idUtilajDataGridViewTextBoxColumn
            // 
            this.idUtilajDataGridViewTextBoxColumn.DataPropertyName = "IdUtilaj";
            this.idUtilajDataGridViewTextBoxColumn.HeaderText = "IdUtilaj";
            this.idUtilajDataGridViewTextBoxColumn.Name = "idUtilajDataGridViewTextBoxColumn";
            // 
            // denumireUtilajDataGridViewTextBoxColumn
            // 
            this.denumireUtilajDataGridViewTextBoxColumn.DataPropertyName = "DenumireUtilaj";
            this.denumireUtilajDataGridViewTextBoxColumn.HeaderText = "DenumireUtilaj";
            this.denumireUtilajDataGridViewTextBoxColumn.Name = "denumireUtilajDataGridViewTextBoxColumn";
            // 
            // tarifZiDataGridViewTextBoxColumn
            // 
            this.tarifZiDataGridViewTextBoxColumn.DataPropertyName = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.HeaderText = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.Name = "tarifZiDataGridViewTextBoxColumn";
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Visible = false;
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
            // utilajeTableAdapter
            // 
            this.utilajeTableAdapter.ClearBeforeFill = true;
            // 
            // PB
            // 
            this.PB.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.utilajeBindingSource, "SpImagine", true));
            this.PB.Location = new System.Drawing.Point(479, 82);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(244, 202);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 1;
            this.PB.TabStop = false;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(13, 13);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(95, 13);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "Modifica";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(177, 13);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(373, 125);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 5;
            this.txtDenumire.Leave += new System.EventHandler(this.txtDenumire_Leave);
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(373, 199);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(100, 20);
            this.txtTarif.TabIndex = 6;
            this.txtTarif.Leave += new System.EventHandler(this.txtTarif_Leave);
            // 
            // txtIdUtilaj
            // 
            this.txtIdUtilaj.Location = new System.Drawing.Point(373, 264);
            this.txtIdUtilaj.Name = "txtIdUtilaj";
            this.txtIdUtilaj.ReadOnly = true;
            this.txtIdUtilaj.Size = new System.Drawing.Size(100, 20);
            this.txtIdUtilaj.TabIndex = 7;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(373, 94);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(52, 13);
            this.lblDenumire.TabIndex = 8;
            this.lblDenumire.Text = "Denumire";
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(373, 168);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(37, 13);
            this.lblTarif.TabIndex = 9;
            this.lblTarif.Text = "TarifZi";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(373, 237);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "Id Utilaj";
            // 
            // lblSpImagine
            // 
            this.lblSpImagine.AutoSize = true;
            this.lblSpImagine.Location = new System.Drawing.Point(399, 55);
            this.lblSpImagine.Name = "lblSpImagine";
            this.lblSpImagine.Size = new System.Drawing.Size(68, 13);
            this.lblSpImagine.TabIndex = 11;
            this.lblSpImagine.Text = "Locatie poza";
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(473, 52);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(215, 20);
            this.txtLocatie.TabIndex = 12;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(630, 13);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(31, 13);
            this.lblOp.TabIndex = 13;
            this.lblOp.Text = "        ";
            this.lblOp.Click += new System.EventHandler(this.lblOp_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(430, 13);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 14;
            this.btnConfirmare.Text = "Confirma";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(524, 13);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 15;
            this.btnRenuntare.Text = "Renunta";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FUtilaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 296);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.lblSpImagine);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.txtIdUtilaj);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FUtilaje";
            this.Text = "FUtilaje";
            this.Load += new System.EventHandler(this.FUtilaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource utilajeBindingSource;
        private DataSet1TableAdapters.UtilajeTableAdapter utilajeTableAdapter;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.TextBox txtIdUtilaj;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSpImagine;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireUtilajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}