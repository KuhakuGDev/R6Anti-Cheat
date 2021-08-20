
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
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(371, 517);
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
    }
}