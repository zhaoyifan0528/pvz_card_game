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
    public partial class zombiedetail: Page
    {
        

        
        public int zombie;
        public zombiedetail()
        {
            InitializeComponent();
        }
        public void updatemess()
        {
            if (zombie == 0) return;
            drop.Text = "僵尸NO."+zombie.ToString()+"物品掉落：";
            StreamReader sr = new StreamReader("data/zombie/"+zombie.ToString()+"/drop.txt", Encoding.Default);
            String line; line = sr.ReadLine(); 
            int all = int.Parse(line); 
            for (int i = 1; i <= all; ++i)
            {
                line = sr.ReadLine();
                if (i != 1) drop.AppendText("，");
                drop.AppendText(readclass.read_string("data/warehouse_prop/" + line + "/name.txt"));
                if (i == all) drop.AppendText("。");
            }
            sr.Close();
        }
    }
}
