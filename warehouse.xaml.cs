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
    public partial class warehouse : Page
    {
        public int nowpage = 1;
        public warehouse()
        {
            InitializeComponent();
            updatemess();
        }
        public int find_mark_plant(int findnumber)
        {
            if (findnumber > MainWindow.mymain_interface.allnumber) return 0;
            return findnumber;
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
            pos11lvshow.Text = "";pos12lvshow.Text = "";pos13lvshow.Text = "";pos14lvshow.Text = "";
            pos15lvshow.Text = "";pos16lvshow.Text = "";pos21lvshow.Text = "";pos22lvshow.Text = "";
            pos23lvshow.Text = "";pos24lvshow.Text = "";pos25lvshow.Text = "";pos26lvshow.Text = "";
            pos11back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos12back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos13back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos14back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos15back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos16back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos21back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos22back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos23back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos24back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos25back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos26back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
        }
        public void updatemess()
        {
            emptypage();
            int nowpos = (nowpage - 1) * 12 + 1;int realtime;string  realmark;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos);nowpos++; 
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos11lvshow.Text = "LV."+ MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos11back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos12lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos12back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos13lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos13back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos14pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos14lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos14back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos15pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos15lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos15back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos16pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos16lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos16back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos21lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos21back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos22lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos22back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos23lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos23back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos24pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos24lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos24back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos25pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos25lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos25back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos26pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos26lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos26back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
        }
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
        private void goprop(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame1.Navigate(MainWindow.myprop);
            MainWindow.myprop.updatemess();
        }
        private void gochest(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame1.Navigate(MainWindow.mychest);
            MainWindow.mychest.updatemess();
        }
        private void goforward(object sender, MouseButtonEventArgs e)
        {
            system.dong(); forwardbigpic.Visibility = Visibility.Hidden;
            if (nowpage == 1) return;
            nowpage--;updatemess();pageshow.Text = nowpage.ToString();
        }

        private void gobackward(object sender, MouseButtonEventArgs e)
        {
            system.dong(); backwordbigpic.Visibility = Visibility.Hidden;
            nowpage++;updatemess(); pageshow.Text = nowpage.ToString();
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
        private void detailshow(int pos)
        {
            MainWindow.myplantdetail.nowpos = pos; MainWindow.myplantdetail.updatemess();
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
            MainWindow.mymain_interface.frame3.Navigate(MainWindow.myplantdetail);
        }
        private void pos11click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 1);
            if (mypos == 0) return;detailshow(mypos);
        }
        private void pos12click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 2);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos13click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 +3);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos14click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 4);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos15click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 5);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos16click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 6);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos21click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 7);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos22click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 8);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos23click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 9);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos24click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 10);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos25click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 11);
            if (mypos == 0) return; detailshow(mypos);
        }
        private void pos26click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int mypos = find_mark_plant((nowpage - 1) * 12 + 12);
            if (mypos == 0) return; detailshow(mypos);
        }
    }
}
