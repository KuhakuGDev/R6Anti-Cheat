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

namespace AC_test
{
    public partial class Ahook : Form
    {
        //Variables
        bool isActivated = false;
        bool isBanned = false;

        Process R6;
        Process[] processList;

        public string loginDatPath;

        int processnumber;

        string[] cheats = { "Cheat Engine", "injector", "r6", "external", "internal", "hack", "cheat, Rainbow Six", "unknown", "RageIndustries", "Aim", "NoClip" };
        string[] mouseSoftwares = { "SteelSeries GG", "Bloody7", "LGHUB", "LogiOptions", "Logi Overlay", "Logitech Options", "Razer", "Hyper" };

        List<string> ProcessInfo;
        public Ahook()
        {
            //LoadData();
            InitializeComponent();
            this.TransparencyKey = Color.Empty;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ScanBar.Visible = true;
            ScanBar.Value = 0;
            CheckBan();


            //Get process list
            if(processnumber != Process.GetProcesses().Count())
            {
                processList = Process.GetProcesses();
            }

            processnumber = Process.GetProcesses().Count();

            SaveProcess();
            //SaveProcess(processListString);
            try
            {
                if (R6 == null)
                {
                    foreach (Process process in processList)
                    {
                        if (process.MainModule.FileVersionInfo.FileDescription == "Rainbow Six")
                        {
                            R6 = process;
                        }
                    }
                }
            }
            catch { }
            //Start Anti-Cheat
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

                                    }
                                    if (process.ToString().ToLower().Contains(cheat.ToLower()) && process.MainModule.FileName.ToLower().Contains(cheat.ToLower()))
                                    {
                                        process.Kill();
                                        Advice("Has sido baneado del servicio. Motivo", process);
                                        isBanned = true;
                                    }
                                }
                                catch { }
                            }

                            foreach (string mouseSoftware in mouseSoftwares)
                            {
                                try
                                {
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

                            //Kill CMD
                            try
                            {
                                if (process.ToString() == "System.Diagnostics.Process (conhost)")
                                {
                                    process.Kill();
                                }
                                if (process.MainModule.FileVersionInfo.LegalCopyright == null)
                                {
                                    string processPath = process.MainModule.FileName;
                                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "up");
                                    string currentPath = AppDomain.CurrentDomain.BaseDirectory + @"up/" + process.ProcessName +".exe";
    
                                    File.Copy(processPath, currentPath);
                                    CompressFile(currentPath);

                                    //Despues de comprimirlo el archivo se sube a una base de datos o algo junto con el nombre de usuario del que lo subio
                                    process.Kill();
                                }

                            }
                            catch { }
                        }

                    }
                    catch { }


                }
            }
            ScanBar.Visible = false;
        }

        private void StartAhook(object sender, EventArgs e)
        {
            isActivated = !isActivated;
            Status.Checked = isActivated;

            StartButton_Click(sender, e);
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
                timer1.Enabled = false;
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
            label1.Text = AppDomain.CurrentDomain.BaseDirectory + "R6AC.dat";
            //writer.Write(ProcessInfo);
            //writer.Close();
        }
    }
}
