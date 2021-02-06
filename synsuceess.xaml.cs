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
    public partial class synsuccess: Page
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
        public synsuccess()
        {
            InitializeComponent();
        }
        private int oldlif, oldatt, oldarm, oldthr;public double oldqua;
        public void updatemess()
        {
            if (pos == 0) return;
            messhow.Text = "恭喜你获得" + readclass.read_string("data/plant_ill/" + newmark.ToString() + "/name.txt");
            oldpic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + oldmark.ToString() + ".png") as ImageSource;
            newpic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + newmark.ToString() + ".png") as ImageSource;
            oldlif = readclass.read_lif(pos);oldatt = readclass.read_att(pos);
            oldarm = readclass.read_arm(pos);oldthr = readclass.read_thr(pos);
            oldqua = MainWindow.mymain_interface.plantware[pos].quality;
            MainWindow.mymain_interface.plantware[pos].quality += 0.05;
            sql.update_plant(pos);
            lif.Text = "生命  " + oldlif.ToString() + "   ->   " + readclass.read_lif(pos).ToString();
            att.Text = "攻击  " + oldatt.ToString() + "   ->   " + readclass.read_att(pos).ToString();
            arm.Text = "护甲  " + oldarm.ToString() + "   ->   " + readclass.read_arm(pos).ToString();
            thr.Text = "穿透  " + oldthr.ToString() + "   ->   " + readclass.read_thr(pos).ToString();
            grow.Text = "品质  " + system.qualityword(oldqua)
                + "   ->   " + system.qualityword(oldqua + 0.05);
        }
        
    }
}
