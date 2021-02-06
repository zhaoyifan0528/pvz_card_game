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
    public partial class chest: Page
    {
        public chest()
        {
            InitializeComponent();
            updatemess();
        }
        private int nowpage = 1;public int pos = 0;
        private void closeframe1(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame1.Visibility = Visibility.Hidden;
            system.dong();
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
            int marknumber = 0, rem_answer = 0;
            int allnumber = readclass.read_int("data/box_number.txt");
            for (int i = 1; i <= allnumber; ++i)
            {
                if (MainWindow.mymain_interface.prop_number[i+900] <= 0) continue;
                marknumber++;
                if (marknumber == findnumber) rem_answer = i+900;
            }
            return rem_answer;
        }
        public void updatemess()
        {
            emptypage();int nowpos = (nowpage - 1) * 12 + 1;
            int pos = find_mark_prop(nowpos);if (pos == 0) return;
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos11nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos11numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString()+"个";nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos12nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos12numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos13nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos13numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos14pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos14nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos14numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos15pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos15nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos15numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos16pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos16nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos16numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos21nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos21numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos22nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos22numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos23nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos23numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos24pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos24nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos24numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos25pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos25nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos25numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return;
            pos26pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos + ".png") as ImageSource;
            pos26nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos + "/name.txt");
            pos26numbershow.Text = MainWindow.mymain_interface.prop_number[pos].ToString() + "个"; nowpos++;
        }
        private void gotoplant(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame1.Navigate(MainWindow.mywarehouse);system.dong();
            MainWindow.mywarehouse.updatemess();
        }
        private void gotoprop(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame1.Navigate(MainWindow.myprop); system.dong();
            MainWindow.myprop.updatemess();
        }
        private void goforward(object sender, MouseButtonEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Hidden; system.dong();
            if (nowpage == 1) return;
            nowpage--; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void gobackward(object sender, MouseButtonEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Hidden; system.dong();
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
            if (pos == 0) return;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
            MainWindow.mymain_interface.frame3.Navigate(MainWindow.mychest_detail);
            MainWindow.mychest_detail.updatemess();
        }
        private void pos11pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 1);showdetail();
        }
        private void pos12pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 2); showdetail();
        }
        private void pos13pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 3); showdetail();
        }
        private void pos14pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 4); showdetail();
        }
        private void pos15pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 5); showdetail();
        }
        private void pos16pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 6); showdetail();
        }
        private void pos21pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 7); showdetail();
        }
        private void pos22pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 8); showdetail();
        }
        private void pos23pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 9); showdetail();
        }
        private void pos24pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 10); showdetail();
        }
        private void pos25pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 11); showdetail();
        }
        private void pos26pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); pos = find_mark_prop((nowpage - 1) * 12 + 12); showdetail();
        }
    }
}
