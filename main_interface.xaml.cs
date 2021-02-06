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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class main_interface : Page
    {

        public int plant_number = 0;
        public int musicmark = 0;
        public int id = 0,allnumber = 0,peo_level,peo_exp,peo_dollar,peo_qun;
        public myplant []plantware = new myplant[1234];
        public int[] warehouse_plant = new int[1231];
        public int[] prop_number = new int[1231];
        public main_interface()
        {
            InitializeComponent();
            quanshow.Text = readclass.read_string("data/warehouse_prop/123/number.txt");
            moneyshow.Text = readclass.read_string("data/dollar.txt");mylvshow();
            loading a = new loading();frame2.Visibility = Visibility.Visible;frame2.Navigate(a);
    }
        private void mylvshow()
        {
            lvshow.Text = "LV." + readclass.read_string("data/lv.txt");
            int pnow = 0; if (readclass.read_int("data/lv.txt") < 9) pnow = readclass.read_int("data/lv.txt") + 10;
            else pnow = readclass.read_int("data/lv.txt") * 3;
            expshow.Text = readclass.read_string("data/exp.txt") + "/" + pnow.ToString();
            system.picmove(0, 0, (int)((double)(readclass.read_double("data/exp.txt") / (double)pnow) * 212), 0, exppic,0);
        }
        private void anyebig(object sender, MouseEventArgs e)
        {
            anyebigpic.Visibility = Visibility.Visible; system.muban();
        }

        private void anyesm(object sender, MouseEventArgs e)
        {
            anyebigpic.Visibility = Visibility.Hidden;
        }

        private void jiangshibig(object sender, MouseEventArgs e)
        {
            jiangshibigpic.Visibility = Visibility.Visible;system.muban();
        }
        private void jiangshism(object sender, MouseEventArgs e)
        {
            jiangshibigpic.Visibility = Visibility.Hidden;
        }

        private void hechengbig(object sender, MouseEventArgs e)
        {
            hechengbigpic.Visibility = Visibility.Visible;
        }
        private void hechengsm(object sender, MouseEventArgs e)
        {
            hechengbigpic.Visibility = Visibility.Hidden;
        }
        private void cangkubig(object sender, MouseEventArgs e)
        {
            cangkubigpic.Visibility = Visibility.Visible;
        }
        private void cangkusm(object sender, MouseEventArgs e)
        {
            cangkubigpic.Visibility = Visibility.Hidden;
        }
        private void shopbig(object sender, MouseEventArgs e)
        {
            shopbigpic.Visibility = Visibility.Visible;
        }
        private void shopsm(object sender, MouseEventArgs e)
        {
            shopbigpic.Visibility = Visibility.Hidden;
        }
        
        private void showwarehouse(object sender, MouseButtonEventArgs e)
        {
            frame1.Visibility = Visibility.Visible;system.dong(); system.alldollarfresh();
            frame1.Navigate(MainWindow.mywarehouse); MainWindow.mywarehouse.updatemess();
        }
        private void gotohe(object sender, MouseButtonEventArgs e)
        {
            frame2.Visibility = Visibility.Visible; system.dong(); system.alldollarfresh();
            frame2.Navigate(MainWindow.mysyn1);MainWindow.mysyn1.updatemess();
            MainWindow.mysyn2.updatemess();MainWindow.mysyn2page2.updatemess();
        }

        private void gozombie1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame2.Visibility = Visibility.Visible; system.dong();
            frame2.Navigate(MainWindow.myzombie1); system.alldollarfresh();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame5.Visibility = Visibility.Visible;
            MainWindow.mymain_interface.frame5.Navigate(MainWindow.mynormalshop);
            system.alldollarfresh(); system.dong();
        }

        private void anye_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frame2.Visibility = Visibility.Visible; system.dong();
            frame2.Navigate(MainWindow.myzombie2);
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            gongju a = new gongju();a.Show();
        }

        private void corpse_MouseEnter(object sender, MouseEventArgs e)
        {
            corpse.Visibility = Visibility.Hidden;corpse_big.Visibility = Visibility.Visible;
        }

        private void corpse_big_MouseLeave(object sender, MouseEventArgs e)
        {
            corpse.Visibility = Visibility.Visible; corpse_big.Visibility = Visibility.Hidden;
        }
        private void zombiequnshow()
        {
            zombiequnpic.Visibility = Visibility.Visible; zombiequngun.Visibility = Visibility.Visible;
            zombiequngo.Visibility = Visibility.Visible;cengshow.Visibility = Visibility.Visible;
            cengshow.Text = "历史最高层数："+MainWindow.mymain_interface.peo_qun.ToString();
        }
        private void zombiequnhid()
        {
            zombiequnpic.Visibility = Visibility.Hidden; zombiequngun.Visibility = Visibility.Hidden;
            zombiequngo.Visibility = Visibility.Hidden;cengshow.Visibility = Visibility.Hidden;
        }
        private void corpse_big_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            corpse.Visibility = Visibility.Visible; corpse_big.Visibility = Visibility.Hidden;
            system.dong();zombiequnshow();
        }

        private void zombiequngo_MouseEnter(object sender, MouseEventArgs e)
        {
            zombiequngo.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始2亮.png") as ImageSource;
        }

        private void zombiequngo_MouseLeave(object sender, MouseEventArgs e)
        {
            zombiequngo.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始2.png") as ImageSource;
        }

        private void zombiequngo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            zombiequngo.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始2按.png") as ImageSource;
            system.dong();
        }

        private void zombiequngo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            zombiequngo.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始2亮.png") as ImageSource;
            frame2.Visibility = Visibility.Visible;
            frame2.Navigate(MainWindow.myzombie_bf_fight); MainWindow.myzombie_bf_fight.gamemode = 1;
            MainWindow.myzombie_bf_fight.zombie = 1;
            MainWindow.myzombie_bf_fight.updatemess();
            MainWindow.myzombie_fight2.remark = Math.Max(0,MainWindow.mymain_interface.peo_qun - 20);
            zombiequnhid();
        }

        private void zombiequngun_MouseEnter(object sender, MouseEventArgs e)
        {
            zombiequngun.Source = new ImageSourceConverter().ConvertFromString("pic/取消3亮.png") as ImageSource;
        }

        private void zombiequngun_MouseLeave(object sender, MouseEventArgs e)
        {
            zombiequngun.Source = new ImageSourceConverter().ConvertFromString("pic/取消3.png") as ImageSource;
        }

        private void zombiequngun_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            zombiequngun.Source = new ImageSourceConverter().ConvertFromString("pic/取消3按.png") as ImageSource;
            system.dong();
        }

        private void zombiequngun_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            zombiequngun.Source = new ImageSourceConverter().ConvertFromString("pic/取消3亮.png") as ImageSource;
            zombiequnhid();
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            frame6.Visibility = Visibility.Visible;
            frame6.Navigate(MainWindow.mytask);
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            frame2.Visibility = Visibility.Visible;
            frame2.Navigate(MainWindow.myzombie_bf_fight);
            MainWindow.myzombie_bf_fight.gamemode = 3;
            MainWindow.myzombie_bf_fight.updatemess();
            system.dong();
        }

        private void smshou_MouseEnter(object sender, MouseEventArgs e)
        {
            smshou.Visibility = Visibility.Hidden;bigshou.Visibility = Visibility.Visible;
        }

        private void bigshou_MouseLeave(object sender, MouseEventArgs e)
        {
            smshou.Visibility = Visibility.Visible; bigshou.Visibility = Visibility.Hidden;
        }
    }
}
