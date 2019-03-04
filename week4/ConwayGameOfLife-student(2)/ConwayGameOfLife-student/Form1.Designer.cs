namespace ConwayGameOfLife
{
  partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btn_StandardLife = new System.Windows.Forms.Button();
            this.btn_HighLife = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(16, 864);
            this.btnResetGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(188, 46);
            this.btnResetGame.TabIndex = 0;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_StandardLife
            // 
            this.btn_StandardLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StandardLife.Location = new System.Drawing.Point(294, 865);
            this.btn_StandardLife.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StandardLife.Name = "btn_StandardLife";
            this.btn_StandardLife.Size = new System.Drawing.Size(188, 46);
            this.btn_StandardLife.TabIndex = 1;
            this.btn_StandardLife.Text = "Standard Life";
            this.btn_StandardLife.UseVisualStyleBackColor = true;
            this.btn_StandardLife.Click += new System.EventHandler(this.btn_StandardLife_Click);
            // 
            // btn_HighLife
            // 
            this.btn_HighLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HighLife.Location = new System.Drawing.Point(490, 864);
            this.btn_HighLife.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HighLife.Name = "btn_HighLife";
            this.btn_HighLife.Size = new System.Drawing.Size(188, 46);
            this.btn_HighLife.TabIndex = 2;
            this.btn_HighLife.Text = "High Life";
            this.btn_HighLife.UseVisualStyleBackColor = true;
            this.btn_HighLife.Click += new System.EventHandler(this.btn_HighLife_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 924);
            this.Controls.Add(this.btn_HighLife);
            this.Controls.Add(this.btn_StandardLife);
            this.Controls.Add(this.btnResetGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Conway\'s Game Of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btn_StandardLife;
        private System.Windows.Forms.Button btn_HighLife;
    }
}

