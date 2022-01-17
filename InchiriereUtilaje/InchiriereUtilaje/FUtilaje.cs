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
    public partial class FUtilaje : Form
    {
        public FUtilaje()
        {
            InitializeComponent();
        }

        private void FUtilaje_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            utilajeTableAdapter.Fill(dataSet1.Utilaje);
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtIdUtilaj.ReadOnly = true;
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
                refreshGrid(utilajeBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                if (!validareCampuriObligatorii()) return;
                modificaInregistrare();
                refreshGrid(utilajeBindingSource.Position);
                A3();
            }
            else MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmdadaugare = new OleDbCommand();
            OleDbCommand cmdmodificare = new OleDbCommand();
            OleDbDataReader r;
            
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;
            if (txtB == txtTarif)
            {// Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                return;
            }
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmdadaugare.Connection = con;
            cmdmodificare.Connection = con;
            if (lblOp.Text == "ADAUGARE")
            {
                cmdadaugare.CommandText = "Select DenumireUtilaj From Utilaje where DenumireUtilaj='" + txtDenumire.Text + "'";
                con.Open();
                r = cmdadaugare.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Utilajul este deja existent !");
                    txtDenumire.Focus();
                }
                con.Close();
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                cmdmodificare.CommandText = "Select DenumireUtilaj From Utilaje where DenumireUtilaj='" + txtDenumire.Text + "' and IdUtilaj  <> " + txtIdUtilaj.Text;
                con.Open();
                r = cmdmodificare.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Utilaj deja existent");
                    txtDenumire.Focus();
                }
            }
            con.Close();
        }


        private void A6()
        {
            if (lblOp.Text == "")
                return;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocatie.Text = openFileDialog1.FileName;
                PB.ImageLocation = txtLocatie.Text;
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
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdInchiriere From InchirieriContinut where IdUtilaj=" + txtIdUtilaj.Text; con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Utilajul referit in tabela InchirieriContinut nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Utilaje Where IdUtilaj = " + txtIdUtilaj.Text; MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refreshGrid(utilajeBindingSource.Position);
        }


        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtDenumire.DataBindings.Clear();
                txtTarif.DataBindings.Clear();
                txtIdUtilaj.DataBindings.Clear();
                PB.DataBindings.Clear();
                txtDenumire.DataBindings.Add("Text", utilajeBindingSource, "DenumireUtilaj");
                txtTarif.DataBindings.Add("Text", utilajeBindingSource, "TarifZi");
                txtIdUtilaj.DataBindings.Add("Text", utilajeBindingSource, "IdUtilaj");
                PB.DataBindings.Add("ImageLocation", utilajeBindingSource, "SpImagine");
            }
            else
            {
                txtDenumire.DataBindings.Clear();
                txtTarif.DataBindings.Clear();
                txtIdUtilaj.DataBindings.Clear();
                PB.DataBindings.Clear();
            }
        }


        private void protectiePanel(bool v)
        {
            txtDenumire.ReadOnly = v;
            txtTarif.ReadOnly = v;
            txtIdUtilaj.ReadOnly = v;
            txtLocatie.ReadOnly = v;
        }


        private void golireCampuri()
        {
            txtDenumire.Text = "";
            txtTarif.Text = "";
            txtIdUtilaj.Text = "";
            txtLocatie.Text = "";
        }


        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtDenumire.Text == "")
            {
                MessageBox.Show("Completati denumirea utilajului !");
                txtDenumire.Focus();
                return false;
            }
            if (txtTarif.Text == "")
            {
                MessageBox.Show("Completati tariful !");
                txtTarif.Focus();
                return false;
            }
            if (txtLocatie.Text == "")
            {
                MessageBox.Show("Completati locatia pozei !");
                txtLocatie.Focus();
                return false;
            }
            return true;
        }

        private void adaugaInregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DenumireUtilaj, TarifZi, SpImagine";
            listaValori = "'" + txtDenumire.Text + "'" +
            ",'" + txtTarif.Text + "'" +
            ",'" + txtLocatie.Text + "'";
            cmd.CommandText = "Insert into Utilaje(" + listaCampuri + ") " +
            "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void refreshGrid(int p)
        {
            utilajeTableAdapter.Fill(dataSet1.Utilaje);
            utilajeBindingSource.Position = p;
        }


        private void modificaInregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "DenumireUtilaj = '" + txtDenumire.Text + "'," +
            "TarifZi = '" + txtTarif.Text + "'," +
            "SpImagine = '" + txtLocatie.Text + "'";
            cmd.CommandText = "Update Utilaje Set " + listaSet + " Where IdUtilaj=" +
            txtIdUtilaj.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
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

        private void txtTarif_Leave(object sender, EventArgs e)
        {
            A5(txtTarif);
        }

        private void txtDenumire_Leave(object sender, EventArgs e)
        {
            A5(txtDenumire);
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void lblOp_Click(object sender, EventArgs e)
        {

        }

        
    }   
}
