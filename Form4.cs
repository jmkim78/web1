using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDS10Client_Setup
{
    public partial class Form4 : Form
    {
        public string dbip { get; set; } = "192.168.1.206";
        public int Port { get; set; } = 1433;
        public string DBName { get; set; } = "DB_FDS10";
        public string dbID { get; set; } = "sa";
        public string dbPassword { get; set; } = "1234";

        public Form4()
        {
            InitializeComponent();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dbip = textBox1.Text;

                SchemaDelete();
                SchemaCreate();
                DBE("IF OBJECT_ID('DB_FDS10.dbo.AliveCheck_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.AliveCheck_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.AliveCheck_Table([Check_DateTime] [datetime] NOT NULL,[AliveCheck] [bit] NOT NULL) ON [PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.CMD_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.CMD_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.CMD_Table([Index] [int] IDENTITY(1,1) NOT NULL,[CMD] [varchar](50) NULL,[Type] [varchar](50) NULL,[BANK_ID] [varchar](10) NULL,[DAD_ID] [varchar](10) NULL,[Sensor_ID] [varchar](10) NULL,[Bay_No] [smallint] NULL,[Level_No] [smallint] NULL,[Value] [smallint] NULL, CONSTRAINT [PK_CMD_Table] PRIMARY KEY CLUSTERED ([Index] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.DADSensorData_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.DADSensorData_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.DADSensorData_Table([Index][int] NOT NULL,[BANK_ID][varchar](10) NULL,[DAD_ID][varchar](10) NULL,[DAD_Name][varchar](20) NULL,[Status_1][int] NULL,[Temp_1][float] NULL,[Humi_1][float] NULL,[Status_2][int] NULL,[Temp_2][float] NULL,[Humi_2][float] NULL,[Status_3][int] NULL,[Temp_3][float] NULL,[Humi_3][float] NULL,[Status_4][int] NULL,[Temp_4][float] NULL,[Humi_4][float] NULL,[Status_5][int] NULL,[Temp_5][float] NULL,[Humi_5][float] NULL,[Status_6][int] NULL,[Temp_6][float] NULL,[Humi_6][float] NULL,[Status_7][int] NULL,[Temp_7][float] NULL,[Humi_7][float] NULL,[Status_8][int] NULL,[Temp_8][float] NULL,[Humi_8][float] NULL,[Status_9][int] NULL,[Temp_9][float] NULL,[Humi_9][float] NULL,[Status_10][int] NULL,[Temp_10][float] NULL,[Humi_10][float] NULL,[Status_11][int] NULL,[Temp_11][float] NULL,[Humi_11][float] NULL,[Status_12][int] NULL,[Temp_12][float] NULL,[Humi_12][float] NULL,[Status_13][int] NULL,[Temp_13][float] NULL,[Humi_13][float] NULL,[Status_14][int] NULL,[Temp_14][float] NULL,[Humi_14][float] NULL,[Status_15][int] NULL,[Temp_15][float] NULL,[Humi_15][float] NULL,[Status_16][int] NULL,[Temp_16][float] NULL,[Humi_16][float] NULL,[Status_17][int] NULL,[Temp_17][float] NULL,[Humi_17][float] NULL,[Status_18][int] NULL,[Temp_18][float] NULL,[Humi_18][float] NULL,[Status_19][int] NULL,[Temp_19][float] NULL,[Humi_19][float] NULL,[Status_20][int] NULL,[Temp_20][float] NULL,[Humi_20][float] NULL,[Status_21][int] NULL,[Temp_21][float] NULL,[Humi_21][float] NULL,[Status_22][int] NULL,[Temp_22][float] NULL,[Humi_22][float] NULL,[Status_23][int] NULL,[Temp_23][float] NULL,[Humi_23][float] NULL,[Status_24][int] NULL,[Temp_24][float] NULL,[Humi_24][float] NULL,[Status_25][int] NULL,[Temp_25][float] NULL,[Humi_25][float] NULL,[Status_26][int] NULL,[Temp_26][float] NULL,[Humi_26][float] NULL,[Status_27][int] NULL,[Temp_27][float] NULL,[Humi_27][float] NULL,[Status_28][int] NULL,[Temp_28][float] NULL,[Humi_28][float] NULL,[Status_29][int] NULL,[Temp_29][float] NULL,[Humi_29][float] NULL,[Status_30][int] NULL,[Temp_30][float] NULL,[Humi_30][float] NULL,[Status_31][int] NULL,[Temp_31][float] NULL,[Humi_31][float] NULL,[Status_32][int] NULL,[Temp_32][float] NULL,[Humi_32][float] NULL,[Status_33][int] NULL,[Temp_33][float] NULL,[Humi_33][float] NULL,[Status_34][int] NULL,[Temp_34][float] NULL,[Humi_34][float] NULL,[Status_35][int] NULL,[Temp_35][float] NULL,[Humi_35][float] NULL,[Status_36][int] NULL,[Temp_36][float] NULL,[Humi_36][float] NULL,[Status_37][int] NULL,[Temp_37][float] NULL,[Humi_37][float] NULL,[Status_38][int] NULL,[Temp_38][float] NULL,[Humi_38][float] NULL,[Status_39][int] NULL,[Temp_39][float] NULL,[Humi_39][float] NULL,[Status_40][int] NULL,[Temp_40][float] NULL,[Humi_40][float] NULL,[Status_41][int] NULL,[Temp_41][float] NULL,[Humi_41][float] NULL,[Status_42][int] NULL,[Temp_42][float] NULL,[Humi_42][float] NULL,[Status_43][int] NULL,[Temp_43][float] NULL,[Humi_43][float] NULL,[Status_44][int] NULL,[Temp_44][float] NULL,[Humi_44][float] NULL,[Status_45][int] NULL,[Temp_45][float] NULL,[Humi_45][float] NULL,[Status_46][int] NULL,[Temp_46][float] NULL,[Humi_46][float] NULL,[Status_47][int] NULL,[Temp_47][float] NULL,[Humi_47][float] NULL,[Status_48][int] NULL,[Temp_48][float] NULL,[Humi_48][float] NULL,[Status_49][int] NULL,[Temp_49][float] NULL,[Humi_49][float] NULL,[Status_50][int] NULL,[Temp_50][float] NULL,[Humi_50][float] NULL,[Status_51][int] NULL,[Temp_51][float] NULL,[Humi_51][float] NULL,[Status_52][int] NULL,[Temp_52][float] NULL,[Humi_52][float] NULL,[Status_53][int] NULL,[Temp_53][float] NULL,[Humi_53][float] NULL,[Status_54][int] NULL,[Temp_54][float] NULL,[Humi_54][float] NULL,[Status_55][int] NULL,[Temp_55][float] NULL,[Humi_55][float] NULL,[Status_56][int] NULL,[Temp_56][float] NULL,[Humi_56][float] NULL,[Status_57][int] NULL,[Temp_57][float] NULL,[Humi_57][float] NULL,[Status_58][int] NULL,[Temp_58][float] NULL,[Humi_58][float] NULL,[Status_59][int] NULL,[Temp_59][float] NULL,[Humi_59][float] NULL,[Status_60][int] NULL,[Temp_60][float] NULL,[Humi_60][float] NULL,[Status_61][int] NULL,[Temp_61][float] NULL,[Humi_61][float] NULL,[Status_62][int] NULL,[Temp_62][float] NULL,[Humi_62][float] NULL,[Status_63][int] NULL,[Temp_63][float] NULL,[Humi_63][float] NULL,[Status_64][int] NULL,[Temp_64][float] NULL,[Humi_64][float] NULL,[Status_65][int] NULL,[Temp_65][float] NULL,[Humi_65][float] NULL,[Status_66][int] NULL,[Temp_66][float] NULL,[Humi_66][float] NULL,[Status_67][int] NULL,[Temp_67][float] NULL,[Humi_67][float] NULL,[Status_68][int] NULL,[Temp_68][float] NULL,[Humi_68][float] NULL,[Status_69][int] NULL,[Temp_69][float] NULL,[Humi_69][float] NULL,[Status_70][int] NULL,[Temp_70][float] NULL,[Humi_70][float] NULL,[Status_71][int] NULL,[Temp_71][float] NULL,[Humi_71][float] NULL,[Status_72][int] NULL,[Temp_72][float] NULL,[Humi_72][float] NULL,[Status_73][int] NULL,[Temp_73][float] NULL,[Humi_73][float] NULL,[Status_74][int] NULL,[Temp_74][float] NULL,[Humi_74][float] NULL,[Status_75][int] NULL,[Temp_75][float] NULL,[Humi_75][float] NULL,[Status_76][int] NULL,[Temp_76][float] NULL,[Humi_76][float] NULL,[Status_77][int] NULL,[Temp_77][float] NULL,[Humi_77][float] NULL,[Status_78][int] NULL,[Temp_78][float] NULL,[Humi_78][float] NULL,[Status_79][int] NULL,[Temp_79][float] NULL,[Humi_79][float] NULL,[Status_80][int] NULL,[Temp_80][float] NULL,[Humi_80][float] NULL,[Status_81][int] NULL,[Temp_81][float] NULL,[Humi_81][float] NULL,[Status_82][int] NULL,[Temp_82][float] NULL,[Humi_82][float] NULL,[Status_83][int] NULL,[Temp_83][float] NULL,[Humi_83][float] NULL,[Status_84][int] NULL,[Temp_84][float] NULL,[Humi_84][float] NULL,[Status_85][int] NULL,[Temp_85][float] NULL,[Humi_85][float] NULL,[Status_86][int] NULL,[Temp_86][float] NULL,[Humi_86][float] NULL,[Status_87][int] NULL,[Temp_87][float] NULL,[Humi_87][float] NULL,[Status_88][int] NULL,[Temp_88][float] NULL,[Humi_88][float] NULL,[Status_89][int] NULL,[Temp_89][float] NULL,[Humi_89][float] NULL,[Status_90][int] NULL,[Temp_90][float] NULL,[Humi_90][float] NULL,[Status_91][int] NULL,[Temp_91][float] NULL,[Humi_91][float] NULL,[Status_92][int] NULL,[Temp_92][float] NULL,[Humi_92][float] NULL,[Status_93][int] NULL,[Temp_93][float] NULL,[Humi_93][float] NULL,[Status_94][int] NULL,[Temp_94][float] NULL,[Humi_94][float] NULL,[Status_95][int] NULL,[Temp_95][float] NULL,[Humi_95][float] NULL,[Status_96][int] NULL,[Temp_96][float] NULL,[Humi_96][float] NULL,[Status_97][int] NULL,[Temp_97][float] NULL,[Humi_97][float] NULL,[Status_98][int] NULL,[Temp_98][float] NULL,[Humi_98][float] NULL,[Status_99][int] NULL,[Temp_99][float] NULL,[Humi_99][float] NULL,[Status_100][int] NULL,[Temp_100][float] NULL,[Humi_100][float] NULL,[Status_101][int] NULL,[Temp_101][float] NULL,[Humi_101][float] NULL,[Status_102][int] NULL,[Temp_102][float] NULL,[Humi_102][float] NULL,[Status_103][int] NULL,[Temp_103][float] NULL,[Humi_103][float] NULL,[Status_104][int] NULL,[Temp_104][float] NULL,[Humi_104][float] NULL,[Status_105][int] NULL,[Temp_105][float] NULL,[Humi_105][float] NULL,[Status_106][int] NULL,[Temp_106][float] NULL,[Humi_106][float] NULL,[Status_107][int] NULL,[Temp_107][float] NULL,[Humi_107][float] NULL,[Status_108][int] NULL,[Temp_108][float] NULL,[Humi_108][float] NULL,[Status_109][int] NULL,[Temp_109][float] NULL,[Humi_109][float] NULL,[Status_110][int] NULL,[Temp_110][float] NULL,[Humi_110][float] NULL,[Status_111][int] NULL,[Temp_111][float] NULL,[Humi_111][float] NULL,[Status_112][int] NULL,[Temp_112][float] NULL,[Humi_112][float] NULL,[Status_113][int] NULL,[Temp_113][float] NULL,[Humi_113][float] NULL,[Status_114][int] NULL,[Temp_114][float] NULL,[Humi_114][float] NULL,[Status_115][int] NULL,[Temp_115][float] NULL,[Humi_115][float] NULL,[Status_116][int] NULL,[Temp_116][float] NULL,[Humi_116][float] NULL,[Status_117][int] NULL,[Temp_117][float] NULL,[Humi_117][float] NULL,[Status_118][int] NULL,[Temp_118][float] NULL,[Humi_118][float] NULL,[Status_119][int] NULL,[Temp_119][float] NULL,[Humi_119][float] NULL,[Status_120][int] NULL,[Temp_120][float] NULL,[Humi_120][float] NULL,[Status_121][int] NULL,[Temp_121][float] NULL,[Humi_121][float] NULL,[Status_122][int] NULL,[Temp_122][float] NULL,[Humi_122][float] NULL,[Status_123][int] NULL,[Temp_123][float] NULL,[Humi_123][float] NULL,[Status_124][int] NULL,[Temp_124][float] NULL,[Humi_124][float] NULL,[Status_125][int] NULL,[Temp_125][float] NULL,[Humi_125][float] NULL,[Status_126][int] NULL,[Temp_126][float] NULL,[Humi_126][float] NULL,[Status_127][int] NULL,[Temp_127][float] NULL,[Humi_127][float] NULL,[Status_128][int] NULL,[Temp_128][float] NULL,[Humi_128][float] NULL,[Status_129][int] NULL,[Temp_129][float] NULL,[Humi_129][float] NULL,[Status_130][int] NULL,[Temp_130][float] NULL,[Humi_130][float] NULL,[Status_131][int] NULL,[Temp_131][float] NULL,[Humi_131][float] NULL,[Status_132][int] NULL,[Temp_132][float] NULL,[Humi_132][float] NULL,[Status_133][int] NULL,[Temp_133][float] NULL,[Humi_133][float] NULL,[Status_134][int] NULL,[Temp_134][float] NULL,[Humi_134][float] NULL,[Status_135][int] NULL,[Temp_135][float] NULL,[Humi_135][float] NULL,[Status_136][int] NULL,[Temp_136][float] NULL,[Humi_136][float] NULL,[Status_137][int] NULL,[Temp_137][float] NULL,[Humi_137][float] NULL,[Status_138][int] NULL,[Temp_138][float] NULL,[Humi_138][float] NULL,[Status_139][int] NULL,[Temp_139][float] NULL,[Humi_139][float] NULL,[Status_140][int] NULL,[Temp_140][float] NULL,[Humi_140][float] NULL,[Status_141][int] NULL,[Temp_141][float] NULL,[Humi_141][float] NULL,[Status_142][int] NULL,[Temp_142][float] NULL,[Humi_142][float] NULL,[Status_143][int] NULL,[Temp_143][float] NULL,[Humi_143][float] NULL,[Status_144][int] NULL,[Temp_144][float] NULL,[Humi_144][float] NULL,[Status_145][int] NULL,[Temp_145][float] NULL,[Humi_145][float] NULL,[Status_146][int] NULL,[Temp_146][float] NULL,[Humi_146][float] NULL,[Status_147][int] NULL,[Temp_147][float] NULL,[Humi_147][float] NULL,[Status_148][int] NULL,[Temp_148][float] NULL,[Humi_148][float] NULL,[Status_149][int] NULL,[Temp_149][float] NULL,[Humi_149][float] NULL,[Status_150][int] NULL,[Temp_150][float] NULL,[Humi_150][float] NULL,[Status_151][int] NULL,[Temp_151][float] NULL,[Humi_151][float] NULL,[Status_152][int] NULL,[Temp_152][float] NULL,[Humi_152][float] NULL,[Status_153][int] NULL,[Temp_153][float] NULL,[Humi_153][float] NULL,[Status_154][int] NULL,[Temp_154][float] NULL,[Humi_154][float] NULL,[Status_155][int] NULL,[Temp_155][float] NULL,[Humi_155][float] NULL,[Status_156][int] NULL,[Temp_156][float] NULL,[Humi_156][float] NULL,[Status_157][int] NULL,[Temp_157][float] NULL,[Humi_157][float] NULL,[Status_158][int] NULL,[Temp_158][float] NULL,[Humi_158][float] NULL,[Status_159][int] NULL,[Temp_159][float] NULL,[Humi_159][float] NULL,[Status_160][int] NULL,[Temp_160][float] NULL,[Humi_160][float] NULL,[Status_161][int] NULL,[Temp_161][float] NULL,[Humi_161][float] NULL,[Status_162][int] NULL,[Temp_162][float] NULL,[Humi_162][float] NULL,[Status_163][int] NULL,[Temp_163][float] NULL,[Humi_163][float] NULL,[Status_164][int] NULL,[Temp_164][float] NULL,[Humi_164][float] NULL,[Status_165][int] NULL,[Temp_165][float] NULL,[Humi_165][float] NULL,[Status_166][int] NULL,[Temp_166][float] NULL,[Humi_166][float] NULL,[Status_167][int] NULL,[Temp_167][float] NULL,[Humi_167][float] NULL,[Status_168][int] NULL,[Temp_168][float] NULL,[Humi_168][float] NULL,[Status_169][int] NULL,[Temp_169][float] NULL,[Humi_169][float] NULL,[Status_170][int] NULL,[Temp_170][float] NULL,[Humi_170][float] NULL,[Status_171][int] NULL,[Temp_171][float] NULL,[Humi_171][float] NULL,[Status_172][int] NULL,[Temp_172][float] NULL,[Humi_172][float] NULL,[Status_173][int] NULL,[Temp_173][float] NULL,[Humi_173][float] NULL,[Status_174][int] NULL,[Temp_174][float] NULL,[Humi_174][float] NULL,[Status_175][int] NULL,[Temp_175][float] NULL,[Humi_175][float] NULL,[Status_176][int] NULL,[Temp_176][float] NULL,[Humi_176][float] NULL,[Status_177][int] NULL,[Temp_177][float] NULL,[Humi_177][float] NULL,[Status_178][int] NULL,[Temp_178][float] NULL,[Humi_178][float] NULL,[Status_179][int] NULL,[Temp_179][float] NULL,[Humi_179][float] NULL,[Status_180][int] NULL,[Temp_180][float] NULL,[Humi_180][float] NULL,[Status_181][int] NULL,[Temp_181][float] NULL,[Humi_181][float] NULL,[Status_182][int] NULL,[Temp_182][float] NULL,[Humi_182][float] NULL,[Status_183][int] NULL,[Temp_183][float] NULL,[Humi_183][float] NULL,[Status_184][int] NULL,[Temp_184][float] NULL,[Humi_184][float] NULL,[Status_185][int] NULL,[Temp_185][float] NULL,[Humi_185][float] NULL,[Status_186][int] NULL,[Temp_186][float] NULL,[Humi_186][float] NULL,[Status_187][int] NULL,[Temp_187][float] NULL,[Humi_187][float] NULL,[Status_188][int] NULL,[Temp_188][float] NULL,[Humi_188][float] NULL,[Status_189][int] NULL,[Temp_189][float] NULL,[Humi_189][float] NULL,[Status_190][int] NULL,[Temp_190][float] NULL,[Humi_190][float] NULL,[Status_191][int] NULL,[Temp_191][float] NULL,[Humi_191][float] NULL,[Status_192][int] NULL,[Temp_192][float] NULL,[Humi_192][float] NULL) ON [PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.DADtoHistoryName_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.DADtoHistoryName_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.DADtoHistoryName_Table([Index][int] NOT NULL, [BANK_ID][varchar](10) NULL, [DAD_ID][varchar](10) NULL, [DAD_Name][varchar](20) NULL, [HistoryTable_Name][varchar](50) NULL) ON[PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.Group_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.Group_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.Group_Table([Rack_ID][varchar](10) NOT NULL, [Rack_Name][varchar](20) NULL, [Remark][varchar](50) NULL) ON[PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.GroupSub_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.GroupSub_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.GroupSub_Table([Rack_ID][varchar](10) NULL, [RackSub_ID][varchar](10) NULL, [RackSub_Name][varchar](20) NULL, [Remark][varchar](50) NULL, [IsInLine][bit] NULL) ON[PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.Info_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.Info_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.Info_Table([Index][int] NOT NULL, [BANK_ID][varchar](10) NOT NULL, [DAD_ID][varchar](10) NOT NULL, [DAD_Name][varchar](20) NULL,    [RackSub_ID][varchar](50) NULL,    [IP][varchar](50) NULL,    [SubNetMask][varchar](50) NULL,    [Gateway][varchar](50) NULL,    [DestPort][varchar](50) NULL,    [DAD_Bank][smallint] NULL,    [DAD_MaxBay][smallint] NULL,    [DAD_MaxLevel][smallint] NULL,    [DAD_Status][smallint] NULL,    [DAD_ErrorStatus][smallint] NULL,    [DAD_Temp][float] NULL,    [DAD_Humi][float] NULL,    [Remark][varchar](50) NULL) ON [PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.Log_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.Log_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.Log_Table(    [Index][int] NOT NULL,    [BANK_ID][varchar](10) NULL,    [DAD_ID][varchar](10) NULL,    [DAD_Name][varchar](20) NULL,    [Sensor_ID][varchar](10) NULL,    [Event_Type][int] NULL,    [Start_DateTime][datetime] NULL,    [End_DateTime][datetime] NULL,    [Temp][float] NULL,    [Humi][float] NULL,    [Temp_W][float] NULL,    [Temp_A][float] NULL) ON[PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.MatrixView_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.MatrixView_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.MatrixView_Table(    [Index][int] NOT NULL,    [BANK_ID][varchar](10) NULL,    [Matrix_Num][varchar](10) NULL,    [DAD_ID][varchar](10) NULL,    [DAD_Name][varchar](20) NULL,    [Sensor_ID][varchar](10) NULL,    [Rack_ID][varchar](10) NULL,    [Rack_Name][varchar](20) NULL,    [RackSub_ID][varchar](10) NULL,    [RackSub_Name][varchar](20) NULL,    [Bank_No][smallint] NULL,    [Bay_No][smallint] NULL,    [Level_No][smallint] NULL,    [Use_Check][bit] NULL) ON[PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.SensorSetData_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.SensorSetData_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.SensorSetData_Table(    [Index][int] NOT NULL,    [BANK_ID][varchar](10) NULL,    [DAD_ID][varchar](10) NULL,    [DAD_Name][varchar](20) NULL,    [Sensor_ID][varchar](10) NULL,    [ResetCount][smallint] NULL,    [Temp_Offset][float] NULL,    [Humi_Offset][float] NULL,    [Temp_Warning][float] NULL,    [Temp_Alarm][float] NULL,    [ClassNo][smallint] NULL) ON[PRIMARY]");
                DBE("IF OBJECT_ID('DB_FDS10.dbo.User_Table', 'u') IS NOT NULL DROP TABLE DB_FDS10.dbo.User_Table");
                DBE("CREATE TABLE DB_FDS10.dbo.User_Table(    [User_ID][varchar](50) NOT NULL,    [User_Name][varchar](50) NULL,    [Password][varchar](50) NULL,    [Level][smallint] NULL) ON[PRIMARY]");
            }
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string GetConnectionString()
        {
            //oledb 컴퓨터 이름으로 접속
            //return @"Provider=SQLOLEDB;Data Source=DESKTOP-DC02TMB\SQLEXPRESS;Initial Catalog=Particle;User ID=sa;Password=1234";
            //oledb IP 로 접속 Source 변경
            string s = string.Format($"Provider=SQLOLEDB;Data Source={dbip};User ID={dbID};Password={dbPassword}");
            return s;
            //sqlclient 
            // return @"Data Source=DESKTOP-DC02TMB\SQLEXPRESS;Initial Catalog=Particle;User ID=sa;Password=1234";
        }

        public int SchemaDelete() //Schema Drop
        {
            int Results = 0;
            DbManager dbmanager = new DbManager("System.Data.OleDb", GetConnectionString());
            try
            {
                Results = dbmanager.Execute("DROP DATABASE IF EXISTS DB_FDS10");
            }
            catch
            {
                MessageBox.Show("Schema Delete Error");
            }
            return Results;
        }

        public int SchemaCreate() //Schema Create
        {
            int Results = 0;
            DbManager dbmanager = new DbManager("System.Data.OleDb", GetConnectionString());
            try
            {
                Results = dbmanager.Execute("Create Database DB_FDS10");
            }
            catch
            {
                MessageBox.Show("Schema Create Error");
            }
            return Results;
        }

        public int DBE(string sql_input) //Table Create
        {
            int Results = 0;
            DbManager dbmanager = new DbManager("System.Data.OleDb", GetConnectionString());
            try
            {
                Results = dbmanager.Execute(sql_input);
            }
            catch
            {
                MessageBox.Show("Table Create Error");
            }
            return Results;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
      
        }
    }
}
