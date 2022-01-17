namespace InchiriereUtilaje
{
    partial class FFurnizori
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
            this.idSocietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireSocietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.societatiComercialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new InchiriereUtilaje.DataSet1();
            this.societatiComercialeTableAdapter = new InchiriereUtilaje.DataSet1TableAdapters.SocietatiComercialeTableAdapter();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtIdSocietate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.societatiComercialeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocietateDataGridViewTextBoxColumn,
            this.denumireSocietateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.societatiComercialeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // idSocietateDataGridViewTextBoxColumn
            // 
            this.idSocietateDataGridViewTextBoxColumn.DataPropertyName = "IdSocietate";
            this.idSocietateDataGridViewTextBoxColumn.HeaderText = "IdSocietate";
            this.idSocietateDataGridViewTextBoxColumn.Name = "idSocietateDataGridViewTextBoxColumn";
            this.idSocietateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireSocietateDataGridViewTextBoxColumn
            // 
            this.denumireSocietateDataGridViewTextBoxColumn.DataPropertyName = "DenumireSocietate";
            this.denumireSocietateDataGridViewTextBoxColumn.HeaderText = "DenumireSocietate";
            this.denumireSocietateDataGridViewTextBoxColumn.Name = "denumireSocietateDataGridViewTextBoxColumn";
            this.denumireSocietateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // societatiComercialeBindingSource
            // 
            this.societatiComercialeBindingSource.DataMember = "SocietatiComerciale";
            this.societatiComercialeBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // societatiComercialeTableAdapter
            // 
            this.societatiComercialeTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(13, 13);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(103, 13);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Sterge";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(193, 12);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renunta";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(193, 51);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirma";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(13, 54);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 5;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(128, 94);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 13);
            this.lblOp.TabIndex = 6;
            // 
            // txtIdSocietate
            // 
            this.txtIdSocietate.Location = new System.Drawing.Point(13, 86);
            this.txtIdSocietate.Name = "txtIdSocietate";
            this.txtIdSocietate.Size = new System.Drawing.Size(100, 20);
            this.txtIdSocietate.TabIndex = 7;
            // 
            // FFurnizori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 382);
            this.Controls.Add(this.txtIdSocietate);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FFurnizori";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FFurnizori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.societatiComercialeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource societatiComercialeBindingSource;
        private DataSet1TableAdapters.SocietatiComercialeTableAdapter societatiComercialeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireSocietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtIdSocietate;
    }
}