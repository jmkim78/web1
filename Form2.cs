using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FDS10Client_Setup
{
    public partial class Form2 : Form
    {
        string folderPath;
        public static string sDirPath = "C:\\Program Files (x86)\\FDS_10";
        public static string sDirPath2;
        public static string sDirPath3;
        public static string sDirPath4;
        public static string sDirPath5;
        public static string sDirPath6;
        public static string sDirPath7;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DriveInfo drv = new DriveInfo("C");
            label7.Text = "남은 디스크 용량 : " + (drv.AvailableFreeSpace / 1000000000).ToString("00.00") + "GB";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform.step = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(sDirPath);

            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }


            sDirPath2 = sDirPath + "\\Content";
            di = new DirectoryInfo(sDirPath2);
           
            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }

            sDirPath3 = sDirPath + "\\Fonts";
            di = new DirectoryInfo(sDirPath3);

            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }

            sDirPath4 = sDirPath + "\\Shaders";
            di = new DirectoryInfo(sDirPath4);

            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }

            sDirPath5 = sDirPath + "\\Xml";
            di = new DirectoryInfo(sDirPath5);

            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }

            sDirPath6 = sDirPath2 + "\\ColorSource";
            di = new DirectoryInfo(sDirPath6);

            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }

            sDirPath7 = sDirPath2 + "\\Cubemap";
            di = new DirectoryInfo(sDirPath7);

            if (di.Exists == true)
            {
                foreach (FileInfo file in di.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                di.Create();
            }

            if (di.Exists == false)
            {
                di.Create();
            }

            Mainform.step = "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath = fbd.SelectedPath;
                sDirPath = folderPath + "\\FDS_10";

                textBox1.Text = sDirPath;
            }
        }
    }
}
