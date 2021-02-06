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
    public partial class prop: Page
    {
        public prop()
        {
            InitializeComponent(); 
            updatemess();
        }
        private int nowpage = 1,nowpagestart = 1,nextpagestart = 1;public int pos = 0;
        private int[] pos_start = new int[100]; 
        private void closeframe1(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame1.Visibility = Visibility.Hidden; system.dong();
        }
        private void closechange(object sender, MouseEventArgs e)
        {
            closebutton.Source = new ImageSourceConverter().ConvertFromString("pic/closebutton.png") as ImageSource;
        }
        private void closeleave(object sender, MouseEventArgs e)
        {
            closebutton.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
        }
        private void emptypage()
        {
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos14pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos15pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos16pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos24pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos25pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos26pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos11nameshow.Text = "";pos11numbershow.Text = ""; pos12nameshow.Text = ""; pos12numbershow.Text = "";
            pos13nameshow.Text = ""; pos13numbershow.Text = ""; pos14nameshow.Text = ""; pos14numbershow.Text = "";
            pos15nameshow.Text = ""; pos15numbershow.Text = ""; pos16nameshow.Text = ""; pos16numbershow.Text = "";
            pos21nameshow.Text = ""; pos21numbershow.Text = ""; pos22nameshow.Text = ""; pos22numbershow.Text = "";
            pos23nameshow.Text = ""; pos23numbershow.Text = ""; pos24nameshow.Text = ""; pos24numbershow.Text = "";
            pos25nameshow.Text = ""; pos25numbershow.Text = ""; pos26nameshow.Text = ""; pos26numbershow.Text = "";

        }
        public int find_mark_prop(int findnumber)
        {
            int marknumber = 0; 
            int allnumber = readclass.read_int("data/prop_number.txt");
            if (findnumber > allnumber) return 0;
            for (int i = nowpagestart; i <= allnumber; ++i)
            {
                if (MainWindow.mymain_interface.prop_number[i] <= 0) continue;
                marknumber++;
                if (marknumber == findnumber) return i;
            }
            return 0;
        }
        public void updatemess()
        {
            emptypage();int nowpos = 1;
            int pos = find_mark_prop(nowpos);if (pos == 0) return;nextpagestart = pos + 1;
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos11nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos11numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个";nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos12nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos12numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos13nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos13numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos14pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos14nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos14numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos15pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos15nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos15numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos16pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos16nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos16numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos21nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos21numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos22nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos22numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos23nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos23numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos24pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos24nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos24numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos25pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos25nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos25numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; nextpagestart = pos + 1;
            pos26pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos26nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos26numbershow.Text = MainWindow.mymain_interface.prop_number[pos] + "个"; nowpos++;
        }
        private void gotoplant(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame1.Navigate(MainWindow.mywarehouse);system.dong(); MainWindow.mywarehouse.updatemess();
        }
        private void gotochest(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame1.Navigate(MainWindow.mychest); system.dong();MainWindow.mychest.updatemess();
        }
        private void goforward(object sender, MouseButtonEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Hidden; system.dong();
            if (nowpage == 1) return;
            nowpagestart = pos_start[nowpage - 1];
            nowpage--; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void gobackward(object sender, MouseButtonEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Hidden; system.dong();
            pos_start[nowpage] = nowpagestart;nowpagestart = nextpagestart;
            nowpage++; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void forwardbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Visible;
        }

        private void forwardbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Hidden;
        }

        private void forwardbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Visible;
        }

        private void backwardbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Visible;
        }

        private void backwardbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Hidden;
        }

        private void backwardbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Visible;
        }
        private void showdetail()
        {
            if (pos == 0) return; system.dong();
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
            MainWindow.mymain_interface.frame3.Navigate(MainWindow.myprop_detail);
            MainWindow.myprop_detail.updatemess();
        }
        private void pos11pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 1);showdetail();
        }
        private void pos12pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 2); showdetail();
        }
        private void pos13pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 3); showdetail();
        }
        private void pos14pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 4); showdetail();
        }
        private void pos15pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 5); showdetail();
        }
        private void pos16pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 6); showdetail();
        }
        private void pos21pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 7); showdetail();
        }
        private void pos22pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 8); showdetail();
        }
        private void pos23pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 9); showdetail();
        }
        private void pos24pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 10); showdetail();
        }
        private void pos25pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 11); showdetail();
        }
        private void pos26pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop( 12); showdetail();
        }
    }
}
