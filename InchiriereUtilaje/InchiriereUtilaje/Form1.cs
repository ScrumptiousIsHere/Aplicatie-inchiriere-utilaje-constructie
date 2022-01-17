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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.userparola' table. You can move, or remove it, as needed.
            this.userparolaTableAdapter.Fill(this.dataSet1.userparola);

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
                

            foreach (DataRow r in dataSet1.userparola)
            {
                if (r["Username"].ToString() == txtUsername.Text && r["Parola"].ToString() == txtParola.Text)
                {
                    Form3 fa = new Form3();
                    fa.completeazaUser(r["NumeCont"].ToString());
                    fa.ShowDialog();
                    break;
                }
                else
                {
                    MessageBox.Show("Combinatia user-parola este invalida");
                    break;
                }
            }
        }
    }
}
