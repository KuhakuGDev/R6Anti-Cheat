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
using Memory;

namespace AC_test
{
    public partial class Ahook : Form
    {
        //MemoryRead
        public Mem m = new Mem();
        //Variables
        bool isActivated = false;
        bool isBanned = false;

        Process R6;
        Process[] processList;

        public string loginDatPath;

        public string R6Path;


        int processnumber;

        int currentScan = 0;

        string[] cheats = { "injector", "r6", "external", "internal", "hack", "Rainbow Six", "unknown", "RageIndustries", "Aim", "NoClip" };
        string[] mouseSoftwares = { "SteelSeries GG", "Bloody7", "LGHUB", "LogiOptions", "Logi Overlay", "Logitech Options", "Razer", "Hyper" };

        List<string> ProcessInfo;

        public float MMR = 0;

        //Stats
        public int kills = 20, deaths = 17, victories = 7, loses = 5;
        public double kd, wr, matchKD = 1;

        int Killsvalue, deathsvalue, resultvalue;
        public Ahook()
        {
            //LoadData();
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
        }

        private void StartAhook(object sender, EventArgs e)
        {
            isActivated = !isActivated;
            Status.Checked = isActivated;

            if (isActivated)
            {
                R6Scan.Enabled = true;
                FirstScan();
                SecondScan();
                ThirdScan();
                FourthScan();
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
                        if (process.MainModule.FileName == R6Path)
                        {
                            FollowR6.Checked = true;
                            R6 = process;
                            R6Scan.Enabled = false;

                        }
                    }
                    catch {}


                }

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
                Baneado.Checked = isBanned;
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

        private void Info_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.Show();
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

        private void GetKills(object sender, EventArgs e)
        {
            if(R6 != null)
            {
                VAMemory vam = new VAMemory(R6.ProcessName);

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
                    if(resultvalue == 0)
                    {
                        loses++;
                        MMR -= 50 * (float)matchKD;
                    }
                    if(resultvalue == 1)
                    {
                        victories++;
                        MMR += 50 * (float)matchKD;
                    }
                }
                if ((int)vam.ReadInt64(KillsBaseseventh) >= 0 && (int)vam.ReadInt64(KillsBaseseventh) < 25)
                {
                    Killsvalue = (int)vam.ReadInt64(KillsBaseseventh);
                }



                //Deaths
                IntPtr DeathsBase = R6.MainModule.BaseAddress + 0x08267040;
                IntPtr DeathsBasefirst = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBase), 0x70);
                IntPtr DeathsBasesecond = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefirst), 0x6E8);
                IntPtr DeathsBasethird = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasesecond), 0x0);
                IntPtr DeathsBasefourth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasethird), 0xF8);
                IntPtr DeathsBasefifth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefourth), 0x0);
                IntPtr DeathsBasesixth = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasefifth), 0x20);
                IntPtr DeathsBaseseventh = IntPtr.Add((IntPtr)vam.ReadInt64(DeathsBasesixth), 0x70);

                if (vam.ReadInt64(DeathsBaseseventh) == 0 && deathsvalue > 0.1 && deathsvalue < 25)
                {
                    deaths += deathsvalue;
                }
                if((int)vam.ReadInt64(DeathsBaseseventh) >= 0 && (int)vam.ReadInt64(DeathsBaseseventh) < 25)
                {
                    deathsvalue = (int)vam.ReadInt64(DeathsBaseseventh);
                }

                if(deathsvalue > 0 && Killsvalue > 0)
                {
                    matchKD = kills / deaths;
                }


                label1.Text = victories + "/" + resultvalue;
            }
            if(!isActivated)
            {
                ScanBar.Visible = false;
            }
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

        private void StatsShow_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(this);

            stats.Show();
        }
    }
}
