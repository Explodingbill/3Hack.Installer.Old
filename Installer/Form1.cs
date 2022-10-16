using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Form1 : Form
    {
        public string dashPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            client.DownloadDataCompleted += new DownloadDataCompletedEventHandler(client_DownloadDataCompleted);

            string execPath = AppDomain.CurrentDomain.BaseDirectory;

            client.DownloadDataAsync(new Uri("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip"), execPath + "\\newfile.zip");

            /*(using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip", @"C:\Users\talgo\Downloads\E.zi");
            }*/
        }

        void client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");

            string execPath = AppDomain.CurrentDomain.BaseDirectory;

            if (!File.Exists(execPath + "\\newfile.zip"))
            {
                File.Create(execPath + "\\newfile.zip");
            }

            File.WriteAllBytes(execPath + "\\newfile.zip", e.Result);//
        }



        //DRAGABLE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "3Dash Executable (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    
                    DoMelonLoader(filePath, "3Dash.exe");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void DoMelonLoader(string path, string exeName)
        {
            dashPath = path.Replace(exeName, "");
            installInfo.Text = path;

            string melonPath = path.Replace(exeName, "MelonLoader");

            installInfo.Text = melonPath;

            if (Directory.Exists(melonPath))
            {
                installInfo.Text = "Found MelonLoader";
                InstallMenu();
            }
            else
            {
                if (File.Exists(dashPath + "Melonx64.zip"))
                {
                    ExtractMelonLoader();
                }
                else
                {
                    installInfo.Text = "Couldn't Find MelonLoader, Installing";

                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.4/MelonLoader.x64.zip", dashPath + "Melonx64.zip");

                        installInfo.Text = "Download Complete, Installing";

                        ExtractMelonLoader();
                    }
                }
            }
        }

        public void ExtractMelonLoader()
        {
            installInfo.Text = "Extracting MelonLoader";
            ZipFile.ExtractToDirectory(dashPath + "Melonx64.zip", dashPath);
            installInfo.Text = "Success Installing MelonLoader, Downloading Menu";

            File.Delete(dashPath + "Melonx64.zip");

            InstallMenu();
        }

        public void InstallMenu()
        {
            string url = "https://github.com/Underkirby/3Hack/releases/latest/Hacks.dll";

            using (var client = new WebClient())
            {
                if (!Directory.Exists(dashPath + "/Mods/"))
                {
                    Directory.CreateDirectory(dashPath + "/Mods/");
                }
                else
                {
                    if (File.Exists(dashPath + "/Mods/Hacks.dll"))
                    {
                        File.Delete(dashPath + "/Mods/Hacks.dll");
                    }
                }

                client.DownloadFile(url, dashPath + "/Mods/Hacks.dll");

                installInfo.Text = "Menu Download Part 1 Complete";
            }

            string url2 = "https://github.com/Underkirby/3Hack/releases/latest/DiscordRPC.dll";

            using (var client2 = new WebClient())
            {
                if (!Directory.Exists(dashPath + "/UserLibs/"))
                {
                    Directory.CreateDirectory(dashPath + "/UserLibs/");
                }
                else
                {
                    if (File.Exists(dashPath + "/UserLibs/DiscordRPC.dll"))
                    {
                        File.Delete(dashPath + "/UserLibs/DiscordRPC.dll");
                    }
                }

                client2.DownloadFile(url2, dashPath + "/UserLibs/DiscordRPC.dll");

                installInfo.Text = "Successfully Downloaded Mod Menu";
            }
        }
    }
}
