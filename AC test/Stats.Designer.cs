
namespace AC_test
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.KillsText = new System.Windows.Forms.Label();
            this.StatsText = new System.Windows.Forms.Label();
            this.StatsTimer = new System.Windows.Forms.Timer(this.components);
            this.DeathsText = new System.Windows.Forms.Label();
            this.KDText = new System.Windows.Forms.Label();
            this.VictoriasText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DerrotasText = new System.Windows.Forms.Label();
            this.WinRateText = new System.Windows.Forms.Label();
            this.MMRText = new System.Windows.Forms.Label();
            this.RankText = new System.Windows.Forms.Label();
            this.RankImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RankImage)).BeginInit();
            this.SuspendLayout();
            // 
            // KillsText
            // 
            this.KillsText.AutoSize = true;
            this.KillsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillsText.ForeColor = System.Drawing.Color.Snow;
            this.KillsText.Location = new System.Drawing.Point(12, 50);
            this.KillsText.Name = "KillsText";
            this.KillsText.Size = new System.Drawing.Size(44, 20);
            this.KillsText.TabIndex = 1;
            this.KillsText.Text = "Kills: ";
            // 
            // StatsText
            // 
            this.StatsText.AutoSize = true;
            this.StatsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsText.ForeColor = System.Drawing.Color.Snow;
            this.StatsText.Location = new System.Drawing.Point(139, 18);
            this.StatsText.Name = "StatsText";
            this.StatsText.Size = new System.Drawing.Size(62, 25);
            this.StatsText.TabIndex = 2;
            this.StatsText.Text = "Stats";
            // 
            // StatsTimer
            // 
            this.StatsTimer.Enabled = true;
            this.StatsTimer.Interval = 1000;
            this.StatsTimer.Tick += new System.EventHandler(this.StatsTimer_Tick);
            // 
            // DeathsText
            // 
            this.DeathsText.AutoSize = true;
            this.DeathsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathsText.ForeColor = System.Drawing.SystemColors.Window;
            this.DeathsText.Location = new System.Drawing.Point(13, 87);
            this.DeathsText.Name = "DeathsText";
            this.DeathsText.Size = new System.Drawing.Size(65, 20);
            this.DeathsText.TabIndex = 3;
            this.DeathsText.Text = "Deaths:";
            // 
            // KDText
            // 
            this.KDText.AutoSize = true;
            this.KDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KDText.ForeColor = System.Drawing.Color.SeaShell;
            this.KDText.Location = new System.Drawing.Point(14, 130);
            this.KDText.Name = "KDText";
            this.KDText.Size = new System.Drawing.Size(39, 20);
            this.KDText.TabIndex = 4;
            this.KDText.Text = "KD: ";
            // 
            // VictoriasText
            // 
            this.VictoriasText.AutoSize = true;
            this.VictoriasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictoriasText.ForeColor = System.Drawing.SystemColors.Control;
            this.VictoriasText.Location = new System.Drawing.Point(12, 172);
            this.VictoriasText.Name = "VictoriasText";
            this.VictoriasText.Size = new System.Drawing.Size(74, 20);
            this.VictoriasText.TabIndex = 5;
            this.VictoriasText.Text = "Victorias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // DerrotasText
            // 
            this.DerrotasText.AutoSize = true;
            this.DerrotasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DerrotasText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DerrotasText.Location = new System.Drawing.Point(11, 219);
            this.DerrotasText.Name = "DerrotasText";
            this.DerrotasText.Size = new System.Drawing.Size(75, 20);
            this.DerrotasText.TabIndex = 7;
            this.DerrotasText.Text = "Derrotas:";
            // 
            // WinRateText
            // 
            this.WinRateText.AutoSize = true;
            this.WinRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinRateText.ForeColor = System.Drawing.Color.Snow;
            this.WinRateText.Location = new System.Drawing.Point(11, 261);
            this.WinRateText.Name = "WinRateText";
            this.WinRateText.Size = new System.Drawing.Size(79, 20);
            this.WinRateText.TabIndex = 8;
            this.WinRateText.Text = "WinRate: ";
            // 
            // MMRText
            // 
            this.MMRText.AutoSize = true;
            this.MMRText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMRText.ForeColor = System.Drawing.Color.Snow;
            this.MMRText.Location = new System.Drawing.Point(128, 468);
            this.MMRText.Name = "MMRText";
            this.MMRText.Size = new System.Drawing.Size(55, 20);
            this.MMRText.TabIndex = 9;
            this.MMRText.Text = "MMR: ";
            // 
            // RankText
            // 
            this.RankText.AutoSize = true;
            this.RankText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankText.ForeColor = System.Drawing.Color.Snow;
            this.RankText.Location = new System.Drawing.Point(139, 420);
            this.RankText.Name = "RankText";
            this.RankText.Size = new System.Drawing.Size(69, 25);
            this.RankText.TabIndex = 10;
            this.RankText.Text = "Rango";
            // 
            // RankImage
            // 
            this.RankImage.Image = global::AC_test.Properties.Resources.Bronze_1;
            this.RankImage.InitialImage = global::AC_test.Properties.Resources.Bronze_1;
            this.RankImage.Location = new System.Drawing.Point(122, 281);
            this.RankImage.Name = "RankImage";
            this.RankImage.Size = new System.Drawing.Size(100, 136);
            this.RankImage.TabIndex = 11;
            this.RankImage.TabStop = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(371, 517);
            this.Controls.Add(this.RankImage);
            this.Controls.Add(this.RankText);
            this.Controls.Add(this.MMRText);
            this.Controls.Add(this.WinRateText);
            this.Controls.Add(this.DerrotasText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VictoriasText);
            this.Controls.Add(this.KDText);
            this.Controls.Add(this.DeathsText);
            this.Controls.Add(this.StatsText);
            this.Controls.Add(this.KillsText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.RankImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatsText;
        public System.Windows.Forms.Label KillsText;
        private System.Windows.Forms.Timer StatsTimer;
        private System.Windows.Forms.Label DeathsText;
        private System.Windows.Forms.Label KDText;
        private System.Windows.Forms.Label VictoriasText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DerrotasText;
        private System.Windows.Forms.Label WinRateText;
        private System.Windows.Forms.Label MMRText;
        private System.Windows.Forms.Label RankText;
        private System.Windows.Forms.PictureBox RankImage;
    }
}