namespace week3_v2
{
    partial class TreinDisplay
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
            this.lbl_huidigStation = new System.Windows.Forms.Label();
            this.lbl_spoor = new System.Windows.Forms.Label();
            this.lbl_aankomstTijd = new System.Windows.Forms.Label();
            this.lbl_huidigStationText = new System.Windows.Forms.Label();
            this.lbl_spoorText = new System.Windows.Forms.Label();
            this.lbl_aankomstTijdText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_huidigStation
            // 
            this.lbl_huidigStation.AutoSize = true;
            this.lbl_huidigStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_huidigStation.Location = new System.Drawing.Point(12, 9);
            this.lbl_huidigStation.Name = "lbl_huidigStation";
            this.lbl_huidigStation.Size = new System.Drawing.Size(128, 24);
            this.lbl_huidigStation.TabIndex = 0;
            this.lbl_huidigStation.Text = "Huidig station:";
            // 
            // lbl_spoor
            // 
            this.lbl_spoor.AutoSize = true;
            this.lbl_spoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spoor.Location = new System.Drawing.Point(12, 51);
            this.lbl_spoor.Name = "lbl_spoor";
            this.lbl_spoor.Size = new System.Drawing.Size(66, 24);
            this.lbl_spoor.TabIndex = 1;
            this.lbl_spoor.Text = "Spoor:";
            // 
            // lbl_aankomstTijd
            // 
            this.lbl_aankomstTijd.AutoSize = true;
            this.lbl_aankomstTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aankomstTijd.Location = new System.Drawing.Point(12, 102);
            this.lbl_aankomstTijd.Name = "lbl_aankomstTijd";
            this.lbl_aankomstTijd.Size = new System.Drawing.Size(121, 24);
            this.lbl_aankomstTijd.TabIndex = 2;
            this.lbl_aankomstTijd.Text = "Aankomsttijd:";
            this.lbl_aankomstTijd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_huidigStationText
            // 
            this.lbl_huidigStationText.AutoSize = true;
            this.lbl_huidigStationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_huidigStationText.Location = new System.Drawing.Point(196, 9);
            this.lbl_huidigStationText.Name = "lbl_huidigStationText";
            this.lbl_huidigStationText.Size = new System.Drawing.Size(16, 24);
            this.lbl_huidigStationText.TabIndex = 3;
            this.lbl_huidigStationText.Text = "-";
            // 
            // lbl_spoorText
            // 
            this.lbl_spoorText.AutoSize = true;
            this.lbl_spoorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spoorText.Location = new System.Drawing.Point(196, 51);
            this.lbl_spoorText.Name = "lbl_spoorText";
            this.lbl_spoorText.Size = new System.Drawing.Size(16, 24);
            this.lbl_spoorText.TabIndex = 4;
            this.lbl_spoorText.Text = "-";
            // 
            // lbl_aankomstTijdText
            // 
            this.lbl_aankomstTijdText.AutoSize = true;
            this.lbl_aankomstTijdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aankomstTijdText.Location = new System.Drawing.Point(196, 102);
            this.lbl_aankomstTijdText.Name = "lbl_aankomstTijdText";
            this.lbl_aankomstTijdText.Size = new System.Drawing.Size(16, 24);
            this.lbl_aankomstTijdText.TabIndex = 5;
            this.lbl_aankomstTijdText.Text = "-";
            // 
            // TreinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 138);
            this.Controls.Add(this.lbl_aankomstTijdText);
            this.Controls.Add(this.lbl_spoorText);
            this.Controls.Add(this.lbl_huidigStationText);
            this.Controls.Add(this.lbl_aankomstTijd);
            this.Controls.Add(this.lbl_spoor);
            this.Controls.Add(this.lbl_huidigStation);
            this.Name = "TreinDisplay";
            this.Text = "TreinDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_huidigStation;
        private System.Windows.Forms.Label lbl_spoor;
        private System.Windows.Forms.Label lbl_aankomstTijd;
        private System.Windows.Forms.Label lbl_huidigStationText;
        private System.Windows.Forms.Label lbl_spoorText;
        private System.Windows.Forms.Label lbl_aankomstTijdText;
    }
}