using System.Diagnostics;
using System.IO;
using System.Text;

namespace starter
{
    public partial class Form1 : Form
    {
        String lanchPath_ys = null;
        String lanchPath_td = null;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public class Config
        {
            [System.Runtime.InteropServices.DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            [System.Runtime.InteropServices.DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

            public void configWrite(string section, string key, string value, string path)
            {
                // section=配置节点名称，key=键名，value=返回键值，path=路径
                WritePrivateProfileString(section, key, value, path);
            }

            //读取INI的方法
            public string configRead(string section, string key, string path)
            {
                StringBuilder temp = new StringBuilder(255);

                GetPrivateProfileString(section, key, "", temp, 255, path);
                return temp.ToString();
            }

            public void configDelete(string FilePath)
            {
                File.Delete(FilePath);
            }
        }

        public class LancherSelector
        {
            int delnum;
            int delnum2;
            string lancherName;
            PictureBox pictureBox;
            Button button;
            string bgName;
            public string path = null;

            public LancherSelector(int delnum, int delnum2, string lancherName, PictureBox pictureBox, Button button, string bgName)
            {
                this.delnum = delnum;
                this.lancherName = lancherName;
                this.pictureBox = pictureBox;
                this.button = button;
                this.bgName = bgName;
                this.delnum2 = delnum2;
            }
            public void SearchLancher()//"YuanShen.exe"
            {
                button.Text = "加载中...";
                //TO DO 自动获取启动程序路径
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    string d_name = d.Name;
                    string result = SearchForFile(d_name, lancherName);
                    if (result != null)
                    {
                        path = result[..^delnum];
                        Config config = new Config();
                        config.configWrite("Path_Record", lancherName, path, Environment.CurrentDirectory + "\\config.ini");
                        break;
                    }
                }
                Loadbg(path, delnum2, pictureBox, button, bgName);
                GC.Collect();
            }
        }

        LancherSelector ls_ys;
        LancherSelector ls_td;
        private void Form1_Load(object sender, EventArgs e)
        {
            string config_path = Environment.CurrentDirectory + "\\config.ini";
            Config config = new Config();
            if (File.Exists(config_path))
            {
                lanchPath_ys = config.configRead("Path_Record", "YuanShen.exe", config_path);
                lanchPath_td = config.configRead("Path_Record", "StarRail.exe", config_path);
                if (lanchPath_ys != null && lanchPath_ys != "")
                {
                    Loadbg(lanchPath_ys, 20, pictureBox1, ys, "ys.png");
                }
                else
                {
                    ls_ys = new LancherSelector(13, 20, "YuanShen.exe", pictureBox1, ys, "ys.png");
                    Thread thread_ys = new Thread(new ThreadStart(ls_ys.SearchLancher));
                    thread_ys.Start();
                }

                if (lanchPath_td != null && lanchPath_td != "")
                {
                    Loadbg(lanchPath_td, 5, pictureBox2, xqtd, "td.png");
                }
                else
                {
                    ls_td = new LancherSelector(13, 5, "StarRail.exe", pictureBox2, xqtd, "td.png");
                    Thread thread_td = new Thread(new ThreadStart(ls_td.SearchLancher));
                    thread_td.Start();
                }
            }
            else
            {
                ls_ys = new LancherSelector(13, 20, "YuanShen.exe", pictureBox1, ys, "ys.png");
                Thread thread_ys = new Thread(new ThreadStart(ls_ys.SearchLancher));
                thread_ys.Start();

                ls_td = new LancherSelector(13, 5, "StarRail.exe", pictureBox2, xqtd, "td.png");
                Thread thread_td = new Thread(new ThreadStart(ls_td.SearchLancher));
                thread_td.Start();
            }



            //SearchLancher(out lanchPath_ys, 13, "YuanShen.exe");
            //SearchLancher(out lanchPath_td, 13, "StarRail.exe");

            //lanchPath_ys = "E:\\Genshin Impact\\Genshin Impact Game";
            //Loadbg(lanchPath_ys, 20, pictureBox1, ys, "ys.png");
            //lanchPath_td = "E:\\Star Rail\\Game";
            //Loadbg(lanchPath_td, 5, pictureBox2, xqtd, "td.png");
        }

        private static void Loadbg(string lanchpath, int delnum, PictureBox pictureBox, Button button, string bgName)
        {
            if (lanchpath != null)
            {
                try
                {
                    string bgPath = lanchpath[..^delnum];
                    string[] picPath = Directory.GetFiles(bgPath + "\\bg", "*.png", searchOption: SearchOption.AllDirectories);
                    if (picPath.Length > 1)
                    {
                        Random r = new Random();
                        pictureBox.Image = Image.FromFile(picPath[r.Next(0, picPath.Length)]);

                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(picPath[0]);
                    }
                    button.Font = new Font("微软雅黑", 14);
                    button.Text = "开始游戏";
                    button.Enabled = true;
                }
                catch (Exception)
                {
                    Config config = new Config();
                    config.configDelete(Environment.CurrentDirectory + "\\config.ini");
                    button.Enabled = false;
                    button.Font = new Font("微软雅黑", 10);
                    button.Text = "请手动选择-->";
                    pictureBox.Image = Image.FromFile(Environment.CurrentDirectory + "\\bg\\" + bgName);
                }
            }
            else
            {
                button.Enabled = false;
                button.Font = new Font("微软雅黑", 10);
                button.Text = "请手动选择-->";
                pictureBox.Image = Image.FromFile(Environment.CurrentDirectory + "\\bg\\" + bgName);
            }
        }

        private static string SearchForFile(string d_name, string filename)
        {
            String path = null;
            try
            {
                var files = Directory.GetFiles(d_name, filename, SearchOption.TopDirectoryOnly);
                if (files.Length > 0)
                {
                    path = files.First();
                }
                else
                {
                    var subDirectories = Directory.GetDirectories(d_name);
                    foreach (var subDirectory in subDirectories)
                    {
                        path = SearchForFile(subDirectory, filename);
                        if (path != null)
                        {
                            break;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("DirectoryNotFoundException");
            }
            return path;
        }

        private void xqtd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lanchPath_td == null)
                {
                    lanchPath_td = ls_td.path;
                }
                Process.Start(lanchPath_td + "\\StarRail.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("请以管理员身份启动程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ys_Click(object sender, EventArgs e)
        {
            try
            {
                if (lanchPath_ys == null)
                {
                    lanchPath_ys = ls_ys.path;
                }
                Process.Start(lanchPath_ys + "\\YuanShen.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("请以管理员身份启动程序", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        string gameName;
        private void more_ys_Click(object sender, EventArgs e)
        {
            gameName = "YuanShen.exe";
            contextMenuStrip1.Show(more_ys, new Point(more_ys.Width - 200, more_ys.Height - 170));
        }

        private void more_xqtd_Click(object sender, EventArgs e)
        {
            gameName = "StarRail.exe";
            contextMenuStrip1.Show(more_ys, new Point(more_ys.Width - 200, more_ys.Height - 170));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = gameName + "|" + gameName;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (gameName.Equals("YuanShen.exe"))
                {
                    lanchPath_ys = ofd.FileName[..^13];
                    Config config = new Config();
                    config.configWrite("Path_Record", "YuanShen.exe", lanchPath_ys, Environment.CurrentDirectory + "\\config.ini");
                    Loadbg(lanchPath_ys, 20, pictureBox1, ys, "ys.png");
                }
                else if (gameName.Equals("StarRail.exe"))
                {
                    lanchPath_td = ofd.FileName[..^13];
                    Config config = new Config();
                    config.configWrite("Path_Record", "StarRail.exe", lanchPath_td, Environment.CurrentDirectory + "\\config.ini");
                    Loadbg(lanchPath_td, 5, pictureBox2, xqtd, "td.png");
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认重置配置文件吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Config config = new Config();
                config.configDelete(Environment.CurrentDirectory + "\\config.ini");
                Application.Restart();
            };

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("qaq");
        }
    }
}