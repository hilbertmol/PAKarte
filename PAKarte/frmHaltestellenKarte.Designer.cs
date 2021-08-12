
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
            this.btnCSVLaden = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.prgbLoad = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnZeichnen = new System.Windows.Forms.Button();
            this.btnZurück = new System.Windows.Forms.Button();
            this.lblUeberschriftKarte = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.panKarte = new System.Windows.Forms.Panel();
            this.lblXY = new System.Windows.Forms.Label();
            this.lblNameHbf = new System.Windows.Forms.Label();
            this.panSonstige = new System.Windows.Forms.Panel();
            this.panHbf = new System.Windows.Forms.Panel();
            this.lblSonstige = new System.Windows.Forms.Label();
            this.lblHbf = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblXAnz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYAnz = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCSVLaden
            // 
            this.btnCSVLaden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVLaden.Location = new System.Drawing.Point(880, 802);
            this.btnCSVLaden.Name = "btnCSVLaden";
            this.btnCSVLaden.Size = new System.Drawing.Size(166, 53);
            this.btnCSVLaden.TabIndex = 5;
            this.btnCSVLaden.Text = "CSV laden";
            this.btnCSVLaden.UseVisualStyleBackColor = true;
            this.btnCSVLaden.Click += new System.EventHandler(this.btnCSVLaden_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(880, 76);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtA.Size = new System.Drawing.Size(699, 588);
            this.txtA.TabIndex = 6;
            // 
            // prgbLoad
            // 
            this.prgbLoad.Location = new System.Drawing.Point(880, 682);
            this.prgbLoad.Name = "prgbLoad";
            this.prgbLoad.Size = new System.Drawing.Size(589, 48);
            this.prgbLoad.TabIndex = 7;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(1176, 745);
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
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(222, 802);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(166, 53);
            this.btnSpeichern.TabIndex = 56;
            this.btnSpeichern.Text = "Bild Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // panKarte
            // 
            this.panKarte.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panKarte.Location = new System.Drawing.Point(32, 76);
            this.panKarte.Margin = new System.Windows.Forms.Padding(0);
            this.panKarte.Name = "panKarte";
            this.panKarte.Size = new System.Drawing.Size(605, 711);
            this.panKarte.TabIndex = 57;
            this.panKarte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panKarte_MouseMove);
            // 
            // lblXY
            // 
            this.lblXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXY.Location = new System.Drawing.Point(658, 106);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(196, 35);
            this.lblXY.TabIndex = 58;
            this.lblXY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameHbf
            // 
            this.lblNameHbf.AutoSize = true;
            this.lblNameHbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHbf.Location = new System.Drawing.Point(655, 76);
            this.lblNameHbf.Name = "lblNameHbf";
            this.lblNameHbf.Size = new System.Drawing.Size(172, 20);
            this.lblNameHbf.TabIndex = 59;
            this.lblNameHbf.Text = "Der ausgewählte Hbf:";
            // 
            // panSonstige
            // 
            this.panSonstige.BackColor = System.Drawing.Color.Black;
            this.panSonstige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSonstige.Location = new System.Drawing.Point(490, 833);
            this.panSonstige.Name = "panSonstige";
            this.panSonstige.Size = new System.Drawing.Size(10, 10);
            this.panSonstige.TabIndex = 60;
            // 
            // panHbf
            // 
            this.panHbf.BackColor = System.Drawing.Color.Yellow;
            this.panHbf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panHbf.Location = new System.Drawing.Point(490, 806);
            this.panHbf.Name = "panHbf";
            this.panHbf.Size = new System.Drawing.Size(10, 10);
            this.panHbf.TabIndex = 61;
            // 
            // lblSonstige
            // 
            this.lblSonstige.AutoSize = true;
            this.lblSonstige.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonstige.Location = new System.Drawing.Point(509, 829);
            this.lblSonstige.Name = "lblSonstige";
            this.lblSonstige.Size = new System.Drawing.Size(128, 17);
            this.lblSonstige.TabIndex = 62;
            this.lblSonstige.Text = "Sonstige Bahnhöfe";
            // 
            // lblHbf
            // 
            this.lblHbf.AutoSize = true;
            this.lblHbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHbf.Location = new System.Drawing.Point(509, 802);
            this.lblHbf.Name = "lblHbf";
            this.lblHbf.Size = new System.Drawing.Size(106, 17);
            this.lblHbf.TabIndex = 63;
            this.lblHbf.Text = "Hauptbahnhöfe";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(655, 211);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 20);
            this.lblX.TabIndex = 64;
            this.lblX.Text = "X:";
            // 
            // lblXAnz
            // 
            this.lblXAnz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXAnz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXAnz.Location = new System.Drawing.Point(686, 204);
            this.lblXAnz.Name = "lblXAnz";
            this.lblXAnz.Size = new System.Drawing.Size(137, 35);
            this.lblXAnz.TabIndex = 65;
            this.lblXAnz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Koordinaten:";
            // 
            // lblYAnz
            // 
            this.lblYAnz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYAnz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYAnz.Location = new System.Drawing.Point(686, 254);
            this.lblYAnz.Name = "lblYAnz";
            this.lblYAnz.Size = new System.Drawing.Size(137, 35);
            this.lblYAnz.TabIndex = 68;
            this.lblYAnz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(655, 261);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(30, 25);
            this.lblY.TabIndex = 67;
            this.lblY.Text = "Y:";
            // 
            // frmHaltestellenKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 873);
            this.Controls.Add(this.lblYAnz);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblXAnz);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblHbf);
            this.Controls.Add(this.lblSonstige);
            this.Controls.Add(this.panHbf);
            this.Controls.Add(this.panSonstige);
            this.Controls.Add(this.lblNameHbf);
            this.Controls.Add(this.lblXY);
            this.Controls.Add(this.panKarte);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.lblUeberschriftKarte);
            this.Controls.Add(this.btnZurück);
            this.Controls.Add(this.btnZeichnen);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prgbLoad);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnCSVLaden);
            this.Name = "frmHaltestellenKarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karte Haltestellen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHaltestellenKarte_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCSVLaden;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.ProgressBar prgbLoad;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnZeichnen;
        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.Label lblUeberschriftKarte;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Panel panKarte;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.Label lblNameHbf;
        private System.Windows.Forms.Panel panSonstige;
        private System.Windows.Forms.Panel panHbf;
        private System.Windows.Forms.Label lblSonstige;
        private System.Windows.Forms.Label lblHbf;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblXAnz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYAnz;
        private System.Windows.Forms.Label lblY;
    }
}