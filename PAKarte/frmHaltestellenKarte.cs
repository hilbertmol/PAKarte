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
    public partial class frmHaltestellenKarte : Form
    {
        public frmHaltestellenKarte()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += CSVLoad;
        }

        private string dir = @"C:\TEMP\Haltestellen.csv";
        private double hx;
        private double hy;
        private double minLaenge = Double.MaxValue, maxLaenge = Double.MinValue;
        private double minBreite = Double.MaxValue, maxBreite = Double.MinValue;

        private BackgroundWorker worker = new BackgroundWorker();
        private const int len = 6598;

        private void btnCSVLaden_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void btnZeichnen_Click(object sender, EventArgs e)
        {
            string[] values = File.ReadAllLines(dir);
            List<HaltestellenDaten> data = new List<HaltestellenDaten>();
            btnZeichnen.Enabled = false;

            foreach (string line in values.Skip(1))
            {
                var splittedLine = line.Split(';');
                int nr = Int32.Parse(splittedLine[0]);
                string name = splittedLine[2];
                double laenge = Double.Parse(splittedLine[4], System.Globalization.CultureInfo.InvariantCulture);
                double breite = Double.Parse(splittedLine[5], System.Globalization.CultureInfo.InvariantCulture);

                HaltestellenDaten hlt = new HaltestellenDaten(nr, name, laenge, breite);

                data.Add(hlt);

                if (laenge < minLaenge)
                    minLaenge = laenge;
                if (laenge > maxLaenge)
                    maxLaenge = laenge;
                if (breite < minBreite)
                    minBreite = breite;
                if (breite > maxBreite)
                    maxBreite = breite;
            }

            foreach (HaltestellenDaten hlt in data)
            {
                hx = (float)(pictureBox1.Width / (maxLaenge - minLaenge) * (hlt.Laenge - minLaenge));
                hy = (float)(pictureBox1.Height - (pictureBox1.Height / (maxBreite - minBreite) * (hlt.Breite - minBreite)));

                Panel pane = new Panel();
                pane.Size = new Size(5, 5);
                pane.BorderStyle = BorderStyle.FixedSingle;
                pane.Location = new Point((int)hx, (int)hy);
                pictureBox1.Controls.Add(pane);
                if (hlt.isHbf(hlt.Name))
                {
                    pane.BackColor = Color.Yellow;
                }
                else
                {
                    pane.BackColor = Color.Black;
                }
            }
            btnZeichnen.Enabled = true;
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHauptmenue fHM = new frmHauptmenue();
            fHM.Show();
        }

        private void frmHaltestellenKarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CSVLoad(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] values = File.ReadAllLines(dir);
                List<HaltestellenDaten> data = new List<HaltestellenDaten>();
                int cnt = 0;
                btnCSVLaden.Enabled = false;

                foreach (string line in values.Skip(1))
                {
                    var splittedLine = line.Split(';');
                    int nr = Int32.Parse(splittedLine[0]);
                    string name = splittedLine[2];
                    double laenge = Double.Parse(splittedLine[4], System.Globalization.CultureInfo.InvariantCulture);
                    double breite = Double.Parse(splittedLine[5], System.Globalization.CultureInfo.InvariantCulture);

                    HaltestellenDaten hlt = new HaltestellenDaten(nr, name, laenge, breite);

                    data.Add(hlt);
                    txtA.AppendText(line + System.Environment.NewLine);

                    if (laenge < minLaenge)
                        minLaenge = laenge;
                    if (laenge > maxLaenge)
                        maxLaenge = laenge;
                    if (breite < minBreite)
                        minBreite = breite;
                    if (breite > maxBreite)
                        maxBreite = breite;

                    worker.ReportProgress((int)(cnt + 1) * 100 / len);
                    cnt++;
                }

                txtA.AppendText("Min. Länge: " + minLaenge + System.Environment.NewLine);
                txtA.AppendText("Max. Länge: " + maxLaenge + System.Environment.NewLine);
                txtA.AppendText("Min. Breite: " + minBreite + System.Environment.NewLine);
                txtA.AppendText("Max. Breite: " + maxBreite + System.Environment.NewLine);

                Application.DoEvents();
                btnCSVLaden.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgbLoad.Value = e.ProgressPercentage;
            lblProgress.Text = e.ProgressPercentage.ToString() + "%";

            if (prgbLoad.Value == 100)
            {
                DialogResult res = MessageBox.Show("Datei geladen", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    prgbLoad.Value = 0;
                }
                lblProgress.Text = prgbLoad.Value.ToString() + "%";
            }
        }
    }
}

