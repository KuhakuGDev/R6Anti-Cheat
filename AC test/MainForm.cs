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

namespace R6AntiCheat
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

        string[] cheats = { };
        string[] mouseSoftwares = { "SteelSeries GG", "Bloody7", "LGHUB", "LogiOptions", "Logi Overlay", "Logitech Options", "Razer", "Hyper" };

        List<string> ProcessInfo;

        public float MMR = 2300;
      
        //Stats
        public int kills, deaths, deathstemp, victories, loses, killRest, deathrest, abandonos, matchKills = 1, matchDeaths = 1;
        public double kd, wr, hoursPlayed, minutsPlayed, matchTime;

        public int Killsvalue, deathsvaluetemp, resultvalue, isPlayingValue, deathvalue;

        public string CurrentRank, playerName;

        public bool addMMR = false, onMatch = false, started = false;

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
            StartButton.FlatAppearance.MouseOverBackColor = Color.Black;
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
                                        //Advice("Has sido baneado del servicio. Motivo", process);
                                        //isBanned = true;
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
                                //Advice("No puedes tener el software del mouse abierto", process);

                            }
                            else if (process.MainModule.FileVersionInfo.ProductName.ToLower().Contains(mouseSoftware.ToLower()))
                            {
                                process.Kill();
                                //Advice("No puedes tener el software del mouse abierto", process);
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
                            ReadName();
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


        private void GetStats(object sender, EventArgs e)
        {
            try
            {
                if (R6 != null && isActivated)
                {
                    VAMemory vam = new VAMemory(R6.ProcessName);

                    //On match?
                    IntPtr matchBase = R6.MainModule.BaseAddress + 0x05CAD1F8;
                    IntPtr matchBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(matchBase), 0x30);
                    IntPtr matchBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasefirst), 0x28);
                    IntPtr matchBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasesecond), 0x48);
                    IntPtr matchBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasethird), 0x60);
                    IntPtr matchBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasefourth), 0x38);
                    IntPtr matchBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasefifth), 0x28);
                    IntPtr matchBaseventh = IntPtr.Add((IntPtr)vam.ReadInt64(matchBasesixth), 0x80);


                    isPlayingValue = (int)vam.ReadInt64(matchBaseventh);

                    if(isPlayingValue == 0)
                    {
                        OnMatchText.Checked = false;
                    }
                    else if (isPlayingValue == 1)
                    {
                        OnMatchText.Checked = true;
                    }
                    else if (isPlayingValue > 1)
                    {
                        MessageBox.Show("El juego tiene que estar en pantalla completa para que las estadísticas funcionen.");
                        R6.Kill();
                        Application.Restart();
                    }
                    //label1.Text = started + "/" + matchTime;

                    if (isPlayingValue == 1)
                    {
                        if(!started)
                        {
                            started = true;
                        }
                        matchTime += 0.5;
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
                        IntPtr KillsBase = R6.MainModule.BaseAddress + 0x05D93D80;
                        IntPtr KillsBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBase), 0x10);
                        IntPtr KillsBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasefirst), 0x5A0);
                        IntPtr KillsBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasesecond), 0x10);
                        IntPtr KillsBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasethird), 0x10);
                        IntPtr KillsBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasefourth), 0x88);
                        IntPtr KillsBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasefifth), 0x20);
                        IntPtr KillsBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(KillsBasesixth), 0x54);


                        if(killRest > (int)vam.ReadInt64(KillsBaseseventh) && (int)vam.ReadInt64(KillsBaseseventh) > 0)
                        {
                            killRest = 0;
                        }

                        if ((int)vam.ReadInt64(KillsBaseseventh) >= 0 && (int)vam.ReadInt64(KillsBaseseventh) < 25)
                        {
                            Killsvalue = (int)vam.ReadInt64(KillsBaseseventh);


                            if (killRest < (int)vam.ReadInt64(KillsBaseseventh))
                            {
                                Killsvalue -= killRest;
                                killRest = (int)vam.ReadInt64(KillsBaseseventh);
                                kills += Killsvalue;
                                matchKills += Killsvalue;
                            }
                            if (killRest == 0)
                            {
                                killRest = Killsvalue;
                            }
                        }

                        //Death
                        IntPtr DeathsBase = R6.MainModule.BaseAddress + 0x05D93D80;
                        IntPtr DeathsBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBase), 0x10);
                        IntPtr DeathsBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefirst), 0x5A0);
                        IntPtr DeathsBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasesecond), 0x10);
                        IntPtr DeathsBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasethird), 0x8);
                        IntPtr DeathsBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefourth), 0x88);
                        IntPtr DeathsBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefifth), 0x20);
                        IntPtr DeathsBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasesixth), 0x74);

                        //label1.Text = deathvalue + "/" + (int)vam.ReadInt64(DeathsBaseseventh) + "/" + deathrest;

                        if (deathrest > (int)vam.ReadInt64(DeathsBaseseventh) && (int)vam.ReadInt64(DeathsBaseseventh) > 0)
                        {
                            deathrest = 0;
                        }

                        if ((int)vam.ReadInt64(DeathsBaseseventh) >= 0 && (int)vam.ReadInt64(DeathsBaseseventh) < 25)
                        {
                            deathvalue = (int)vam.ReadInt64(DeathsBaseseventh);


                            if (deathrest < (int)vam.ReadInt64(DeathsBaseseventh))
                            {
                                deathvalue -= deathrest;
                                deathrest = (int)vam.ReadInt64(DeathsBaseseventh);
                                deaths += deathvalue;
                                matchDeaths += deathvalue;
                            }
                            if (deathrest == 0)
                            {
                                deathrest = Killsvalue;
                            }
                        }

                        //FinishMatch
                        IntPtr FinishBase = R6.MainModule.BaseAddress + 0x06259F88;
                        IntPtr FinishBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBase), 0x18);
                        IntPtr FinishBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBasefirst), 0x0);
                        IntPtr FinishBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBasesecond), 0x0);
                        IntPtr FinishBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBasethird), 0x48);
                        IntPtr FinishBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBasefourth), 0x30);
                        IntPtr FinishBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBasefifth), 0x40);
                        IntPtr FinishBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(FinishBasesixth), 0xFF0);

                        //label1.Text = (int)vam.ReadInt64(FinishBaseseventh) + "/" +resultvalue+"/"+ addMMR + "/" + matchKills + "/" + matchDeaths;
                        if ((int)vam.ReadInt64(FinishBaseseventh) == 0)
                        {
                            addMMR = false;
                        }
                        else if((int)vam.ReadInt64(FinishBaseseventh) == 1)
                        {
                            if(!addMMR)
                            {
                                addMMR = true;
                                if(resultvalue == 0)
                                {
                                    CalculateMMRRemove(matchKills / matchDeaths);
                                }
                                else if(resultvalue == 1)
                                {
                                    CalculateMMRAdd(matchKills / matchDeaths);
                                }
                            }
                            started = false;
                            matchTime = 0;
                        }
                    }
                    else
                    {
                        if(started && matchTime > 300)
                        {
                            started = false;
                            matchTime = 0;
                            abandonos++;
                            MMR -= 50;
                        }
                        started = false;
                        matchTime = 0;
                    }


                }
                if (!isActivated)
                {
                    ScanBar.Visible = false;
                }
            }catch
            {

            }
        }

        private void CalculateMMRAdd(int matchKd)
        {
            Random rd = new Random();
            double randomNum = 0;
            if (CurrentRank.Contains("Cobre"))
            {
                randomNum = rd.Next(60, 75);
            }
            else if (CurrentRank.Contains("Bronce"))
            {
                randomNum = rd.Next(55, 65);
            }
            else if (CurrentRank.Contains("Plata"))
            {
                randomNum = rd.Next(50, 55);
            }
            else if(CurrentRank.Contains("Oro"))
            {
                randomNum = rd.Next(40, 50);
            }
            else if (CurrentRank.Contains("Platino"))
            {
                randomNum = rd.Next(30, 40);
            }
            else if (CurrentRank.Contains("Diamante"))
            {
                randomNum = rd.Next(20, 30);
            }
            if(matchKd >= 1)
            {
                randomNum *= 1.2;
            }
            else
            {
                randomNum /= 1.5;
            }
            randomNum = Math.Round(randomNum);
            MMR += (int)randomNum;
            MMRChange.Text = "+" + (int)randomNum;
        }

        private void CalculateMMRRemove(int matchKd)
        {
            Random rd = new Random();
            double randomNum = 0;
            if (CurrentRank.Contains("Diamante"))
            {
                randomNum = rd.Next(60, 75);
            }
            else if (CurrentRank.Contains("Platino"))
            {
                randomNum = rd.Next(55, 65);
            }
            else if (CurrentRank.Contains("Oro"))
            {
                randomNum = rd.Next(50, 55);
            }
            else if (CurrentRank.Contains("Plata"))
            {
                randomNum = rd.Next(40, 50);
            }
            else if (CurrentRank.Contains("Bronce"))
            {
                randomNum = rd.Next(30, 40);
            }
            else if (CurrentRank.Contains("Cobre"))
            {
                randomNum = rd.Next(20, 30);
            }
            if (matchKd < 1)
            {
                randomNum *= 1.2;
            }
            else
            {
                randomNum /= 1.5;
            }
            randomNum = Math.Round(randomNum);
            MMR -= (int)randomNum;
            MMRChange.Text = "-" + (int)randomNum;
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
            DeathsText.Text = "Muertes: " + deaths;
            KDText.Text = "KD: " + kd;
            VictoriasText.Text = "Victorias: " + victories;
            DerrotasText.Text = "Derrotas: " + loses;
            AbandonosText.Text = "Abandonos " + abandonos;
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
            OnMatchText.Visible = activate;
            MatchText.Visible = activate;
            AbandonosText.Visible = activate;
            MMRChange.Visible = activate;
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

        private void ReadName()
        {
            string iniPath = R6Path.Replace("RainbowSix.exe", "CPlay.ini"); 
            playerName = File.ReadLines(iniPath).Skip(4).Take(1).First();
            playerName = playerName.Replace("Username = ", "");
            AccountNameText.Text = "Usuario: " + playerName;
        }
    }
}
