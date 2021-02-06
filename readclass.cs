using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace game_2
{
    class readclass
    {
        static private Dictionary<string, int> basislif = new Dictionary<string, int> { { "光", 108 },{"暗", 96 },{"风",114},
            {"雷" ,60},{"水" ,108},{ "火",72} };
        static private Dictionary<string, int> basisatt = new Dictionary<string, int> { { "光", 18 },{"暗", 24 },{"风",18},
            {"雷" ,30},{"水" ,18},{ "火",30} };
        static private Dictionary<string, int> basisthr = new Dictionary<string, int> { { "光", 9 },{"暗", 12 },{"风",6},
            {"雷" ,12},{"水" ,6},{ "火",6 } };
        static private Dictionary<string, int> basisarm = new Dictionary<string, int> { { "光", 9 },{"暗", 6 },{"风",12},
            {"雷" ,6},{"水" ,12},{ "火",12} };
       
        static private Dictionary<string, int> growlif = new Dictionary<string, int> { { "光", 18 },{"暗", 16},{"风",19},
            {"雷" ,10},{"水" ,18},{ "火",12} };
        static private Dictionary<string, int> growatt = new Dictionary<string, int> { { "光", 3 },{"暗", 4 },{"风",3},
            {"雷" ,5},{"水" ,3},{ "火",5} };
        static private Dictionary<string, int> growthr = new Dictionary<string, int> { { "光", 3 },{"暗", 4 },{"风",2},
            {"雷" ,4},{"水" ,2},{ "火",2 } };
        static private Dictionary<string, int> growarm = new Dictionary<string, int> { { "光", 3 },{"暗", 2 },{"风",4},
            {"雷" ,2 },{"水" ,4},{ "火",4} };
        static public Dictionary<int, int> needexp = new Dictionary<int, int> { };
        static public Dictionary<int, int> peoexp = new Dictionary<int, int> { };
        
        public static int find_plant(int num)
        {
            if (num > MainWindow.mymain_interface.plant_number) return 0;
            return MainWindow.mymain_interface.warehouse_plant[num];
        }
        public static string read_string(string a)
        {
            StreamReader sr = new StreamReader(a, Encoding.Default);
            String line; line = sr.ReadLine();
            sr.Close();if (line == null) line = "";
            return line.ToString();
        }
        public static void prop_change(int x,int num)
        {
            MainWindow.mymain_interface.prop_number[x] += num;sql.sql_add_prop(x);
        }
        public static int read_int(string a)
        {
            StreamReader sr = new StreamReader(a, Encoding.Default);
            String line; line = sr.ReadLine();
            sr.Close();
            return int.Parse(line.ToString());
        }
        public static void intext(string a,TextBox b)
        {
            b.Text = "";
            StreamReader sr = new StreamReader(a, Encoding.Default);
            String line; line = sr.ReadLine();
            while (line != null)
            {
                b.AppendText(line+'\n');
                line = sr.ReadLine();
            }
            sr.Close();
        }
        public static int read_many_int(string a)
        {
            StreamReader sr = new StreamReader(a, Encoding.Default);
            String line; line = sr.ReadLine();int answer = 0;
            int all = int.Parse(line);int select = (new Random()).Next(1, all + 1);
            for(int i=1;i<=all;++i)
            {
                line = sr.ReadLine();
                if (i == select) answer = int.Parse(line);
            }
            sr.Close();
            return answer;
        }
        public static double read_double(string a)
        {
            StreamReader sr = new StreamReader(a, Encoding.Default);
            String line; line = sr.ReadLine();
            sr.Close();
            return double.Parse(line.ToString());
        }
        public static void write_int(string a,int b)
        {
            StreamWriter sw = new StreamWriter(a);
            sw.WriteLine(b);
            sw.Flush(); sw.Close();
        }
        public static void write_double(string a, double b)
        {
            StreamWriter sw = new StreamWriter(a);
            sw.WriteLine(b.ToString());
            sw.Flush(); sw.Close();
        }
        public static void write_string(string a, string b)
        {
            StreamWriter sw = new StreamWriter(a);
            sw.WriteLine(b);
            sw.Flush(); sw.Close();
        }
        public static int read_lif(int pos)
        {
            int lv = MainWindow.mymain_interface.plantware[pos].lv;
            string mark = MainWindow.mymain_interface.plantware[pos].mark.ToString();
            int nowgrowth = MainWindow.mymain_interface.plantware[pos].growth;
            string road2 = "data/plant_ill/" + mark + "/";
            string attri = read_string(road2 + "attritube.txt");
            int now2 = basislif[attri]* (read_int(road2 + "maxgrowth.txt") / 3) +(lv-1)*nowgrowth*growlif[attri];
            double pnow = (double)now2 * MainWindow.mymain_interface.plantware[pos].quality;
            return (int)pnow + MainWindow.mymain_interface.plantware[pos].lifadd * 400;
        }
        public static int read_att(int pos)
        {
            int lv = MainWindow.mymain_interface.plantware[pos].lv;
            string mark = MainWindow.mymain_interface.plantware[pos].mark.ToString();
            int nowgrowth = MainWindow.mymain_interface.plantware[pos].growth;
            string road2 = "data/plant_ill/" + mark + "/";
            string attri = read_string(road2 + "attritube.txt");
            int now = basisatt[attri] * (read_int(road2 + "maxgrowth.txt") / 3) + (lv - 1) * nowgrowth * growatt[attri];
            double pnow = (double)now * MainWindow.mymain_interface.plantware[pos].quality;
            return (int)pnow + MainWindow.mymain_interface.plantware[pos].attadd * 100;
        }
        public static int read_arm(int pos)
        {
            int lv = MainWindow.mymain_interface.plantware[pos].lv;
            string mark = MainWindow.mymain_interface.plantware[pos].mark.ToString();
            int nowgrowth = MainWindow.mymain_interface.plantware[pos].growth;
            string road2 = "data/plant_ill/" + mark + "/";
            string attri = read_string(road2 + "attritube.txt");
            int now = basisarm[attri] * (read_int(road2 + "maxgrowth.txt") / 3) + (lv - 1) * nowgrowth * growarm[attri];
            double pnow = (double)now * MainWindow.mymain_interface.plantware[pos].quality;
            return (int)pnow + MainWindow.mymain_interface.plantware[pos].armadd * 100;
        }
        public static int read_thr(int pos)
        {
            int lv = MainWindow.mymain_interface.plantware[pos].lv;
            string mark = MainWindow.mymain_interface.plantware[pos].mark.ToString();
            int nowgrowth = MainWindow.mymain_interface.plantware[pos].growth;
            string road2 = "data/plant_ill/" + mark + "/";
            string attri = read_string(road2 + "attritube.txt");
            int now = basisthr[attri] * (read_int(road2 + "maxgrowth.txt") / 3) + (lv - 1) * nowgrowth * growthr[attri];
            double pnow = (double)now * MainWindow.mymain_interface.plantware[pos].quality;
            return (int)pnow + MainWindow.mymain_interface.plantware[pos].thradd * 100;
        }
    }
}
