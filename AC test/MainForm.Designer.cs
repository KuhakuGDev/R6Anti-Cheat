
namespace AC_test
{
    partial class Ahook
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahook));
            this.StartButton = new System.Windows.Forms.Button();
            this.R6Scan = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.CheckBox();
            this.Info = new System.Windows.Forms.Button();
            this.ScanBar = new System.Windows.Forms.ProgressBar();
            this.Baneado = new System.Windows.Forms.CheckBox();
            this.RandomScanTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(28, 447);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(553, 108);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Iniciar Anti-Trampas";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartAhook);
            // 
            // R6Scan
            // 
            this.R6Scan.Enabled = true;
            this.R6Scan.Interval = 5000;
            this.R6Scan.Tick += new System.EventHandler(this.SearchRainbowSix);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Status.Enabled = false;
            this.Status.Location = new System.Drawing.Point(260, 527);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(68, 17);
            this.Status.TabIndex = 1;
            this.Status.Text = "Activado";
            this.Status.UseVisualStyleBackColor = false;
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(522, 3);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(68, 40);
            this.Info.TabIndex = 4;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // ScanBar
            // 
            this.ScanBar.Location = new System.Drawing.Point(110, 623);
            this.ScanBar.Name = "ScanBar";
            this.ScanBar.Size = new System.Drawing.Size(360, 23);
            this.ScanBar.TabIndex = 6;
            this.ScanBar.Visible = false;
            // 
            // Baneado
            // 
            this.Baneado.AutoSize = true;
            this.Baneado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Baneado.Enabled = false;
            this.Baneado.Location = new System.Drawing.Point(260, 466);
            this.Baneado.Name = "Baneado";
            this.Baneado.Size = new System.Drawing.Size(69, 17);
            this.Baneado.TabIndex = 3;
            this.Baneado.TabStop = false;
            this.Baneado.Text = "Baneado";
            this.Baneado.UseVisualStyleBackColor = false;
            // 
            // RandomScanTimer
            // 
            this.RandomScanTimer.Enabled = true;
            this.RandomScanTimer.Interval = 25000;
            this.RandomScanTimer.Tick += new System.EventHandler(this.RandomScan);
            // 
            // Ahook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 676);
            this.Controls.Add(this.ScanBar);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Baneado);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ahook";
            this.Text = "Ahook";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer R6Scan;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.ProgressBar ScanBar;
        private System.Windows.Forms.CheckBox Baneado;
        private System.Windows.Forms.Timer RandomScanTimer;
    }
}

