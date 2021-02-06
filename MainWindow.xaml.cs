using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static main_interface mymain_interface= new main_interface();
        public static syn mysyn1 = new syn();
        public static syn2 mysyn2 = new syn2();
        public static syn3 mysyn3 = new syn3();
        public static syn3page2 mysyn3pagr2 = new syn3page2();
        public static prop myprop = new prop();
        public static warehouse mywarehouse = new warehouse();
        public static syn2page2 mysyn2page2 = new syn2page2();
        public static zombie1 myzombie1 = new zombie1();
        public static plantdetail myplantdetail = new plantdetail();
        public static zombie_bf_fight myzombie_bf_fight = new zombie_bf_fight();
        public static zombie_fight myzombie_fight = new zombie_fight();
        public static get_exp myget_exp = new get_exp();
        public static get_prop myget_prop = new get_prop();
        public static prop_detail myprop_detail = new prop_detail();
        public static chest_detail mychest_detail = new chest_detail();
        public static chest mychest = new chest();
        public static evo myevo = new evo();
        public static chestopen mychestopen = new chestopen();
        public static normalshop mynormalshop = new normalshop();
        public static normalshop_detail mynormalshop_detail = new normalshop_detail();
        public static supershop mysupershop = new supershop();
        public static supershop_detail mysupershop_detail = new supershop_detail();
        public static zombiedetail myzombiedetail = new zombiedetail();
        public static synsuccess mysynsuccess = new synsuccess();
        public static synsuccess2 mysynsuccess2 = new synsuccess2();
        public static zombie2 myzombie2 = new zombie2();
        public static zombie_fight2 myzombie_fight2 = new zombie_fight2();
        public static get_prop2 myget_prop2 = new get_prop2();
        public static synsuccess3 mysynsuccess3 = new synsuccess3();
        public static zombie_fight3 myzombie_fight3 = new zombie_fight3();
        public static task mytask = new task();
        public static zombieattr myzombieattr = new zombieattr();
        public static pvz1 mypvz1 = new pvz1();
        public static pvz_select mypvz_select = new pvz_select();
        public int id;
        public MainWindow()
        {
            InitializeComponent();
            level_exp();
            see_inter.Navigate(mymain_interface);
            DirectoryInfo folder = new DirectoryInfo("data/warehouse_plant");
            int flagmess = 0;
            foreach (DirectoryInfo file in folder.GetDirectories())
            {
                if (readclass.read_int("data/warehouse_plant/" + file.Name + "/exist.txt") == 0)
                {
                    if (file.Name == "99999") continue;
                    file.Delete(true); flagmess = 1;
                }
                else
                {
                    if (!File.Exists("data/warehouse_plant/" + file.Name + "/lifadd.txt"))
                    {
                        readclass.write_int("data/warehouse_plant/" + file.Name + "/lifadd.txt", 0);
                        readclass.write_int("data/warehouse_plant/" + file.Name + "/attadd.txt", 0);
                        readclass.write_int("data/warehouse_plant/" + file.Name + "/armadd.txt", 0);
                        readclass.write_int("data/warehouse_plant/" + file.Name + "/thradd.txt", 0);
                    }
                    if (file.Name == "99999") continue;
                    mymain_interface.warehouse_plant[++mymain_interface.plant_number] = int.Parse(file.Name);
                }
            }
            if (flagmess == 1) MessageBox.Show("v1.05植物仓库修改成功");
            
        }
        public void transmit_id()
        {
            mymain_interface.id = id;
            mymain_interface.idshow.Text = sql.sqlget("SELECT * FROM ACCOUNT_ WHERE MARK = "+id.ToString(),"ACCOUNT");
        }
        private void level_exp()
        {
            // StreamWriter sw = new StreamWriter("data/expshow.txt");
            readclass.peoexp.Add(0, 1);
            for (int i = 1; i <= 8; ++i)
            {
                readclass.needexp.Add(i, 2 * i); readclass.peoexp.Add(i, i + 10);
              //  sw.WriteLine(i.ToString()+"   "+(2*i).ToString());
            }
            for (int j = 1;j<=500;++j)
            {
                for (int i = 9; i <= 18; ++i)
                {
                    readclass.needexp.Add(i + (j - 1) * 10, (10 * j) * j * (j + 1) + i * j + (j + 2) * (i + (j - 1) * 10));
                    readclass.peoexp.Add(i + (j - 1) * 10, (i + (j - 1) * 10)*3);
                    //    int num = (10 * j) * j * (j + 1) + i * j + (j + 2) * (i + (j - 1) * 10);
                    //    sw.WriteLine(((i + (j - 1) * 10).ToString() + "  :  " + num.ToString()));
                }
            }
           // sw.Flush(); sw.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addthing2 a = new addthing2();
            a.Show();
        }
    }
}
