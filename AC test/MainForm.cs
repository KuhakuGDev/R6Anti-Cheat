using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Input;
using System.IO.Compression;
using System.Threading;
using System.Runtime.InteropServices;

namespace AC_test
{
    public partial class Ahook : Form
    {


        //UI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0X2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Variables
        bool isActivated = false;
        bool isBanned = false;

        public Process R6;
        Process[] processList;

        public string loginDatPath;

        public string R6Path;


        int processnumber;

        int currentScan = 0;

        string[] cheats = { "Cheat Engine", "Cheat", "injector", "r6", "external", "internal", "hack", "Rainbow Six", "unknown", "RageIndustries", "Aim", "NoClip" };
        string[] mouseSoftwares = { "SteelSeries GG", "Bloody7", "LGHUB", "LogiOptions", "Logi Overlay", "Logitech Options", "Razer", "Hyper" };

        List<string> ProcessInfo;

        public float MMR = 2300;
      
        //Stats
        public int kills = 5, deaths = 2, victories = 6, loses = 4;
        public double kd, wr, matchKD = 1, hoursPlayed = 3, minutsPlayed;

        public int Killsvalue, deathsvalue, resultvalue, isPlayingValue;

        public string CurrentRank;

        bool overlayshowed = false;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
        );

        public Ahook()
        {
            //LoadData();
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
            LoadChanges();
            //ReadIni();

            //UI
            NewCloseButton.FlatAppearance.BorderColor = BackColor;
            NewMinimizeBut.FlatAppearance.BorderColor = BackColor;
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CreateTooltips();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void StartAhook(object sender, EventArgs e)
        {

                isActivated = !isActivated;

            if (isActivated)
            {
                StartButton.BackgroundImage = Properties.Resources.StartButtonPressed;
                R6Scan.Enabled = true;
                FirstScan();
                SecondScan();
                ThirdScan();
                FourthScan();
            }
            else
            {
                StartButton.BackgroundImage = Properties.Resources.StartButton;
            }

        }

        private void RandomScan(object sender, EventArgs e)
        {
            switch (currentScan)
            {
                case 0:
                    FirstScan();
                    currentScan++;
                    break;
                case 1:
                    SecondScan();
                    currentScan++;
                    break;
                case 2:
                    ThirdScan();
                    currentScan++;
                    break;
                case 3:
                    FourthScan();
                    currentScan = 0;
                    break;
            }
        }


        private void FirstScan()
        {
            OnStartScan();
            //SaveProcess();
            if (isActivated && !isBanned)
            {
                ScanBar.Maximum = processnumber;
                foreach (Process process in processList)
                {
                    try
                    {
                        if (process.ToString() != "System.Diagnostics.Process (R6AC)" && process.MainModule.FileVersionInfo.FileDescription != "Rainbow Six")
                        {
                            ScanBar.Value++;

                            foreach (string cheat in cheats)
                            {
                                try
                                {
                                    if (process.MainModule.FileVersionInfo.FileDescription.ToLower().Contains(cheat.ToLower()))
                                    {
                                        process.Kill();
                                        Advice("Has sido baneado del servicio. Motivo", process);
                                        isBanned = true;
                                        break;
                                    }
                                }
                                catch { }
                            }

                        }

                    }
                    catch { }

                    Thread.Sleep(10);
                }
            }
            ScanBar.Visible = false;
        }

        private void SecondScan()
        {

            OnStartScan();

            if (isActivated && !isBanned)
            {
                ScanBar.Maximum = processnumber;
                foreach (Process process in processList)
                {
                    try
                    {
                        if (process.ToString() != "System.Diagnostics.Process (R6AC)" && process.MainModule.FileVersionInfo.FileDescription != "Rainbow Six")
                        {
                            ScanBar.Value++;

                            foreach (string cheat in cheats)
                            {
                                try
                                {
                                    if (process.ToString().ToLower().Contains(cheat.ToLower()) && process.MainModule.FileName.ToLower().Contains(cheat.ToLower()))
                                    {
                                        process.Kill();
                                        Advice("Has sido baneado del servicio. Motivo", process);
                                        isBanned = true;
                                        break;
                                    }
                                }
                                catch { }
                            }

                        }

                    }
                    catch { }

                    Thread.Sleep(10);
                }
            }
            ScanBar.Visible = false;
        }

        private void ThirdScan()
        {

            OnStartScan();

            if (isActivated && !isBanned)
            {
                ScanBar.Maximum = processnumber;
                foreach (Process process in processList)
                {
                    foreach (string mouseSoftware in mouseSoftwares)
                    {
                        try
                        {
                            ScanBar.Value++;
                            if (process.MainModule.FileVersionInfo.FileDescription.ToLower().Contains(mouseSoftware.ToLower()))
                            {
                                process.Kill();
                                Advice("No puedes tener el software del mouse abierto", process);

                            }
                            else if (process.MainModule.FileVersionInfo.ProductName.ToLower().Contains(mouseSoftware.ToLower()))
                            {
                                process.Kill();
                                Advice("No puedes tener el software del mouse abierto", process);
                            }
                        }
                        catch { }
                    }
                    ScanBar.Visible = false;

                    Thread.Sleep(10);
                }
            }

        }

        private void FourthScan()
        {
            OnStartScan();

            //Kill CMD
            if (isActivated && !isBanned)
            {
                ScanBar.Maximum = processnumber;
                foreach (Process process in processList)
                {
                    try
                    {
                        ScanBar.Value++;
                        if (process.ToString() == "System.Diagnostics.Process (conhost)")
                        {
                            process.Kill();
                        }
                        if (process.MainModule.FileVersionInfo.LegalCopyright == null)
                        {
                            process.Kill();
                            /*
                            string processPath = process.MainModule.FileName;
                            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "up");
                            string currentPath = AppDomain.CurrentDomain.BaseDirectory + @"up/" + process.ProcessName + ".exe";

                            File.Copy(processPath, currentPath);
                            CompressFile(currentPath);
                            */
                            //Despues de comprimirlo el archivo se sube a una base de datos o algo junto con el nombre de usuario del que lo subio

                        }

                    }
                    catch { }
                }
                ScanBar.Visible = false;
                Thread.Sleep(10);
            }

        }

        private void SearchRainbowSix(object sender, EventArgs e)
        {
            processList = Process.GetProcesses();
            if (R6 == null && R6Path != "")
            {
                foreach (Process process in processList)
                {
                    try
                    {
                        if (R6Path.Contains(process.ProcessName) && process.ProcessName == "RainbowSix")
                        {
                            R6Follow.Checked = true;
                            R6 = process;
                        }
                    }
                    catch {}


                }

            }
            if(R6 == null)
            {
                R6Follow.Checked = false;
            }
        }

        private void OnStartScan()
        {
            ScanBar.Visible = true;
            ScanBar.Value = 0;
            CheckBan();
            //Get process list
            processList = Process.GetProcesses();

            processnumber = Process.GetProcesses().Count();
        }

        private void SaveProcess()
        {
            StreamWriter writer = new StreamWriter("D:/Procesos/procesos.txt");

            for(int lines = 0; lines < processList.Length; lines++)
            {
                writer.WriteLine(processList[lines].ToString());
            }
            writer.Close();

        }

        private void CheckBan()
        {
            if(isBanned)
            {
                isActivated = false;
                AccountStateText.Text = "Estado de la cuenta: Baneado";
                isActivated = !isBanned;
                R6Scan.Enabled = false;
                RandomScanTimer.Enabled = false;
                StartButton.Enabled = false;
                ScanBar.Visible = false;
            }
        }

        private void Advice(string text, Process process)
        {
            MessageBox.Show(text + ": " + process.ProcessName);
        }

        public static void CompressFile(string path)
        {
            FileStream sourceFile = File.OpenRead(path);
            FileStream destinationFile = File.Create(path + ".gz");

            byte[] buffer = new byte[sourceFile.Length];
            sourceFile.Read(buffer, 0, buffer.Length);

            using (GZipStream output = new GZipStream(destinationFile,
                CompressionMode.Compress))
            {
                Console.WriteLine("Compressing {0} to {1}.", sourceFile.Name,
                    destinationFile.Name, false);

                output.Write(buffer, 0, buffer.Length);
            }

            // Close the files.
            sourceFile.Close();
            destinationFile.Close();
        }

        private void GetInfo(Process process)
        {
            ProcessInfo.Add(process.ProcessName);
            ProcessInfo.Add(process.MainModule.ModuleName);
            ProcessInfo.Add(process.MainModule.FileName);
            ProcessInfo.Add(process.MainModule.FileVersionInfo.ProductName);
            ProcessInfo.Add(process.MainModule.FileVersionInfo.CompanyName);
            ProcessInfo.Add(process.MainModule.FileVersionInfo.FileName);
            ProcessInfo.Add(process.MainModule.FileVersionInfo.FileDescription);

            //StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "R6AC.dat");
            //writer.Write(ProcessInfo);
            //writer.Close();
        }

        private void GetStats(object sender, EventArgs e)
        {
            try
            {


                if (R6 != null && isActivated)
                {
                    VAMemory vam = new VAMemory(R6.ProcessName);

                    //On match?
                    IntPtr matchBase = R6.MainModule.BaseAddress + 0x05CAABA0;
                    IntPtr matchBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(matchBase), 0x28);
                    IntPtr matchBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasefirst), 0x0);
                    IntPtr matchBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasesecond), 0x18);
                    IntPtr matchBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasethird), 0x38);
                    IntPtr matchBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasefourth), 0x88);
                    IntPtr matchBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasefifth), 0x10);
                    IntPtr matchBaseventh = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasesixth), 0x830);


                    isPlayingValue = (int)vam.ReadInt64(matchBaseventh);

                    if (isPlayingValue == 1)
                    {
                        //Victory or Lose
                        IntPtr resultBase = R6.MainModule.BaseAddress + 0x06098BE0;
                        IntPtr resultBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(resultBase), 0x80);
                        IntPtr resultBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(resultBasefirst), 0xB8);
                        IntPtr resultBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(resultBasesecond), 0x78);
                        IntPtr resultBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(resultBasethird), 0x20);
                        IntPtr resultBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(resultBasefourth), 0x390);
                        IntPtr resultBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(resultBasefifth), 0x18);
                        IntPtr resultBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(resultBasesixth), 0x19C);

                        resultvalue = (int)vam.ReadInt64(resultBaseseventh);

                        //Kills
                        IntPtr KillsBase = R6.MainModule.BaseAddress + 0x05EF5478;
                        IntPtr KillsBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBase), 0x10);
                        IntPtr KillsBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasefirst), 0xA8);
                        IntPtr KillsBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasesecond), 0x10);
                        IntPtr KillsBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasethird), 0x8);
                        IntPtr KillsBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasefourth), 0x8);
                        IntPtr KillsBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasefifth), 0x38);
                        IntPtr KillsBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasesixth), 0x1E0);

                        if (vam.ReadInt64(KillsBaseseventh) == 0 && Killsvalue > 0.1 && Killsvalue < 25)
                        {
                            kills += Killsvalue;
                        }
                        if ((int)vam.ReadInt64(KillsBaseseventh) >= 0 && (int)vam.ReadInt64(KillsBaseseventh) < 25)
                        {
                            Killsvalue = (int)vam.ReadInt64(KillsBaseseventh);
                        }



                        //Deaths
                        IntPtr DeathsBase = R6.MainModule.BaseAddress + 0x071B7A60;
                        IntPtr DeathsBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBase), 0x10);
                        IntPtr DeathsBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefirst), 0x38);
                        IntPtr DeathsBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasesecond), 0x290);
                        IntPtr DeathsBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasethird), 0x0);
                        IntPtr DeathsBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefourth), 0x98);
                        IntPtr DeathsBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefifth), 0x20);
                        IntPtr DeathsBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasesixth), 0x70);

                        if (vam.ReadInt64(DeathsBaseseventh) == 0 && deathsvalue > 0.1 && deathsvalue < 25)
                        {
                            deaths += deathsvalue;

                            if (resultvalue == 0)
                            {
                                loses++;
                                MMR -= 50;
                            }
                            if (resultvalue == 1)
                            {
                                victories++;
                                MMR += 50;
                            }
                        }
                        if ((int)vam.ReadInt64(DeathsBaseseventh) >= 0 && (int)vam.ReadInt64(DeathsBaseseventh) < 25)
                        {
                            deathsvalue = (int)vam.ReadInt64(DeathsBaseseventh);
                        }

                        if (deathsvalue > 0 && Killsvalue > 0)
                        {
                            matchKD = kills / deaths;
                        }


                        //label1.Text = victories + "/" + resultvalue;
                        //label1.Text = "En partida";

                    }
                    else
                    {
                        //label1.Text = "No estas en partida";
                    }


                }
                if (!isActivated)
                {
                    ScanBar.Visible = false;
                }
            }catch
            {
                MessageBox.Show("No cierres el juego sin desactivar el antihook");
                Application.Exit();
            }
        }

        private void StatsText_Click(object sender, EventArgs e)
        {

        }

        private void KillsText_Click(object sender, EventArgs e)
        {

        }

        private void DeathsText_Click(object sender, EventArgs e)
        {

        }

        private void KDText_Click(object sender, EventArgs e)
        {

        }

        private void VictoriasText_Click(object sender, EventArgs e)
        {

        }

        private void R6Select_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    R6Path = file;
                }
                catch (IOException)
                {
                }
            }
        }

        //Stats
        private void StatsTimer_Tick(object sender, EventArgs e)
        {
            if (kills > 0 && deaths > 0)
            {
                kd = (float)kills / deaths;
                kd = Math.Round(kd, 1);
            }
            KillsText.Text = "Kills: " + kills;
            DeathsText.Text = "Deaths: " + deaths;
            KDText.Text = "KD: " + kd;
            VictoriasText.Text = "Victorias: " + victories;
            DerrotasText.Text = "Derrotas: " + loses;
            if (victories > 0 && loses > 0)
            {
                wr = (float)victories / loses;
                wr = Math.Round(wr, 1);
            }
            WinRateText.Text = "WinRate: " + wr;
            MMRText.Text = "MMR: " + MMR;

            SetRank();
            RankText.Text = CurrentRank;

            if (minutsPlayed > 59)
            {
                minutsPlayed = 0;
                hoursPlayed++;
            }
            TimePlayedText.Text = "Tiempo: " + hoursPlayed + ":" + minutsPlayed;

        }
        private void SetRank()
        {
            if (MMR < 0)
            {
                MMR = 0;
            }
            //Copper
            else if (MMR > 0 && MMR < 1200)
            {
                CurrentRank = "Cobre 5";
                RankImage.Image = Properties.Resources.copper_5;
            }
            else if (MMR >= 1200 && MMR < 1300)
            {
                CurrentRank = "Cobre 4";
                RankImage.Image = Properties.Resources.copper_4;
            }
            else if (MMR >= 1300 && MMR < 1400)
            {
                CurrentRank = "Cobre 3";
                RankImage.Image = Properties.Resources.copper_3;
            }
            else if (MMR >= 1400 && MMR < 1500)
            {
                CurrentRank = "Cobre 2";
                RankImage.Image = Properties.Resources.copper_2;
            }
            else if (MMR >= 1500 && MMR < 1600)
            {
                CurrentRank = "Cobre 1";
                RankImage.Image = Properties.Resources.copper_1;
            }
            //Bronze
            else if (MMR >= 1600 && MMR < 1700)
            {
                CurrentRank = "Bronce 5";
                RankImage.Image = Properties.Resources.Bronze_5;
            }
            else if (MMR >= 1700 && MMR < 1800)
            {
                CurrentRank = "Bronce 4";
                RankImage.Image = Properties.Resources.Bronze_4;
            }
            else if (MMR >= 1800 && MMR < 1900)
            {
                CurrentRank = "Bronce 3";
                RankImage.Image = Properties.Resources.Bronze_3;
            }
            else if (MMR >= 1900 && MMR < 2000)
            {
                CurrentRank = "Bronce 2";
                RankImage.Image = Properties.Resources.Bronze_2;
            }
            else if (MMR >= 2000 && MMR < 2100)
            {
                CurrentRank = "Bronce 1";
                RankImage.Image = Properties.Resources.Bronze_1;
            }
            //Silver
            else if (MMR >= 2100 && MMR < 2200)
            {
                CurrentRank = "Plata 5";
                RankImage.Image = Properties.Resources.Silver_5;
            }
            else if (MMR >= 2200 && MMR < 2300)
            {
                CurrentRank = "Plata 4";
                RankImage.Image = Properties.Resources.Silver_4;
            }
            else if (MMR >= 2300 && MMR < 2400)
            {
                CurrentRank = "Plata 3";
                RankImage.Image = Properties.Resources.Silver_3;
            }
            else if (MMR >= 2400 && MMR < 2500)
            {
                CurrentRank = "Plata 2";
                RankImage.Image = Properties.Resources.Silver_2;
            }
            else if (MMR >= 2500 && MMR < 2600)
            {
                CurrentRank = "Plata 1";
                RankImage.Image = Properties.Resources.Silver_1;
            }
            //Gold
            else if (MMR >= 2600 && MMR < 2800)
            {
                CurrentRank = "Oro 3";
                RankImage.Image = Properties.Resources.Gold_3;
            }
            else if (MMR >= 2800 && MMR < 3000)
            {
                CurrentRank = "Oro 2";
                RankImage.Image = Properties.Resources.Gold_2;
            }
            else if (MMR >= 3000 && MMR < 3200)
            {
                CurrentRank = "Oro 1";
                RankImage.Image = Properties.Resources.Gold_1;
            }
            //Platinum
            else if (MMR >= 3200 && MMR < 2600)
            {
                CurrentRank = "Platino 3";
                RankImage.Image = Properties.Resources.Platinum_3;
            }
            else if (MMR >= 3600 && MMR < 4000)
            {
                CurrentRank = "Platino 2";
                RankImage.Image = Properties.Resources.Platinum_2;
            }
            else if (MMR >= 4000 && MMR < 4400)
            {
                CurrentRank = "Platino 1";
                RankImage.Image = Properties.Resources.Platinum_1;
            }
            //Diamond
            else if (MMR >= 4400)
            {
                CurrentRank = "Diamante";
                RankImage.Image = Properties.Resources.Diamond;
            }

            if (MMR < 2600)
            {
            }
        }


        private void Cronometer(object sender, EventArgs e)
        {
            if (isPlayingValue == 1)
            {
                minutsPlayed += 1;
            }
        }

        //UI
        private void Ahook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewMinimizeBut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            ShowConfig(false);
            ShowStats(true);
        }

        private void ShowStats(bool activate)
        {
            StatsText.Visible = activate;
            KillsText.Visible = activate;
            DeathsText.Visible = activate;
            KDText.Visible = activate;
            VictoriasText.Visible = activate;
            DerrotasText.Visible = activate;
            WinRateText.Visible = activate;
            TimePlayedText.Visible = activate;
            RankImage.Visible = activate;
            RankText.Visible = activate;
            MMRText.Visible = activate;
            AccountStateText.Visible = activate;
            AccountNameText.Visible = activate;
            FollowR6Text.Visible = activate;
            R6Follow.Visible = activate;
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ShowStats(false);
            ShowConfig(true);
        }

        private void ShowConfig(bool activate)
        {
            ConfigText.Visible = activate;
            R6PathText.Visible = activate;
            R6PathButton.Visible = activate;
            AboutText.Visible = activate;
            VersionText.Visible = activate;
            CreatedByText.Visible = activate;
            SaveChangesButton.Visible = activate;
        }

        //ToolTips

        private void CreateTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(R6PathButton, "Esta opción solo tienes que configurarla una vez, al menos que la ruta del juego cambie.");
        }


        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.R6PathSave = R6Path;
            Properties.Settings.Default.Save();
            /*
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"/config.txt");
            writer.Write(StatsInGameCheck.Checked.ToString() + ';', Environment.NewLine);
            writer.Close();
            */
        }
        private void LoadChanges()
        {
            R6Path = Properties.Settings.Default.R6PathSave;
        }
    }
}
