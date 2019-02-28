namespace week3_v2
{
    partial class Controller
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
            this.btn_naarVolgendStation = new System.Windows.Forms.Button();
            this.btn_eindStationBereikt = new System.Windows.Forms.Button();
            this.btn_nieuweTrein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_naarVolgendStation
            // 
            this.btn_naarVolgendStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_naarVolgendStation.Location = new System.Drawing.Point(22, 12);
            this.btn_naarVolgendStation.Name = "btn_naarVolgendStation";
            this.btn_naarVolgendStation.Size = new System.Drawing.Size(147, 70);
            this.btn_naarVolgendStation.TabIndex = 0;
            this.btn_naarVolgendStation.Text = "Naar volgend station";
            this.btn_naarVolgendStation.UseVisualStyleBackColor = true;
            this.btn_naarVolgendStation.Click += new System.EventHandler(this.btn_naarVolgendStation_Click);
            // 
            // btn_eindStationBereikt
            // 
            this.btn_eindStationBereikt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eindStationBereikt.Location = new System.Drawing.Point(187, 12);
            this.btn_eindStationBereikt.Name = "btn_eindStationBereikt";
            this.btn_eindStationBereikt.Size = new System.Drawing.Size(147, 70);
            this.btn_eindStationBereikt.TabIndex = 1;
            this.btn_eindStationBereikt.Text = "Eindstation bereikt";
            this.btn_eindStationBereikt.UseVisualStyleBackColor = true;
            this.btn_eindStationBereikt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nieuweTrein
            // 
            this.btn_nieuweTrein.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nieuweTrein.Location = new System.Drawing.Point(22, 131);
            this.btn_nieuweTrein.Name = "btn_nieuweTrein";
            this.btn_nieuweTrein.Size = new System.Drawing.Size(147, 33);
            this.btn_nieuweTrein.TabIndex = 2;
            this.btn_nieuweTrein.Text = "Nieuwe trein";
            this.btn_nieuweTrein.UseVisualStyleBackColor = true;
            this.btn_nieuweTrein.Click += new System.EventHandler(this.btn_nieuweTrein_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 174);
            this.Controls.Add(this.btn_nieuweTrein);
            this.Controls.Add(this.btn_eindStationBereikt);
            this.Controls.Add(this.btn_naarVolgendStation);
            this.Name = "Controller";
            this.Text = "Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_naarVolgendStation;
        private System.Windows.Forms.Button btn_eindStationBereikt;
        private System.Windows.Forms.Button btn_nieuweTrein;
    }
}

