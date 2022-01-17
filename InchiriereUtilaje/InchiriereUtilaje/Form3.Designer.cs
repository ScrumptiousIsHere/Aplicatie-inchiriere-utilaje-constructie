namespace InchiriereUtilaje
{
    partial class Form3
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSocietati = new System.Windows.Forms.Button();
            this.btnUtilaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(24, 18);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Bun venit, ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(88, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Utilizatorule";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(24, 200);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(287, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Tema proiectului este o aplicatie pentru inchirierea utilajelor.";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(24, 213);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(543, 13);
            this.lblText1.TabIndex = 3;
            this.lblText1.Text = "Acest proiect a fost realizat de catre Ionescu Gruia-Andrei, student in grupa 2 a" +
    " anului III, specializarea Informatica";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(27, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(239, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Click aici pentru vizualizarea comenzilor !";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSocietati
            // 
            this.btnSocietati.Location = new System.Drawing.Point(27, 94);
            this.btnSocietati.Name = "btnSocietati";
            this.btnSocietati.Size = new System.Drawing.Size(284, 23);
            this.btnSocietati.TabIndex = 5;
            this.btnSocietati.Text = "Click aici pentru a vizualiza Societatile Comerciale !";
            this.btnSocietati.UseVisualStyleBackColor = true;
            this.btnSocietati.Click += new System.EventHandler(this.btnSocietati_Click);
            // 
            // btnUtilaje
            // 
            this.btnUtilaje.Location = new System.Drawing.Point(27, 136);
            this.btnUtilaje.Name = "btnUtilaje";
            this.btnUtilaje.Size = new System.Drawing.Size(218, 23);
            this.btnUtilaje.TabIndex = 6;
            this.btnUtilaje.Text = "Click aici pentru a vizualiza Utilajele !";
            this.btnUtilaje.UseVisualStyleBackColor = true;
            this.btnUtilaje.Click += new System.EventHandler(this.btnUtilaje_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 235);
            this.Controls.Add(this.btnUtilaje);
            this.Controls.Add(this.btnSocietati);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLogin);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSocietati;
        private System.Windows.Forms.Button btnUtilaje;
    }
}