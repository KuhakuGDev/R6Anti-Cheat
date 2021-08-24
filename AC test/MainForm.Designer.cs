
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
            this.R6Scan = new System.Windows.Forms.Timer(this.components);
            this.RandomScanTimer = new System.Windows.Forms.Timer(this.components);
            this.Stats = new System.Windows.Forms.Timer(this.components);
            this.NewCloseButton = new System.Windows.Forms.Button();
            this.NewMinimizeBut = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.StatsBackGround = new System.Windows.Forms.PictureBox();
            this.TimePlayedText = new System.Windows.Forms.Label();
            this.RankImage = new System.Windows.Forms.PictureBox();
            this.RankText = new System.Windows.Forms.Label();
            this.MMRText = new System.Windows.Forms.Label();
            this.WinRateText = new System.Windows.Forms.Label();
            this.DerrotasText = new System.Windows.Forms.Label();
            this.VictoriasText = new System.Windows.Forms.Label();
            this.KDText = new System.Windows.Forms.Label();
            this.DeathsText = new System.Windows.Forms.Label();
            this.StatsText = new System.Windows.Forms.Label();
            this.KillsText = new System.Windows.Forms.Label();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.PlayerTimeCron = new System.Windows.Forms.Timer(this.components);
            this.StatsTimer = new System.Windows.Forms.Timer(this.components);
            this.ConfigText = new System.Windows.Forms.Label();
            this.R6PathText = new System.Windows.Forms.Label();
            this.R6PathButton = new System.Windows.Forms.Button();
            this.R6Follow = new System.Windows.Forms.CheckBox();
            this.AboutText = new System.Windows.Forms.RichTextBox();
            this.VersionText = new System.Windows.Forms.Label();
            this.CreatedByText = new System.Windows.Forms.Label();
            this.AccountStateText = new System.Windows.Forms.Label();
            this.AccountNameText = new System.Windows.Forms.Label();
            this.FollowR6Text = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ScanBar = new CircularProgressBar.CircularProgressBar();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StatsBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankImage)).BeginInit();
            this.SuspendLayout();
            // 
            // R6Scan
            // 
            this.R6Scan.Enabled = true;
            this.R6Scan.Interval = 5000;
            this.R6Scan.Tick += new System.EventHandler(this.SearchRainbowSix);
            // 
            // RandomScanTimer
            // 
            this.RandomScanTimer.Enabled = true;
            this.RandomScanTimer.Interval = 25000;
            this.RandomScanTimer.Tick += new System.EventHandler(this.RandomScan);
            // 
            // Stats
            // 
            this.Stats.Enabled = true;
            this.Stats.Interval = 1000;
            this.Stats.Tick += new System.EventHandler(this.GetStats);
            // 
            // NewCloseButton
            // 
            this.NewCloseButton.BackColor = System.Drawing.Color.Black;
            this.NewCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.NewCloseButton.Location = new System.Drawing.Point(1147, -1);
            this.NewCloseButton.Name = "NewCloseButton";
            this.NewCloseButton.Size = new System.Drawing.Size(39, 34);
            this.NewCloseButton.TabIndex = 12;
            this.NewCloseButton.Text = "X";
            this.NewCloseButton.UseVisualStyleBackColor = false;
            this.NewCloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewMinimizeBut
            // 
            this.NewMinimizeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMinimizeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMinimizeBut.ForeColor = System.Drawing.Color.Gray;
            this.NewMinimizeBut.Location = new System.Drawing.Point(1097, -2);
            this.NewMinimizeBut.Name = "NewMinimizeBut";
            this.NewMinimizeBut.Size = new System.Drawing.Size(44, 30);
            this.NewMinimizeBut.TabIndex = 20;
            this.NewMinimizeBut.Text = "-";
            this.NewMinimizeBut.UseVisualStyleBackColor = false;
            this.NewMinimizeBut.Click += new System.EventHandler(this.NewMinimizeBut_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.BackColor = System.Drawing.Color.Black;
            this.StatsButton.BackgroundImage = global::AC_test.Properties.Resources.Statspng;
            this.StatsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsButton.Location = new System.Drawing.Point(1, 35);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(36, 35);
            this.StatsButton.TabIndex = 21;
            this.StatsButton.UseVisualStyleBackColor = false;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // StatsBackGround
            // 
            this.StatsBackGround.BackColor = System.Drawing.Color.Black;
            this.StatsBackGround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatsBackGround.Location = new System.Drawing.Point(37, 34);
            this.StatsBackGround.Name = "StatsBackGround";
            this.StatsBackGround.Size = new System.Drawing.Size(397, 656);
            this.StatsBackGround.TabIndex = 22;
            this.StatsBackGround.TabStop = false;
            // 
            // TimePlayedText
            // 
            this.TimePlayedText.AutoSize = true;
            this.TimePlayedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePlayedText.ForeColor = System.Drawing.Color.Snow;
            this.TimePlayedText.Location = new System.Drawing.Point(61, 364);
            this.TimePlayedText.Name = "TimePlayedText";
            this.TimePlayedText.Size = new System.Drawing.Size(118, 20);
            this.TimePlayedText.TabIndex = 33;
            this.TimePlayedText.Text = "Tiempo Jugado";
            // 
            // RankImage
            // 
            this.RankImage.Location = new System.Drawing.Point(188, 338);
            this.RankImage.Name = "RankImage";
            this.RankImage.Size = new System.Drawing.Size(100, 136);
            this.RankImage.TabIndex = 32;
            this.RankImage.TabStop = false;
            // 
            // RankText
            // 
            this.RankText.AutoSize = true;
            this.RankText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankText.ForeColor = System.Drawing.Color.Snow;
            this.RankText.Location = new System.Drawing.Point(205, 477);
            this.RankText.Name = "RankText";
            this.RankText.Size = new System.Drawing.Size(69, 25);
            this.RankText.TabIndex = 31;
            this.RankText.Text = "Rango";
            // 
            // MMRText
            // 
            this.MMRText.AutoSize = true;
            this.MMRText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMRText.ForeColor = System.Drawing.Color.Snow;
            this.MMRText.Location = new System.Drawing.Point(194, 525);
            this.MMRText.Name = "MMRText";
            this.MMRText.Size = new System.Drawing.Size(55, 20);
            this.MMRText.TabIndex = 30;
            this.MMRText.Text = "MMR: ";
            // 
            // WinRateText
            // 
            this.WinRateText.AutoSize = true;
            this.WinRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinRateText.ForeColor = System.Drawing.Color.Snow;
            this.WinRateText.Location = new System.Drawing.Point(61, 318);
            this.WinRateText.Name = "WinRateText";
            this.WinRateText.Size = new System.Drawing.Size(79, 20);
            this.WinRateText.TabIndex = 29;
            this.WinRateText.Text = "WinRate: ";
            // 
            // DerrotasText
            // 
            this.DerrotasText.AutoSize = true;
            this.DerrotasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DerrotasText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DerrotasText.Location = new System.Drawing.Point(61, 276);
            this.DerrotasText.Name = "DerrotasText";
            this.DerrotasText.Size = new System.Drawing.Size(75, 20);
            this.DerrotasText.TabIndex = 28;
            this.DerrotasText.Text = "Derrotas:";
            // 
            // VictoriasText
            // 
            this.VictoriasText.AutoSize = true;
            this.VictoriasText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictoriasText.ForeColor = System.Drawing.SystemColors.Control;
            this.VictoriasText.Location = new System.Drawing.Point(62, 229);
            this.VictoriasText.Name = "VictoriasText";
            this.VictoriasText.Size = new System.Drawing.Size(74, 20);
            this.VictoriasText.TabIndex = 27;
            this.VictoriasText.Text = "Victorias:";
            this.VictoriasText.Click += new System.EventHandler(this.VictoriasText_Click);
            // 
            // KDText
            // 
            this.KDText.AutoSize = true;
            this.KDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KDText.ForeColor = System.Drawing.Color.SeaShell;
            this.KDText.Location = new System.Drawing.Point(64, 187);
            this.KDText.Name = "KDText";
            this.KDText.Size = new System.Drawing.Size(39, 20);
            this.KDText.TabIndex = 26;
            this.KDText.Text = "KD: ";
            this.KDText.Click += new System.EventHandler(this.KDText_Click);
            // 
            // DeathsText
            // 
            this.DeathsText.AutoSize = true;
            this.DeathsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathsText.ForeColor = System.Drawing.SystemColors.Window;
            this.DeathsText.Location = new System.Drawing.Point(63, 144);
            this.DeathsText.Name = "DeathsText";
            this.DeathsText.Size = new System.Drawing.Size(65, 20);
            this.DeathsText.TabIndex = 25;
            this.DeathsText.Text = "Deaths:";
            this.DeathsText.Click += new System.EventHandler(this.DeathsText_Click);
            // 
            // StatsText
            // 
            this.StatsText.AutoSize = true;
            this.StatsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsText.ForeColor = System.Drawing.Color.Snow;
            this.StatsText.Location = new System.Drawing.Point(165, 75);
            this.StatsText.Name = "StatsText";
            this.StatsText.Size = new System.Drawing.Size(128, 25);
            this.StatsText.TabIndex = 24;
            this.StatsText.Text = "Stats (Beta)";
            this.StatsText.Click += new System.EventHandler(this.StatsText_Click);
            // 
            // KillsText
            // 
            this.KillsText.AutoSize = true;
            this.KillsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillsText.ForeColor = System.Drawing.Color.Snow;
            this.KillsText.Location = new System.Drawing.Point(62, 107);
            this.KillsText.Name = "KillsText";
            this.KillsText.Size = new System.Drawing.Size(44, 20);
            this.KillsText.TabIndex = 23;
            this.KillsText.Text = "Kills: ";
            this.KillsText.Click += new System.EventHandler(this.KillsText_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackgroundImage = global::AC_test.Properties.Resources.Options;
            this.ConfigButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigButton.Location = new System.Drawing.Point(2, 91);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(33, 36);
            this.ConfigButton.TabIndex = 34;
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // PlayerTimeCron
            // 
            this.PlayerTimeCron.Enabled = true;
            this.PlayerTimeCron.Interval = 60000;
            this.PlayerTimeCron.Tick += new System.EventHandler(this.Cronometer);
            // 
            // StatsTimer
            // 
            this.StatsTimer.Enabled = true;
            this.StatsTimer.Interval = 1000;
            this.StatsTimer.Tick += new System.EventHandler(this.StatsTimer_Tick);
            // 
            // ConfigText
            // 
            this.ConfigText.AutoSize = true;
            this.ConfigText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigText.ForeColor = System.Drawing.Color.Snow;
            this.ConfigText.Location = new System.Drawing.Point(165, 75);
            this.ConfigText.Name = "ConfigText";
            this.ConfigText.Size = new System.Drawing.Size(84, 25);
            this.ConfigText.TabIndex = 35;
            this.ConfigText.Text = "Ajustes";
            this.ConfigText.Visible = false;
            // 
            // R6PathText
            // 
            this.R6PathText.AutoSize = true;
            this.R6PathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R6PathText.ForeColor = System.Drawing.Color.Snow;
            this.R6PathText.Location = new System.Drawing.Point(64, 124);
            this.R6PathText.Name = "R6PathText";
            this.R6PathText.Size = new System.Drawing.Size(98, 20);
            this.R6PathText.TabIndex = 36;
            this.R6PathText.Text = "Ruta del R6:";
            this.R6PathText.Visible = false;
            // 
            // R6PathButton
            // 
            this.R6PathButton.Location = new System.Drawing.Point(168, 124);
            this.R6PathButton.Name = "R6PathButton";
            this.R6PathButton.Size = new System.Drawing.Size(25, 23);
            this.R6PathButton.TabIndex = 37;
            this.R6PathButton.Text = "...";
            this.R6PathButton.UseVisualStyleBackColor = true;
            this.R6PathButton.Visible = false;
            this.R6PathButton.Click += new System.EventHandler(this.R6Select_Click);
            // 
            // R6Follow
            // 
            this.R6Follow.AutoSize = true;
            this.R6Follow.BackColor = System.Drawing.Color.Black;
            this.R6Follow.Enabled = false;
            this.R6Follow.ForeColor = System.Drawing.Color.Linen;
            this.R6Follow.Location = new System.Drawing.Point(196, 124);
            this.R6Follow.Name = "R6Follow";
            this.R6Follow.Size = new System.Drawing.Size(15, 14);
            this.R6Follow.TabIndex = 38;
            this.R6Follow.UseVisualStyleBackColor = false;
            // 
            // AboutText
            // 
            this.AboutText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutText.ForeColor = System.Drawing.Color.White;
            this.AboutText.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AboutText.Location = new System.Drawing.Point(65, 451);
            this.AboutText.Name = "AboutText";
            this.AboutText.Size = new System.Drawing.Size(340, 147);
            this.AboutText.TabIndex = 39;
            this.AboutText.Text = resources.GetString("AboutText.Text");
            this.AboutText.Visible = false;
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VersionText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VersionText.Location = new System.Drawing.Point(207, 626);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(38, 13);
            this.VersionText.TabIndex = 40;
            this.VersionText.Text = "V0.9.5";
            this.VersionText.Visible = false;
            // 
            // CreatedByText
            // 
            this.CreatedByText.AutoSize = true;
            this.CreatedByText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedByText.ForeColor = System.Drawing.SystemColors.Control;
            this.CreatedByText.Location = new System.Drawing.Point(96, 654);
            this.CreatedByText.Name = "CreatedByText";
            this.CreatedByText.Size = new System.Drawing.Size(280, 20);
            this.CreatedByText.TabIndex = 41;
            this.CreatedByText.Text = "Anti-Trampas desarrollado por Kuhaku";
            this.CreatedByText.Visible = false;
            // 
            // AccountStateText
            // 
            this.AccountStateText.AutoSize = true;
            this.AccountStateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountStateText.ForeColor = System.Drawing.Color.Snow;
            this.AccountStateText.Location = new System.Drawing.Point(65, 619);
            this.AccountStateText.Name = "AccountStateText";
            this.AccountStateText.Size = new System.Drawing.Size(209, 20);
            this.AccountStateText.TabIndex = 43;
            this.AccountStateText.Text = "Estado de la cuenta: Normal";
            // 
            // AccountNameText
            // 
            this.AccountNameText.AutoSize = true;
            this.AccountNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameText.ForeColor = System.Drawing.Color.Snow;
            this.AccountNameText.Location = new System.Drawing.Point(65, 582);
            this.AccountNameText.Name = "AccountNameText";
            this.AccountNameText.Size = new System.Drawing.Size(164, 20);
            this.AccountNameText.TabIndex = 44;
            this.AccountNameText.Text = "Nombre de la cuenta: ";
            // 
            // FollowR6Text
            // 
            this.FollowR6Text.AutoSize = true;
            this.FollowR6Text.BackColor = System.Drawing.Color.Black;
            this.FollowR6Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FollowR6Text.Location = new System.Drawing.Point(217, 124);
            this.FollowR6Text.Name = "FollowR6Text";
            this.FollowR6Text.Size = new System.Drawing.Size(71, 13);
            this.FollowR6Text.TabIndex = 45;
            this.FollowR6Text.Text = "Siguiendo R6";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(705, 338);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(173, 179);
            this.StartButton.TabIndex = 0;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartAhook);
            // 
            // ScanBar
            // 
            this.ScanBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ScanBar.AnimationSpeed = 500;
            this.ScanBar.BackColor = System.Drawing.Color.Transparent;
            this.ScanBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.ScanBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScanBar.InnerColor = System.Drawing.Color.Transparent;
            this.ScanBar.InnerMargin = 2;
            this.ScanBar.InnerWidth = -1;
            this.ScanBar.Location = new System.Drawing.Point(1137, 642);
            this.ScanBar.MarqueeAnimationSpeed = 2000;
            this.ScanBar.Name = "ScanBar";
            this.ScanBar.OuterColor = System.Drawing.Color.White;
            this.ScanBar.OuterMargin = -26;
            this.ScanBar.OuterWidth = 26;
            this.ScanBar.ProgressColor = System.Drawing.Color.LimeGreen;
            this.ScanBar.ProgressWidth = 8;
            this.ScanBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ScanBar.Size = new System.Drawing.Size(49, 48);
            this.ScanBar.StartAngle = 270;
            this.ScanBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ScanBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ScanBar.SubscriptText = ".23";
            this.ScanBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ScanBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ScanBar.SuperscriptText = "°C";
            this.ScanBar.TabIndex = 46;
            this.ScanBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ScanBar.Value = 68;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(66, 229);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(96, 23);
            this.SaveChangesButton.TabIndex = 47;
            this.SaveChangesButton.Text = "Guardar cambios";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Visible = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // Ahook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 696);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.ScanBar);
            this.Controls.Add(this.FollowR6Text);
            this.Controls.Add(this.AccountNameText);
            this.Controls.Add(this.AccountStateText);
            this.Controls.Add(this.CreatedByText);
            this.Controls.Add(this.VersionText);
            this.Controls.Add(this.AboutText);
            this.Controls.Add(this.R6Follow);
            this.Controls.Add(this.R6PathButton);
            this.Controls.Add(this.R6PathText);
            this.Controls.Add(this.ConfigText);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.TimePlayedText);
            this.Controls.Add(this.RankImage);
            this.Controls.Add(this.RankText);
            this.Controls.Add(this.MMRText);
            this.Controls.Add(this.WinRateText);
            this.Controls.Add(this.DerrotasText);
            this.Controls.Add(this.VictoriasText);
            this.Controls.Add(this.KDText);
            this.Controls.Add(this.DeathsText);
            this.Controls.Add(this.StatsText);
            this.Controls.Add(this.KillsText);
            this.Controls.Add(this.StatsBackGround);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.NewMinimizeBut);
            this.Controls.Add(this.NewCloseButton);
            this.Controls.Add(this.StartButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ahook";
            this.Text = "Ahook";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ahook_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.StatsBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer R6Scan;
        private System.Windows.Forms.Timer RandomScanTimer;
        private System.Windows.Forms.Timer Stats;
        private System.Windows.Forms.Button NewCloseButton;
        private System.Windows.Forms.Button NewMinimizeBut;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.PictureBox StatsBackGround;
        private System.Windows.Forms.Label TimePlayedText;
        private System.Windows.Forms.PictureBox RankImage;
        private System.Windows.Forms.Label RankText;
        private System.Windows.Forms.Label MMRText;
        private System.Windows.Forms.Label WinRateText;
        private System.Windows.Forms.Label DerrotasText;
        private System.Windows.Forms.Label VictoriasText;
        private System.Windows.Forms.Label KDText;
        private System.Windows.Forms.Label DeathsText;
        private System.Windows.Forms.Label StatsText;
        public System.Windows.Forms.Label KillsText;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Timer PlayerTimeCron;
        private System.Windows.Forms.Timer StatsTimer;
        private System.Windows.Forms.Label ConfigText;
        public System.Windows.Forms.Label R6PathText;
        private System.Windows.Forms.Button R6PathButton;
        private System.Windows.Forms.CheckBox R6Follow;
        private System.Windows.Forms.RichTextBox AboutText;
        private System.Windows.Forms.Label VersionText;
        private System.Windows.Forms.Label CreatedByText;
        public System.Windows.Forms.Label AccountStateText;
        public System.Windows.Forms.Label AccountNameText;
        private System.Windows.Forms.Label FollowR6Text;
        private System.Windows.Forms.Button StartButton;
        private CircularProgressBar.CircularProgressBar ScanBar;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}

