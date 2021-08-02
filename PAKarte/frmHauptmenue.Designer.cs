
namespace PAKarte
{
    partial class frmHauptmenue
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
            this.lblUeberschriftProdukte = new System.Windows.Forms.Label();
            this.btnUebersicht = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHaltestellenCSV = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUeberschriftProdukte
            // 
            this.lblUeberschriftProdukte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUeberschriftProdukte.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUeberschriftProdukte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUeberschriftProdukte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUeberschriftProdukte.Location = new System.Drawing.Point(1, 19);
            this.lblUeberschriftProdukte.Name = "lblUeberschriftProdukte";
            this.lblUeberschriftProdukte.Size = new System.Drawing.Size(704, 49);
            this.lblUeberschriftProdukte.TabIndex = 49;
            this.lblUeberschriftProdukte.Text = "Hauptmenü";
            this.lblUeberschriftProdukte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUebersicht
            // 
            this.btnUebersicht.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUebersicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUebersicht.Location = new System.Drawing.Point(214, 164);
            this.btnUebersicht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUebersicht.Name = "btnUebersicht";
            this.btnUebersicht.Size = new System.Drawing.Size(249, 37);
            this.btnUebersicht.TabIndex = 50;
            this.btnUebersicht.Text = "Karte Haltestellen";
            this.btnUebersicht.UseVisualStyleBackColor = true;
            this.btnUebersicht.Click += new System.EventHandler(this.btnKarteHaltestellen_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 37);
            this.button1.TabIndex = 51;
            this.button1.Text = "Haltestellen DGV aus DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHaltestellenDB);
            // 
            // btnHaltestellenCSV
            // 
            this.btnHaltestellenCSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHaltestellenCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaltestellenCSV.Location = new System.Drawing.Point(214, 294);
            this.btnHaltestellenCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHaltestellenCSV.Name = "btnHaltestellenCSV";
            this.btnHaltestellenCSV.Size = new System.Drawing.Size(249, 37);
            this.btnHaltestellenCSV.TabIndex = 52;
            this.btnHaltestellenCSV.Text = "Haltestellen DGV aus CSV";
            this.btnHaltestellenCSV.UseVisualStyleBackColor = true;
            this.btnHaltestellenCSV.Click += new System.EventHandler(this.btnHaltestellenArray_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeenden.Location = new System.Drawing.Point(214, 358);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(249, 37);
            this.btnBeenden.TabIndex = 54;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // frmHauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 549);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnHaltestellenCSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUebersicht);
            this.Controls.Add(this.lblUeberschriftProdukte);
            this.Name = "frmHauptmenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHauptmenue_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUeberschriftProdukte;
        private System.Windows.Forms.Button btnUebersicht;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHaltestellenCSV;
        private System.Windows.Forms.Button btnBeenden;
    }
}