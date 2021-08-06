
namespace PAKarte
{
    partial class frmHaltestellenCSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZurück = new System.Windows.Forms.Button();
            this.dgvHaltestellen = new System.Windows.Forms.DataGridView();
            this.lblUeberschriftHaltestellen = new System.Windows.Forms.Label();
            this.btnDatenladen = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.prgbLoad = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaltestellen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZurück
            // 
            this.btnZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurück.Location = new System.Drawing.Point(1409, 799);
            this.btnZurück.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(160, 53);
            this.btnZurück.TabIndex = 55;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // dgvHaltestellen
            // 
            this.dgvHaltestellen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHaltestellen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaltestellen.Location = new System.Drawing.Point(37, 108);
            this.dgvHaltestellen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHaltestellen.MultiSelect = false;
            this.dgvHaltestellen.Name = "dgvHaltestellen";
            this.dgvHaltestellen.RowHeadersWidth = 51;
            this.dgvHaltestellen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHaltestellen.Size = new System.Drawing.Size(1247, 527);
            this.dgvHaltestellen.TabIndex = 56;
            // 
            // lblUeberschriftHaltestellen
            // 
            this.lblUeberschriftHaltestellen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUeberschriftHaltestellen.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftHaltestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftHaltestellen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftHaltestellen.Location = new System.Drawing.Point(0, 19);
            this.lblUeberschriftHaltestellen.Name = "lblUeberschriftHaltestellen";
            this.lblUeberschriftHaltestellen.Size = new System.Drawing.Size(1610, 49);
            this.lblUeberschriftHaltestellen.TabIndex = 57;
            this.lblUeberschriftHaltestellen.Text = "Haltestellen CSV Datei";
            this.lblUeberschriftHaltestellen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDatenladen
            // 
            this.btnDatenladen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDatenladen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenladen.Location = new System.Drawing.Point(37, 799);
            this.btnDatenladen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatenladen.Name = "btnDatenladen";
            this.btnDatenladen.Size = new System.Drawing.Size(160, 53);
            this.btnDatenladen.TabIndex = 58;
            this.btnDatenladen.Text = "Daten laden";
            this.btnDatenladen.UseVisualStyleBackColor = true;
            this.btnDatenladen.Click += new System.EventHandler(this.btnDatenladen_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(327, 730);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 20);
            this.lblProgress.TabIndex = 68;
            // 
            // prgbLoad
            // 
            this.prgbLoad.Location = new System.Drawing.Point(37, 668);
            this.prgbLoad.Name = "prgbLoad";
            this.prgbLoad.Size = new System.Drawing.Size(589, 48);
            this.prgbLoad.TabIndex = 67;
            // 
            // frmHaltestellenCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 873);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prgbLoad);
            this.Controls.Add(this.btnDatenladen);
            this.Controls.Add(this.lblUeberschriftHaltestellen);
            this.Controls.Add(this.dgvHaltestellen);
            this.Controls.Add(this.btnZurück);
            this.Name = "frmHaltestellenCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haltestellen CSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHaltestellenCSV_FormClosing);
            this.Load += new System.EventHandler(this.frmHaltestellenDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaltestellen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.DataGridView dgvHaltestellen;
        private System.Windows.Forms.Label lblUeberschriftHaltestellen;
        private System.Windows.Forms.Button btnDatenladen;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar prgbLoad;
    }
}