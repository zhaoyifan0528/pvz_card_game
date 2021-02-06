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
    public partial class normalshop: Page
    {
        public normalshop()
        {
            InitializeComponent();
            updatemess();
        }
        private int nowpage = 1;public int pos = 0;
        private void closeframe1(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            MainWindow.mymain_interface.frame5.Visibility = Visibility.Hidden; 
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
            if (findnumber > readclass.read_int("data/normalshop_number.txt")) return 0;
            return findnumber;
        }
        public void updatemess()
        {
            emptypage();int nowpos = (nowpage - 1) * 12 + 1;
            int pos = find_mark_prop(nowpos);if (pos == 0) return;int pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos11nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos11numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt")+"金";nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos12nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos12numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos13nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos13numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos14pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos14nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos14numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos15pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos15nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos15numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos16pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos16nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos16numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos21nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos21numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos22nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos22numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos23nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos23numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos24pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos24nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos24numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos25pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos25nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos25numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
            pos = find_mark_prop(nowpos); if (pos == 0) return; pos1 = readclass.read_int("data/normalshop/" + pos + "/mark.txt");
            pos26pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + pos1 + ".png") as ImageSource;
            pos26nameshow.Text = readclass.read_string("data/warehouse_prop/" + pos1 + "/name.txt");
            pos26numbershow.Text = readclass.read_string("data/normalshop/" + pos + "/price.txt") + "金"; nowpos++;
        }
        
        private void gotochest(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame5.Navigate(MainWindow.mysupershop);
        }

        private void goleft_MouseEnter(object sender, MouseEventArgs e)
        {
             goleft.Source = new ImageSourceConverter().ConvertFromString("pic/left亮.jpg") as ImageSource;
        }

        private void goleft_MouseLeave(object sender, MouseEventArgs e)
        {
            goleft.Source = new ImageSourceConverter().ConvertFromString("pic/left原.jpg") as ImageSource;
        }

        private void goleft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); goleft.Source = new ImageSourceConverter().ConvertFromString("pic/left按.jpg") as ImageSource;
            if (nowpage == 1) return; nowpage--; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void goleft_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            goleft.Source = new ImageSourceConverter().ConvertFromString("pic/left亮.jpg") as ImageSource;
        }

        private void goright_MouseEnter(object sender, MouseEventArgs e)
        {
            goright.Source = new ImageSourceConverter().ConvertFromString("pic/right亮.jpg") as ImageSource;
        }

        private void goright_MouseLeave(object sender, MouseEventArgs e)
        {
            goright.Source = new ImageSourceConverter().ConvertFromString("pic/right原.jpg") as ImageSource;
        }

        private void goright_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); goright.Source = new ImageSourceConverter().ConvertFromString("pic/right按.jpg") as ImageSource;
            nowpage++; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void goright_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            goright.Source = new ImageSourceConverter().ConvertFromString("pic/right亮.jpg") as ImageSource;
        }

        private void showdetail()
        {
            if (pos == 0) return;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
            MainWindow.mymain_interface.frame3.Navigate(MainWindow.mynormalshop_detail);
            MainWindow.mynormalshop_detail.updatemess();
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
