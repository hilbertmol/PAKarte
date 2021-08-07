using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKarte
{
    public partial class frmHaltestellenDB : Form
    {
        public frmHaltestellenDB()
        {
            InitializeComponent();
            dgvHaltestellen.ReadOnly = true;
            rdbEVANR.Checked = true;
        }

        private BackgroundWorker worker = new BackgroundWorker();
        private string dirCSV = @"C:\Temp\Haltestellen.csv";
        private string dirDB = @"C:\Temp\HaltestellenDB.accdb";

        private void UpdateBindingDataSource()
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + dirDB))
            {
                con.Open();
                string cmdStr = "select * from D_Bahnhof_2016_01_alle_CSharpImport";
                OleDbDataAdapter da = new OleDbDataAdapter(cmdStr, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHaltestellen.DataSource = dt;
            }
        }
        private void btnDatenladen_Click(object sender, EventArgs e)
        {
            dgvHaltestellen.Rows.Clear();
            dgvHaltestellen.Columns.Clear();

            dgvHaltestellen.RowsDefaultCellStyle.BackColor = Color.LightCoral;
            dgvHaltestellen.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvHaltestellen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHaltestellen.AllowUserToAddRows = false;

            dgvHaltestellen.Columns.Add("SpNR", "EVA_NR");
            dgvHaltestellen.Columns.Add("SpName", "Name");
            dgvHaltestellen.Columns.Add("SpLaenge", "Laenge");
            dgvHaltestellen.Columns.Add("SpBreite", "Breite");

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd1 = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();

            OleDbDataReader reader;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + dirDB;

            cmd1.Connection = con;
            cmd1.CommandText = "select distinct eva_nr, name, laenge, breite from D_Bahnhof_2016_01_alle_CSharpImport";

            int cntCells = 0;
            cmd2.Connection = con;
            cmd2.CommandText = "select count(*) from D_Bahnhof_2016_01_alle_CSharpImport";

            try
            {
                con.Open();
                cntCells = (int)cmd2.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int cnt = 0;

            try
            {
                con.Open();
                reader = cmd1.ExecuteReader();
                btnDatenladen.Enabled = false;

                while (reader.Read())
                {
                    int nr = (int)reader["EVA_NR"];
                    string name = reader["Name"].ToString();
                    double laenge = (double)reader["Laenge"];
                    double breite = (double)reader["Breite"];

                    dgvHaltestellen.Rows.Add(nr, name, laenge, breite);
                    prgbLoad.Value = (int)(cnt + 1) * 100 / cntCells; 
                    lblProgress.Text = prgbLoad.Value.ToString() + "%";
                    lblProgress.Refresh();
                    cnt++;
                    dgvHaltestellen.Update();
                }

                if (prgbLoad.Value == 100)
                {
                    DialogResult res = MessageBox.Show("Datei geladen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        dgvHaltestellen.Refresh();
                        btnDatenladen.Enabled = true;
                        prgbLoad.Value = 0;
                    }
                    lblProgress.Text = prgbLoad.Value.ToString() + "%";
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmHaltestellenDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHauptmenue fHM = new frmHauptmenue();
            fHM.Show();
        }

        private void btnHaltestellenDBSchreiben_Click(object sender, EventArgs e)
        {
            string[] values = File.ReadAllLines(dirCSV);
            List<HaltestellenDaten> data = new List<HaltestellenDaten>();
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd1 = new OleDbCommand();
            OleDbCommand cmd2 = new OleDbCommand();
            btnHaltestellenDBSchreiben.Enabled = false;

            int cntCells = 0;

            foreach (string line in values.Skip(1))
            {
                var splittedLine = line.Split(';');
                int nr = Int32.Parse(splittedLine[0]);
                string name = splittedLine[2];
                double laenge = Double.Parse(splittedLine[4], System.Globalization.CultureInfo.InvariantCulture);
                double breite = Double.Parse(splittedLine[5], System.Globalization.CultureInfo.InvariantCulture);

                HaltestellenDaten hlt = new HaltestellenDaten(nr, name, laenge, breite);
                data.Add(hlt);
                cntCells++;
            }

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                    "Data Source=" + dirDB;
            cmd1.Connection = con;
            cmd2.Connection = con;

            int cnt = 0;

            try
            {
                con.Open();
                cmd1.CommandText = "delete * from D_Bahnhof_2016_01_alle_CSharpImport";
                cmd1.ExecuteNonQuery();

                foreach (HaltestellenDaten hlt in data)
                {
                    cmd2.CommandText = "insert into D_Bahnhof_2016_01_alle_CSharpImport" +
                    "(eva_nr, name, laenge, breite) values(" +
                    "'" + hlt.NR + "'," +
                    "'" + hlt.Name + "'," +
                    "'" + hlt.Laenge + "'," +
                    "'" + hlt.Breite + "')";
                    cmd2.ExecuteNonQuery();
                    prgbLoad.Value = (int)(cnt + 1) * 100 / cntCells;
                    lblProgress.Text = prgbLoad.Value.ToString() + "%";
                    lblProgress.Refresh();
                    cnt++;
                }
                if (prgbLoad.Value == 100)
                {
                    DialogResult res = MessageBox.Show("Daten wurden in DB gespeichert.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    prgbLoad.Value = 0;
                    lblProgress.Text = prgbLoad.Value.ToString() + "%";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                con.Close();
            }
            btnHaltestellenDBSchreiben.Enabled = true;
        }

        private void btnSortierenAufst_Click(object sender, EventArgs e)
        {
            btnSortierenAufst.Enabled = false;
            dgvHaltestellen.Sort(new GridSort(SortOrder.Ascending, rdbEVANR.Checked ? 0 : 1));
            btnSortierenAufst.Enabled = true;
        }

        private void btnSortiereAbst_Click(object sender, EventArgs e)
        {
            btnSortierenAufst.Enabled = false;
            dgvHaltestellen.Sort(new GridSort(SortOrder.Descending, rdbEVANR.Checked ? 0 : 1));
            btnSortierenAufst.Enabled = true;
        }
    }
}
