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
    public partial class zombieattr: Page
    {
        

        
        public int zombie = 0;
        public zombieattr()
        {
            InitializeComponent();
        }
        public void updatemess()
        {
            
            if (zombie == 0) return;
            drop.Text = "僵尸NO."+zombie.ToString()+"属性：\n\n";
            drop.AppendText("生命："+readclass.read_string("data/zombie/" + zombie.ToString() + "/lif.txt")+ "\n\n");
            drop.AppendText("攻击：" + readclass.read_string("data/zombie/" + zombie.ToString() + "/att.txt") + "\n\n");
            drop.AppendText("护甲：" + readclass.read_string("data/zombie/" + zombie.ToString() + "/arm.txt") + "\n\n");
            drop.AppendText("穿透：" + readclass.read_string("data/zombie/" + zombie.ToString() + "/thr.txt") + "\n\n");
        }
    }
}
