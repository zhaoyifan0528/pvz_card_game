using System;
using System.Collections.Generic;
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
    public partial class synsuccess2: Page
    {
        

        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden; system.lingdang();
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2按.jpg") as ImageSource;
        }

        private void sure_MouseLeave(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2.jpg") as ImageSource;
        }

        private void sure_MouseEnter(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
        }
        public int oldmark = 0, newmark = 0, pos = 0, newgrowth = 0;public double newqua = 0;
        public synsuccess2()
        {
            InitializeComponent();
        }
        public void write_temporary()
        {
            string road = "data/warehouse_plant/99999/",road2 = "data/warehouse_plant/"+pos.ToString()+"/";
            readclass.write_int(road + "level.txt", readclass.read_int(road2 + "level.txt"));
            newqua = readclass.read_double(road2 + "quality.txt") ;
            readclass.write_double(road + "quality.txt", newqua);
            readclass.write_int(road + "mark.txt", newmark);
            newgrowth = (new Random()).Next(readclass.read_int("data/plant_ill/" + newmark.ToString() + "/mingrowth.txt"),
                 readclass.read_int("data/plant_ill/" + newmark.ToString() + "/maxgrowth.txt") + 1);
            readclass.write_int(road + "growth.txt", newgrowth);
        }
        
        public void updatemess()
        {
            if (pos == 0) return;
            messhow.Text = "恭喜你获得" + readclass.read_string("data/plant_ill/" + newmark.ToString() + "/name.txt");
            oldpic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + oldmark.ToString() + ".png") as ImageSource;
            newpic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + newmark.ToString() + ".png") as ImageSource;
            write_temporary();
            lif.Text = "生命  " + readclass.read_lif(pos).ToString() + "   ->   " + readclass.read_lif(99999).ToString();
            att.Text = "攻击  " + readclass.read_att(pos).ToString() + "   ->   " + readclass.read_att(99999).ToString();
            arm.Text = "护甲  " + readclass.read_arm(pos).ToString() + "   ->   " + readclass.read_arm(99999).ToString();
            thr.Text = "穿透  " + readclass.read_thr(pos).ToString() + "   ->   " + readclass.read_thr(99999).ToString();
            grow.Text = "成长  " + readclass.read_string("data/warehouse_plant/" + pos.ToString() + "/growth.txt")
                + "   ->   " + newgrowth.ToString();
            readclass.write_int("data/warehouse_plant/" + pos.ToString() + "/growth.txt", newgrowth);
        }
        
    }
}
