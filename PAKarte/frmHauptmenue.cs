using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKarte
{
    public partial class frmHauptmenue : Form
    {
        public frmHauptmenue()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKarteHaltestellen_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHaltestellenKarte fKH = new frmHaltestellenKarte();
            fKH.Show();
        }

        private void btnHaltestellenDB(object sender, EventArgs e)
        {
            this.Hide();
            frmHaltestellenDB fHDB = new frmHaltestellenDB();
            fHDB.Show();
        }

        private void btnHaltestellenArray_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHaltestellenCSV fHA = new frmHaltestellenCSV();
            fHA.Show();
        }

        private void frmHauptmenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
