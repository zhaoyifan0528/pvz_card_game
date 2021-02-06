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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class plantattr: Page
    {



        public int pos = 0,mark = 0;
        public plantattr()
        {
            InitializeComponent();updatemess();
        }
        public void updatemess()
        {
            if (pos == 0) return;
            mark = MainWindow.mymain_interface.plantware[pos].mark;
            string road2 = "data/plant_ill/" + mark.ToString() + "/";
            drop.Text = readclass.read_string(road2+"name.txt")+"属性：\n\n";
            drop.AppendText("生命："+readclass.read_lif(pos)+"\n\n");
            drop.AppendText("攻击：" + readclass.read_att(pos) + "\n\n");
            drop.AppendText("护甲：" + readclass.read_arm(pos) + "\n\n");
            drop.AppendText("穿透：" + readclass.read_thr(pos) + "\n\n");
        }
    }
}
