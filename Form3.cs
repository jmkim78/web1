using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDS10Client_Setup
{
    public partial class Form3 : Form
    {
        Form2 form2 = new Form2();
        string filepath = Form2.sDirPath;
        string filepath2 = Form2.sDirPath2;
        string filepath3 = Form2.sDirPath3;
        string filepath4 = Form2.sDirPath4;
        string filepath5 = Form2.sDirPath5;
        string filepath6 = Form2.sDirPath6;
        string filepath7 = Form2.sDirPath7;

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform.step = "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateProgressDelegate UpdateProgress = new UpdateProgressDelegate(UpdateProgressSafe);

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;


            progressBar1.Invoke(UpdateProgress, new object[] { 0 });
            installfile("BouncyCastle.Crypto.dll");
            installfile("C1.C1Excel.4.5.2.dll");
            installfile("C1.C1Zip.4.5.2.dll");
            installfile("C1.Win.4.5.2.dll");
            installfile("C1.Win.Bitmap.4.5.2.dll");
            installfile("C1.Win.C1Chart.4.5.2.dll");
            installfile("C1.Win.C1Command.4.5.2.dll");
            installfile("C1.Win.C1DX.4.5.2.dll");
            installfile("C1.Win.C1FlexGrid.4.5.2.dll");
            installfile("C1.Win.C1FlexGrid.GroupPanel.4.5.2.dll");
            installfile("C1.Win.C1Gauge.4.5.2.dll");
            installfile("C1.Win.C1Input.4.5.2.dll");
            installfile("C1.Win.C1InputPanel.4.5.2.dll");
            installfile("C1.Win.C1SplitContainer.4.5.2.dll");
            installfile("C1.Win.C1SuperTooltip.4.5.2.dll");
            installfile("C1.Win.C1TileControl.4.5.2.dll");
            installfile("C1.Win.DashboardLayout.4.5.2.dll");
            installfile("C1.Win.Ribbon.4.5.2.dll");
            installfile("C1.Win.TreeView.4.5.2.dll");
            installfile("DbManager.dll");
            installfile("FDS10.exe");
            installfile("FDS10.exe.config");
            installfile("Grapher.ico");
            installfile("MySql.Data.dll");
            installfile("NLog.dll");
            installfile("OpenTK.dll");
            installfile("OpenTK.GLControl.dll");
            installfile("Renci.SshNet.dll");
            installfile("SourceGrid.dll");
            installfile("System.IO.Compression.dll");
            installfile("System.Net.Http.dll");
            installfile("Ubiety.Dns.Core.dll");
            installfile("ZedGraph.dll");
            installfileContent("cube-kidong.mtl");
            installfileContent("cube-kidong.obj");
            installfileContent("cube-part2.obj");
            installfileContent("txt.bmp");
            installfileContent("txt2.bmp");
            installfileContent("txt3.bmp");
            installfileContent("txt4.bmp");
            installfileContent("txt5.bmp");
            installfileContent("txt6.bmp");
            installfileContent("untitled.mtl");
            installfileContent("untitled.obj");
            installfileFonts("Anonymous Pro.ttf");
            installfileShaders("gui.frag");
            installfileShaders("gui.vert");
            installfileShaders("pick.frag");
            installfileShaders("pick.vert");
            installfileShaders("shader.frag");
            installfileShaders("shader.vert");
            installfileXml("SystemConfig.xml");
            installfileColorSource("ColorSource.bmp");
            installfileCubemap("back - 복사본.png");
            installfileCubemap("back.png");

            installfileCubemap("bottom - 복사본.png");
            installfileCubemap("bottom.png");

            installfileCubemap("front - 복사본.png");
            installfileCubemap("front.png");

            installfileCubemap("left - 복사본.png");
            installfileCubemap("left.png");

            installfileCubemap("right - 복사본.png");
            installfileCubemap("right.png");

            installfileCubemap("top - 복사본.png");
            installfileCubemap("top.png");


            progressBar1.Invoke(UpdateProgress, new object[] { 100 });

            label1.Text = "설치 완료";
            label6.Text = "Thermal_System 1.0 의 설치가 완료되었습니다. '다음 >' 버튼을 눌러주세요.";
            button4.BringToFront();
        }

        private void installfile(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources." + i_filename);
            FileStream fileStream = new FileStream(filepath + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void installfileContent(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources.Content." + i_filename);
            FileStream fileStream = new FileStream(filepath2 + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void installfileFonts(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources.Fonts." + i_filename);
            FileStream fileStream = new FileStream(filepath3 + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void installfileShaders(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources.Shaders." + i_filename);
            FileStream fileStream = new FileStream(filepath4 + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void installfileXml(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources.Xml." + i_filename);
            FileStream fileStream = new FileStream(filepath5 + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void installfileColorSource(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources.Content.ColorSource." + i_filename);
            FileStream fileStream = new FileStream(filepath6 + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void installfileCubemap(string i_filename)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FDS10Client_Setup.Resources.Content.Cubemap." + i_filename);
            FileStream fileStream = new FileStream(filepath7 + @"\" + i_filename, FileMode.CreateNew);

            for (int i = 0; i < stream.Length; i++)
                fileStream.WriteByte((byte)stream.ReadByte());
            fileStream.Close();

            listBox1.Items.Add(i_filename + " 설치 완료");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainform.step = "4";
        }

        void UpdateProgressSafe(int value)
        {
            this.progressBar1.Value = value;
        }
        delegate void UpdateProgressDelegate(int value);
    }
}
