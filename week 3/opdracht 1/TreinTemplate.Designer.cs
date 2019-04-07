namespace opdracht_1
{
    public partial class TreinTemplate : ITreinDisplay
    {
        Treinreis treinreis;
        TreinController treinController;

        //construct
        public TreinTemplate()
        {

            treinreis = new Treinreis(this);
            treinController = new TreinController(treinreis);

            InitializeComponent();
        }

        //implement interface
        public void Update(Station station)
        {

            //TreinTemplate treinTemplate = new TreinTemplate();
            //treinTemplate.lbl_huidigStation.Text = "Huidig station";

            lbl_huidigStation.Text = station.Naam;
            //lbl_spoor.Text = station.AankomstSpoor;
        }

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
            this.lbl_textHuidigStation = new System.Windows.Forms.Label();
            this.lbl_textSpoor = new System.Windows.Forms.Label();
            this.lbl_huidigStation = new System.Windows.Forms.Label();
            this.lbl_spoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_textHuidigStation
            // 
            this.lbl_textHuidigStation.AutoSize = true;
            this.lbl_textHuidigStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textHuidigStation.Location = new System.Drawing.Point(12, 9);
            this.lbl_textHuidigStation.Name = "lbl_textHuidigStation";
            this.lbl_textHuidigStation.Size = new System.Drawing.Size(175, 29);
            this.lbl_textHuidigStation.TabIndex = 0;
            this.lbl_textHuidigStation.Text = "Huidig Stattion:";
            this.lbl_textHuidigStation.Click += new System.EventHandler(this.lbl_textHuidigStation_Click);
            // 
            // lbl_textSpoor
            // 
            this.lbl_textSpoor.AutoSize = true;
            this.lbl_textSpoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textSpoor.Location = new System.Drawing.Point(12, 55);
            this.lbl_textSpoor.Name = "lbl_textSpoor";
            this.lbl_textSpoor.Size = new System.Drawing.Size(85, 29);
            this.lbl_textSpoor.TabIndex = 1;
            this.lbl_textSpoor.Text = "Spoor:";
            this.lbl_textSpoor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_huidigStation
            // 
            this.lbl_huidigStation.AutoSize = true;
            this.lbl_huidigStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_huidigStation.Location = new System.Drawing.Point(193, 9);
            this.lbl_huidigStation.Name = "lbl_huidigStation";
            this.lbl_huidigStation.Size = new System.Drawing.Size(21, 29);
            this.lbl_huidigStation.TabIndex = 2;
            this.lbl_huidigStation.Text = "-";
            // 
            // lbl_spoor
            // 
            this.lbl_spoor.AutoSize = true;
            this.lbl_spoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spoor.Location = new System.Drawing.Point(193, 55);
            this.lbl_spoor.Name = "lbl_spoor";
            this.lbl_spoor.Size = new System.Drawing.Size(21, 29);
            this.lbl_spoor.TabIndex = 3;
            this.lbl_spoor.Text = "-";
            // 
            // TreinTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 118);
            this.Controls.Add(this.lbl_spoor);
            this.Controls.Add(this.lbl_huidigStation);
            this.Controls.Add(this.lbl_textSpoor);
            this.Controls.Add(this.lbl_textHuidigStation);
            this.Name = "TreinTemplate";
            this.Text = "Trein";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textHuidigStation;
        private System.Windows.Forms.Label lbl_textSpoor;
        public System.Windows.Forms.Label lbl_huidigStation;
        public System.Windows.Forms.Label lbl_spoor;
    }
}