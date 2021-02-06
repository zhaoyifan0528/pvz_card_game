using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class plantdetail: Page
    {
        public plantdetail()
        {
            InitializeComponent();
        }
        public int nowpos= 0;
        private void expset()
        {
            system.picmove(0, 0, 0, 0, expshort, 0);
            system.picmove(0, 0, 0, 0, explong, 0);
            int nowexp = MainWindow.mymain_interface.plantware[nowpos].exp;
            int needexp = readclass.needexp[MainWindow.mymain_interface.plantware[nowpos].lv];
            double bi = (double)nowexp / (double)needexp;
            if(bi<=0.5) system.picmove(0, 0, (int)((double)222 * (bi*2)), 0,expshort ,0);
            else system.picmove(0, 0, (int)((double)222 * (bi-0.5)*2), -100, explong, 0);
            expshow.Text = nowexp.ToString() + "/" + needexp.ToString();
        }
        public void updatemess()
        {
            if (nowpos == 0) return;expset();
            string road = "data/warehouse_plant/" + nowpos + "/";
            string mark = MainWindow.mymain_interface.plantware[nowpos].mark.ToString();
            pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
            string road2 = "data/plant_ill/" + mark + "/";
            double nquality = MainWindow.mymain_interface.plantware[nowpos].quality ;
            name.Text = readclass.read_string(road2 + "name.txt");
            lv.Text ="LV."+ MainWindow.mymain_interface.plantware[nowpos].lv;
            quality.Text = system.qualityword(nquality);
            quapic.Source = new ImageSourceConverter().ConvertFromString("pic/level/" + quality.Text + ".png") as ImageSource;
            growth.Text = MainWindow.mymain_interface.plantware[nowpos].growth.ToString();
            lif.Text = readclass.read_lif(nowpos).ToString();
            att.Text = readclass.read_att(nowpos).ToString();
            arm.Text = readclass.read_arm(nowpos).ToString(); 
            thr.Text = readclass.read_thr(nowpos).ToString();
            scope.Text = readclass.read_string(road2 + "mingrowth.txt") + "-" + readclass.read_string(road2 + "maxgrowth.txt");
            double fight1 = (double)((readclass.read_att(nowpos) * 4 + readclass.read_lif(nowpos)) / 3 +
                readclass.read_thr(nowpos) + readclass.read_arm(nowpos));
            fight1 *= 0.0625;
            fight.Text = ((int)fight1).ToString();

        }
        private void soldhidden()
        {
            surepic.Visibility = Visibility.Hidden;
            soldshow.Visibility = Visibility.Hidden;quit2pic.Visibility = Visibility.Hidden;
        }
        private void soldpicshow()
        {
            surepic.Visibility = Visibility.Visible;
            soldshow.Visibility = Visibility.Visible; quit2pic.Visibility = Visibility.Visible;
        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消.jpg") as ImageSource;
            
        }

        private void quitpic_MouseEnter(object sender, MouseEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消亮.jpg") as ImageSource;
        }

        private void quitpic_MouseLeave(object sender, MouseEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消.jpg") as ImageSource;
        }

        private void quitpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden;system.dong();
        }

        private void soldoutpic_MouseEnter(object sender, MouseEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/卖出亮.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeave(object sender, MouseEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/卖出.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/卖出亮.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/卖出.jpg") as ImageSource;
            soldpicshow();system.dong();
        }

        private void surepic_MouseEnter(object sender, MouseEventArgs e)
        {
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定亮.jpg") as ImageSource;
        }

        private void surepic_MouseLeave(object sender, MouseEventArgs e)
        {
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定.jpg") as ImageSource;
        }

        private void surepic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定.jpg") as ImageSource;
        }

        private void surepic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.money();
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定亮.jpg") as ImageSource;
            soldhidden();//金钱音效
            if (nowpos == 0) return;    //nowpos
            for(int i = 1;i <= MainWindow.mymain_interface.allnumber; ++i)
            {
                if (i != nowpos) continue;
                for (int j = i + 1; j <= MainWindow.mymain_interface.allnumber; ++j)
                    MainWindow.mymain_interface.plantware[j - 1] = MainWindow.mymain_interface.plantware[j];
                    //MainWindow.mymain_interface.warehouse_plant[j - 1] = MainWindow.mymain_interface.warehouse_plant[j];
                MainWindow.mymain_interface.allnumber--;break;
            }
            sql.del_plant(MainWindow.mymain_interface.plantware[nowpos].plant_pos);
            MainWindow.mywarehouse.updatemess();
            MainWindow.mysyn1.updatemess(); MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden;
        }

        private void quit2pic_MouseEnter(object sender, MouseEventArgs e)
        {
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1亮.jpg") as ImageSource;
        }

        private void quit2pic_MouseLeave(object sender, MouseEventArgs e)
        {
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1.jpg") as ImageSource;
        }

        private void quit2pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1.jpg") as ImageSource;
        }

        private void quit2pic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1亮.jpg") as ImageSource;
            soldhidden();system.dong();
        }
    }
}
