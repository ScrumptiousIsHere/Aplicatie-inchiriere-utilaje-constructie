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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void completeazaUser(String nume)
        {
            lblUser.Text = nume;
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            FInchirieri f = new FInchirieri();
            f.ShowDialog();
        }

        public void btnSocietati_Click(object sender, EventArgs e)
        {
            FFurnizori f = new FFurnizori();
            f.ShowDialog();
        }

        public void btnUtilaje_Click(object sender, EventArgs e)
        {
            FUtilaje f = new FUtilaje();
            f.ShowDialog();
        }
    }
}
