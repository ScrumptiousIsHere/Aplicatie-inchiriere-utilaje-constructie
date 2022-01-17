using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InchiriereUtilaje
{
    public partial class FFurnizori: Form
    {
        public FFurnizori()
        {
            InitializeComponent();
        }

        private void FFurnizori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SocietatiComerciale' table. You can move, or remove it, as needed.
            A1();

        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void A1()
        {
            societatiComercialeTableAdapter.Fill(dataSet1.SocietatiComerciale);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtDenumire.ReadOnly = true;
            A3();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "ADAUGARE";
            txtDenumire.Focus();
            golireCampuri();
        }


        private void A3()
        {
            lblOp.Text = "";
            configureazaButoane(true);
            protectiePanel(true);
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;
                adaugaInregistrare();
                golireCampuri();
                txtDenumire.Focus();
                refreshGrid(societatiComercialeBindingSource.Position);
            }
            else MessageBox.Show("Operatie actualizare neefectuata");
        }


        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmdadaugare = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            
            con.ConnectionString = societatiComercialeTableAdapter.Connection.ConnectionString;
            cmdadaugare.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmdadaugare.CommandText = "Select DenumireSocietate From SocietatiComerciale where DenumireSocietate='" + txtDenumire.Text + "'";
                con.Open();
                r = cmdadaugare.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Societatea este deja existenta !");
                    txtDenumire.Focus();
                }
                con.Close();
            }
            

        }


        private void A7()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "MODIFICARE";
            txtDenumire.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = societatiComercialeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdInchiriere From Inchirieri where IdSocietate=" + txtIdSocietate.Text; con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Societatea este referita in tabela Inchirieri si nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = societatiComercialeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From SocietatiComerciale Where IdSocietate = " + txtIdSocietate.Text; MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid(societatiComercialeBindingSource.Position);
        }

        private void adaugaInregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = societatiComercialeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DenumireSocietate";
            listaValori = "'" + txtDenumire.Text + "'";
            cmd.CommandText = "Insert into SocietatiComerciale(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void refreshGrid(int p)
        {
            societatiComercialeTableAdapter.Fill(dataSet1.SocietatiComerciale);
            societatiComercialeBindingSource.Position = p;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void txtDenumire_Leave(object sender, EventArgs e)
        {
            A5(txtDenumire);
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtDenumire.DataBindings.Clear();
                txtIdSocietate.DataBindings.Clear();
                txtDenumire.DataBindings.Add("Text", societatiComercialeBindingSource, "DenumireSocietate");
                txtIdSocietate.DataBindings.Add("Text", societatiComercialeBindingSource, "IdSocietate");
            }
            else
            {
                txtDenumire.DataBindings.Clear();
                txtIdSocietate.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            txtDenumire.ReadOnly = v;
            txtIdSocietate.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtDenumire.Text = "";
            txtIdSocietate.Text = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtDenumire.Text == "")
            {
                MessageBox.Show("Completati denumirea societatii !");
                txtDenumire.Focus();
                return false;
            }
            return true;
        }


    }
}
