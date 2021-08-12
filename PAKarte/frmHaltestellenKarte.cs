using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

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
            Subscribe();
            FormClosing += Main_Closing;
        }

        private string dir = @"C:\TEMP\Haltestellen.csv";
        private double hx;
        private double hy;
        private double minLaenge = Double.MaxValue, maxLaenge = Double.MinValue;
        private double minBreite = Double.MaxValue, maxBreite = Double.MinValue;
        private Dictionary<Point, string> dictPntOrt = new Dictionary<Point, string>();
        private BackgroundWorker worker = new BackgroundWorker();
        private const int len = 6598;
        private IKeyboardMouseEvents m_GlobalHook;

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            //m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook = Hook.AppEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            //Console.WriteLine("KeyPress: \t{0}", e.KeyChar);
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            //Console.WriteLine("MouseDown: \t{0}; \t System Timestamp: \t{1}", e.Button, e.Timestamp);

            lblXY.Text = "";

            Point mousePoint = panKarte.PointToClient(Control.MousePosition);

            if (e.Button == MouseButtons.Left)
            {
                foreach (Point p in dictPntOrt.Keys)
                {
                    if (Math.Abs(mousePoint.X - p.X) < 10 && Math.Abs(mousePoint.Y - p.Y) < 10)
                    {
                        lblXY.Text = dictPntOrt[p].ToString();
                        lblXAnz.Text = mousePoint.X.ToString();
                        lblYAnz.Text = mousePoint.Y.ToString();
                    }
                }
            }
        }

        public void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            m_GlobalHook.KeyPress -= GlobalHookKeyPress;

            //It is recommened to dispose it
            m_GlobalHook.Dispose();
        }

        private void Main_Closing(object sender, CancelEventArgs e)
        {
            Unsubscribe();
        }

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
                float paneSize = 5f;

                hx = (float)(panKarte.Width / (maxLaenge - minLaenge) * (hlt.Laenge - minLaenge)) - paneSize;
                hy = (float)(panKarte.Height - (panKarte.Height / (maxBreite - minBreite) * (hlt.Breite - minBreite))) - paneSize;

                if (hlt.isHbf(hlt.Name))
                {
                    Panel paneHbf = new Panel();
                    paneHbf.Size = new Size((int)(1.5 * paneSize), (int)(1.5 * paneSize));
                    paneHbf.BackColor = Color.Yellow;
                    paneHbf.BorderStyle = BorderStyle.FixedSingle;
                    paneHbf.Location = new Point((int)hx, (int)hy);
                    panKarte.Controls.Add(paneHbf);
                    paneHbf.BringToFront();
                    Point p = new Point((int)hx, (int)hy);
                    dictPntOrt[p] = hlt.Name;
                }
                else
                {
                    Panel pane = new Panel();
                    pane.Size = new Size((int)paneSize, (int)paneSize);
                    pane.BackColor = Color.Black;
                    pane.BorderStyle = BorderStyle.FixedSingle;
                    pane.Location = new Point((int)hx, (int)hy);
                    panKarte.Controls.Add(pane);

                    pane.SendToBack();
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

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Image files(*.jpeg)|*.jpeg"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var file = new FileInfo(sfd.FileName);

                    using (Bitmap bmp = new Bitmap(panKarte.Width, panKarte.Height))
                    {
                        panKarte.DrawToBitmap(bmp, panKarte.ClientRectangle);
                        bmp.Save(file.FullName, ImageFormat.Jpeg);
                        bmp.Dispose();
                    }
                }
            }
        }

        private void panKarte_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = panKarte.PointToClient(Control.MousePosition);

            lblXAnz.Text = mousePoint.X.ToString();
            lblYAnz.Text = mousePoint.Y.ToString();
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

