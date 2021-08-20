
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
            this.label1 = new System.Windows.Forms.Label();
            this.KillsText = new System.Windows.Forms.Label();
            this.StatsText = new System.Windows.Forms.Label();
            this.StatsTimer = new System.Windows.Forms.Timer(this.components);
            this.DeathsText = new System.Windows.Forms.Label();
            this.KDText = new System.Windows.Forms.Label();
            this.VictoriasText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DerrotasText = new System.Windows.Forms.Label();
            this.WinRateText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.DerrotasText.Location = new System.Drawing.Point(15, 219);
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
            this.WinRateText.Location = new System.Drawing.Point(18, 260);
            this.WinRateText.Name = "WinRateText";
            this.WinRateText.Size = new System.Drawing.Size(79, 20);
            this.WinRateText.TabIndex = 8;
            this.WinRateText.Text = "WinRate: ";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(371, 517);
            this.Controls.Add(this.WinRateText);
            this.Controls.Add(this.DerrotasText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VictoriasText);
            this.Controls.Add(this.KDText);
            this.Controls.Add(this.DeathsText);
            this.Controls.Add(this.StatsText);
            this.Controls.Add(this.KillsText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatsText;
        public System.Windows.Forms.Label KillsText;
        private System.Windows.Forms.Timer StatsTimer;
        private System.Windows.Forms.Label DeathsText;
        private System.Windows.Forms.Label KDText;
        private System.Windows.Forms.Label VictoriasText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DerrotasText;
        private System.Windows.Forms.Label WinRateText;
    }
}