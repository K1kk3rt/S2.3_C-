namespace opdracht_1
{
    partial class Machinist
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
            this.btn_stationBereikt = new System.Windows.Forms.Button();
            this.btn_terugreisBegint = new System.Windows.Forms.Button();
            this.btn_nieuweTrein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stationBereikt
            // 
            this.btn_stationBereikt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stationBereikt.Location = new System.Drawing.Point(191, 12);
            this.btn_stationBereikt.Name = "btn_stationBereikt";
            this.btn_stationBereikt.Size = new System.Drawing.Size(173, 69);
            this.btn_stationBereikt.TabIndex = 0;
            this.btn_stationBereikt.Text = "Station Bereikt";
            this.btn_stationBereikt.UseVisualStyleBackColor = true;
            // 
            // btn_terugreisBegint
            // 
            this.btn_terugreisBegint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terugreisBegint.Location = new System.Drawing.Point(12, 12);
            this.btn_terugreisBegint.Name = "btn_terugreisBegint";
            this.btn_terugreisBegint.Size = new System.Drawing.Size(173, 69);
            this.btn_terugreisBegint.TabIndex = 1;
            this.btn_terugreisBegint.Text = "Terug Reis";
            this.btn_terugreisBegint.UseVisualStyleBackColor = true;
            // 
            // btn_nieuweTrein
            // 
            this.btn_nieuweTrein.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nieuweTrein.Location = new System.Drawing.Point(12, 123);
            this.btn_nieuweTrein.Name = "btn_nieuweTrein";
            this.btn_nieuweTrein.Size = new System.Drawing.Size(173, 37);
            this.btn_nieuweTrein.TabIndex = 2;
            this.btn_nieuweTrein.Text = "Nieuwe trein";
            this.btn_nieuweTrein.UseVisualStyleBackColor = true;
            this.btn_nieuweTrein.Click += new System.EventHandler(this.btn_nieuweTrein_Click);
            // 
            // Machinist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 172);
            this.Controls.Add(this.btn_nieuweTrein);
            this.Controls.Add(this.btn_terugreisBegint);
            this.Controls.Add(this.btn_stationBereikt);
            this.Name = "Machinist";
            this.Text = "Machinist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stationBereikt;
        private System.Windows.Forms.Button btn_terugreisBegint;
        private System.Windows.Forms.Button btn_nieuweTrein;
    }
}

