
namespace PAKarte
{
    partial class frmHaltestellenKarte
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCSVLaden = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.prgbLoad = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnZeichnen = new System.Windows.Forms.Button();
            this.btnZurück = new System.Windows.Forms.Button();
            this.lblUeberschriftKarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(32, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 699);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCSVLaden
            // 
            this.btnCSVLaden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVLaden.Location = new System.Drawing.Point(657, 802);
            this.btnCSVLaden.Name = "btnCSVLaden";
            this.btnCSVLaden.Size = new System.Drawing.Size(166, 53);
            this.btnCSVLaden.TabIndex = 5;
            this.btnCSVLaden.Text = "CSV laden";
            this.btnCSVLaden.UseVisualStyleBackColor = true;
            this.btnCSVLaden.Click += new System.EventHandler(this.btnCSVLaden_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(657, 76);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtA.Size = new System.Drawing.Size(922, 588);
            this.txtA.TabIndex = 6;
            // 
            // prgbLoad
            // 
            this.prgbLoad.Location = new System.Drawing.Point(657, 682);
            this.prgbLoad.Name = "prgbLoad";
            this.prgbLoad.Size = new System.Drawing.Size(589, 48);
            this.prgbLoad.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(949, 745);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 20);
            this.lblProgress.TabIndex = 8;
            // 
            // btnZeichnen
            // 
            this.btnZeichnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeichnen.Location = new System.Drawing.Point(32, 802);
            this.btnZeichnen.Name = "btnZeichnen";
            this.btnZeichnen.Size = new System.Drawing.Size(166, 53);
            this.btnZeichnen.TabIndex = 9;
            this.btnZeichnen.Text = "Zeichnen";
            this.btnZeichnen.UseVisualStyleBackColor = true;
            this.btnZeichnen.Click += new System.EventHandler(this.btnZeichnen_Click);
            // 
            // btnZurück
            // 
            this.btnZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZurück.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZurück.Location = new System.Drawing.Point(1419, 802);
            this.btnZurück.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(160, 53);
            this.btnZurück.TabIndex = 54;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // lblUeberschriftKarte
            // 
            this.lblUeberschriftKarte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUeberschriftKarte.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftKarte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftKarte.Location = new System.Drawing.Point(0, 9);
            this.lblUeberschriftKarte.Name = "lblUeberschriftKarte";
            this.lblUeberschriftKarte.Size = new System.Drawing.Size(1610, 49);
            this.lblUeberschriftKarte.TabIndex = 55;
            this.lblUeberschriftKarte.Text = "Karte";
            this.lblUeberschriftKarte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmHaltestellenKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 873);
            this.Controls.Add(this.lblUeberschriftKarte);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.btnZeichnen);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prgbLoad);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnCSVLaden);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmHaltestellenKarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karte Haltestellen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHaltestellenKarte_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCSVLaden;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.ProgressBar prgbLoad;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnZeichnen;
        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.Label lblUeberschriftKarte;
    }
}