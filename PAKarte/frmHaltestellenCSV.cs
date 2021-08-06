using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKarte
{
    public partial class frmHaltestellenCSV : Form
    {
        public frmHaltestellenCSV()
        {
            InitializeComponent();
        }

        private static string dir = @"C:\TEMP\Haltestellen.csv";

        private void frmHaltestellenDB_Load(object sender, EventArgs e)
        {
            dgvHaltestellen.RowsDefaultCellStyle.BackColor = Color.LightCoral;
            dgvHaltestellen.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvHaltestellen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHaltestellen.AllowUserToAddRows = false;
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHauptmenue fHM = new frmHauptmenue();
            fHM.Show();
        }

        private void btnDatenladen_Click(object sender, EventArgs e)
        {
            string[] values = File.ReadAllLines(dir);
            List<HaltestellenDaten> data = new List<HaltestellenDaten>();
            btnDatenladen.Enabled = false;

            int cntCells = File.ReadAllLines(dir).Length - 1;
            int cnt = 0;

            foreach (string line in values.Skip(1))
            {
                var splittedLine = line.Split(';');
                int nr = Int32.Parse(splittedLine[0]);
                string name = splittedLine[2];
                double laenge = Double.Parse(splittedLine[4], System.Globalization.CultureInfo.InvariantCulture);
                double breite = Double.Parse(splittedLine[5], System.Globalization.CultureInfo.InvariantCulture);

                HaltestellenDaten hlt = new HaltestellenDaten(nr, name, laenge, breite);
                data.Add(hlt);
                prgbLoad.Value = (int)(cnt + 1) * 100 / cntCells;
                lblProgress.Text = prgbLoad.Value.ToString() + "%";
                lblProgress.Refresh();
                cnt++;
            }

            if (prgbLoad.Value == 100)
            {
                prgbLoad.Value = 0;
                lblProgress.Text = prgbLoad.Value.ToString() + "%";
                lblProgress.Refresh();
                dgvHaltestellen.DataSource = data;
                btnDatenladen.Enabled = true;
            }
        }

        private void frmHaltestellenCSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
