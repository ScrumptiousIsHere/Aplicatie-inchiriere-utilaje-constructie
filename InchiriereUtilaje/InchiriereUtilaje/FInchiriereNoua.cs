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
    public partial class FInchiriereNoua : Form
    {

        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;

        public FInchiriereNoua()
        {
            InitializeComponent();
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SocietatiComerciale' table. You can move, or remove it, as needed.
            this.societatiComercialeTableAdapter.Fill(this.dataSet1.SocietatiComerciale);
            // TODO: This line of code loads data into the 'dataSet12.Inchirieri' table. You can move, or remove it, as needed.
            this.inchirieriTableAdapter.Fill(this.dataSet1.Inchirieri);
            // TODO: This line of code loads data into the 'dataSet1.SocietatiComerciale' table. You can move, or remove it, as needed.
            this.societatiComercialeTableAdapter.Fill(this.dataSet1.SocietatiComerciale);
            A1();
        }

        private void inchiriereContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void A1()
        { //Incarcare DataTable Utilaje 
            utilajeTableAdapter.Fill(dataSet1.Utilaje);
            //Incarcare DataTable SocietatiComerciale 
            societatiComercialeTableAdapter.Fill(dataSet1.SocietatiComerciale);
            // Protectie la modificare 
            txtNrInchiriere.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            nrZileDataGridViewTextBoxColumn.ReadOnly = true;
            tarifZiDataGridViewTextBoxColumn.ReadOnly = true;
            idUtilajDataGridViewTextBoxColumn.ReadOnly = true;

            if (lblOp.Text == "MODIFICARE COMANDA") completeazaInchiriere();
            else if (lblOp.Text == "COMANDA NOUA") cmbSocietate.SelectedIndex = -1;
        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            generez_nr_cda();
            // Scriu inregistrare in Comenzi si ComenziContinut
            adaugaInregistrareInchirieri();
            cautaInregistrare();
            adaugaInregistrariInchirieriContinut();
            golireCampuri();
        }

        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)inchiriereContinutManevraBindingSource.Current;
            current["NrCrt"] = inchiriereContinutManevraBindingSource.Position + 1;
        }


        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {


                    DataRowView current = (DataRowView)utilajeBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[2].ReadOnly = false;
                    dataGridView1.CurrentRow.Cells[3].Value = current["TarifZi"];
                    dataGridView1.CurrentRow.Cells[5].Value = current["IdUtilaj"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["SpImagine"];
                    dataGridView1.CurrentRow.Cells[2].Value = 1;
                    calcTotal();
                    
                    
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    DataRowView current = (DataRowView)utilajeBindingSource.Current;
                    inchiriereContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }


        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }


        private void FComenziAct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.utilajeTableAdapter.Fill(this.dataSet1.Utilaje);
            // TODO: This line of code loads data into the 'dataSet1.Clienti' table. You can move, or remove it, as needed.
            this.societatiComercialeTableAdapter.Fill(this.dataSet1.SocietatiComerciale);

        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet1.InchiriereContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }

       

        private void generez_nr_cda()
        {
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Inchirieri.NrInchiriere) AS NrMax FROM Inchirieri";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrInchiriere.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {//Validare de completare obligatorie campul Client
            if (cmbSocietate.Text == "")
            {
                MessageBox.Show("Completati Societatea !");
                cmbSocietate.Focus();
                return false;
            }
            // Validare completare continut
            if (inchiriereContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut inchiriere !");
                dataGridView1.Focus();
                return false;
            }

            foreach (DataRow r in dataSet1.InchiriereContinutManevra)
            {
                if (r["NrZile"] == DBNull.Value)
                {
                    MessageBox.Show("Completati numarul de zile !");
                    dataGridView1.Focus();
                    return false;
                }
            }
            return true;
        }

        private void adaugaInregistrareInchirieri()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "NrInchiriere, DataImprumut, IdSocietate";
            listaValori = txtNrInchiriere.Text +
                            ",#" + Convert.ToString(d.Month) + "/"
                            + Convert.ToString(d.Day) + "/"
                            + Convert.ToString(d.Year) + "#,"
                            + cmbSocietate.SelectedValue;
            cmd.CommandText = "Insert into Inchirieri(" + listaCampuri + ") "
                            + "Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT idInchiriere From Inchirieri Where NrInchiriere = " + txtNrInchiriere.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariInchirieriContinut()
        {
            string listaCampuri = "IdInchiriere, NrCrt, IdUtilaj, NrZile, TarifZi";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataSet1.InchiriereContinutManevra)
            {
                listaValori = idCda + "," + r["NrCrt"] + "," + r["IdUtilaj"] + "," +
                        r["NrZile"] + "," + r["TarifZi"];
                cmd.CommandText = "Insert into InchirieriContinut(" + listaCampuri + ") " + "Select " + listaValori;
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }


        private void golireCampuri()
        {
            txtNrInchiriere.Text = "";
            cmbSocietate.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.InchiriereContinutManevra.Clear();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            con.ConnectionString = utilajeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            string clauzaWhere = " Where IdInchiriere = " + idCda;
            string clauzaSet = "Set DataImprumut = #" + d1.Month + "/" + d1.Day + "/" + d1.Year + "#," + "IdSocietate = " + cmbSocietate.SelectedValue;
            cmd.CommandText = "Update Inchirieri " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from InchirieriContinut Where IdInchiriere = " + idCda;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void completeazaInchiriere()
        {
            DataRowView current = (DataRowView)bs1.Current;
            idCda = (int)current["IdInchiriere"];
            txtNrInchiriere.Text = Convert.ToString(current["NrInchiriere"]);
            cmbSocietate.Text = current["DenumireSocietate"].ToString();
            txtTotal.Text = current["Total"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataImprumut"]);
            bs2.MoveFirst();
            dataSet1.InchiriereContinutManevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;
                DataSet1.InchiriereContinutManevraRow r = dataSet1.InchiriereContinutManevra.NewInchiriereContinutManevraRow();
                r.NrCrt = Convert.ToInt16(current["NrCrt"]);
                r.DenumireUtilaj = Convert.ToString(current["DenumireUtilaj"]);
                r.TarifZi = Convert.ToDecimal(current["TarifZi"]);
                r.NrZile = Convert.ToInt32(current["NrZile"]);
                r.IdUtilaj = Convert.ToInt32(current["IdUtilaj"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                dataSet1.InchiriereContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void inchirieriBindingSource_PositionChanged(object sender, EventArgs e)
        {
            calcTotal();
        }
        private void inchirieriContinutManevraBindingSource_PositionChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void cmbSocietate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
