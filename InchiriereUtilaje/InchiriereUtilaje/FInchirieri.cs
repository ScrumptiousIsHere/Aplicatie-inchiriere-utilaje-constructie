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
    public partial class FInchirieri : Form
    {
        public FInchirieri()
        {
            InitializeComponent();
        }


        private void refreshGrid()
        {
            inchirieriTableAdapter.Fill(dataSet1.Inchirieri);
            inchirieriContinutTableAdapter.Fill(dataSet1.InchirieriContinut);
        }


        private void FInchirieri_Load(object sender, EventArgs e)
        {
            refreshGrid();

            try
            {
                inchirieriContinutBindingSource.Filter = "IdInchiriere=" + txtIdInchiriere.Text;
            }
            catch { }
        }

        private void inchirieriBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                inchirieriContinutBindingSource.Filter = "IdInchiriere=" + txtIdInchiriere.Text;
            }
            catch { }
        }

        private void btnInchiriereNoua_Click(object sender, EventArgs e)
        {
            FInchiriereNoua f = new FInchiriereNoua();
            f.ShowDialog();
            refreshGrid();
            refreshGrid();
        }


        private void btnModificareInchiriere_Click(object sender, EventArgs e)
        {
            FInchiriereNoua f = new FInchiriereNoua();
            f.completeazaTitlu("MODIFICARE COMANDA");
            f.bs1 = inchirieriBindingSource;
            f.bs2 = inchirieriContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
            refreshGrid();
        }

        private void btnStergeInchiriere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = inchirieriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From InchirieriContinut Where IdInchiriere = " + txtIdInchiriere.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            // Sterg comanda
            cmd.CommandText = "Delete From Inchirieri Where IdInchiriere = " + txtIdInchiriere.Text;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.CommandText = "Inregistrarea a fost stearsa cu succes !";
            MessageBox.Show(cmd.CommandText);
            // Refresh grid-uri
            refreshGrid();
            refreshGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
