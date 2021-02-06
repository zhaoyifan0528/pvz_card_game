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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class syn2 : Page
    {
        public syn2()
        {
            InitializeComponent();
            successtext.Text = "";
            updatemess();
        }
        private int nowpage = 1;public int selectplant = 0, selectprop = 0;

        private void close_MouseEnter(object sender, MouseEventArgs e)
        {
            closepic.Source = new ImageSourceConverter().ConvertFromString("pic/closebutton.png") as ImageSource;
        }
        private void close_MouseLeave(object sender, MouseEventArgs e)
        {
            closepic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
        }
        private void close_Mouseclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
        }
        private void gotosyn1(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn1);
            MainWindow.mysyn1.updatemess();
        }
        private void gotosyn2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn2);
        }
        private void gotosyn3(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn3); MainWindow.mysyn3.updatemess();
        }
        private void gotosyn2page2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn2page2);
            MainWindow.mysyn2page2.updatemess();
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
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos31pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos32pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos33pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos11lvshow.Text = ""; pos12lvshow.Text = ""; pos13lvshow.Text = ""; pos21lvshow.Text = "";
            pos22lvshow.Text = "";
            pos23lvshow.Text = ""; pos31lvshow.Text = ""; pos32lvshow.Text = ""; pos33lvshow.Text = "";
            pos11back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos12back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos13back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos31back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos32back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos33back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos21back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos22back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos23back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
        }
        public void emptysyn()
        {
            MainWindow.mysyn2.selectplant = 0; MainWindow.mysyn2.selectprop = 0;
            MainWindow.mysyn2.plantshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2.propshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2.successtext.Text = "";
            MainWindow.mysyn2page2.plantshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2page2.propshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2page2.successtext.Text = "";
        }
        public void updatemess()
        {
            emptypage();
            int nowpos = (nowpage - 1) * 9 + 1; int realtime; string realmark;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos11lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
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
            pos31pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos31lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos31back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos32pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos32lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos32back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            realmark = MainWindow.mymain_interface.plantware[realtime].mark.ToString();
            pos33pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + realmark + ".png") as ImageSource;
            pos33lvshow.Text = "LV." + MainWindow.mymain_interface.plantware[realtime].lv.ToString();
            pos33back.Source = new ImageSourceConverter().ConvertFromString("pic/back/" +
               system.qualityword(MainWindow.mymain_interface.plantware[realtime].quality) + ".png") as ImageSource;
        }
        private void closeframe1(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame1.Visibility = Visibility.Hidden;
        }

        private void goprop(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame1.Navigate(MainWindow.myprop);
        }

        private void goforward(object sender, MouseButtonEventArgs e)
        {
            system.dong(); forwardbigpic.Visibility = Visibility.Hidden;
            if (nowpage == 1) return;
            nowpage--; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void gobackward(object sender, MouseButtonEventArgs e)
        {
            system.dong(); backwordbigpic.Visibility = Visibility.Hidden;
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
        private void selectaplant(int kk)
        {
            int nowselect = find_mark_plant((nowpage - 1) * 9 + kk);
            if (nowselect == 0) return; selectplant = nowselect;
            int mark = MainWindow.mymain_interface.plantware[nowselect].mark;
            plantshow.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark.ToString() + ".png") as ImageSource;
            MainWindow.mysyn2page2.plantshow.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark.ToString() + ".png") as ImageSource;
            successshow();MainWindow.mysyn2page2.successshow();
        }
        private void pos11pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(1);
        }
        private void pos12pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(2);
        }
        private void pos13pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(3);
        }
        private void pos21pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(4);
        }
        private void pos22pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(5);
        }
        private void pos23pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(6);
        }
        private void pos31pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(7);
        }
        private void pos32pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(8);
        }

        private void synbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            synbutton.Source = new ImageSourceConverter().ConvertFromString("pic/合成亮.jpg") as ImageSource;
        }

        private void synbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            synbutton.Source = new ImageSourceConverter().ConvertFromString("pic/合成.jpg") as ImageSource;
        }

        private void synbutton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            synbutton.Source = new ImageSourceConverter().ConvertFromString("pic/合成按.jpg") as ImageSource;
        }

        private void synbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.dong(); synbutton.Source = new ImageSourceConverter().ConvertFromString("pic/合成亮.jpg") as ImageSource;
            if (MainWindow.mysyn2.selectplant == 0 || MainWindow.mysyn2.selectprop == 0) return;
            int supos = MainWindow.mysyn2.selectplant;
            string mark = MainWindow.mymain_interface.plantware[supos].mark.ToString();
            double rate = double.Parse(successtext.Text.Replace("%", ""));
            if (MainWindow.mymain_interface.prop_number[MainWindow.mysyn2.selectprop] < 1) { MessageBox.Show("物品不足");return; }
            MainWindow.mymain_interface.prop_number[MainWindow.mysyn2.selectprop]--;
            sql.sql_add_prop(MainWindow.mysyn2.selectprop);
            MainWindow.mysyn2page2.updatemess();
            rate = rate * 100;
            if (MainWindow.mysyn2.selectprop == 102)
            {
                int cutrate = (int)rate;
                int nowrand = (new Random()).Next(1,10000);
                if(nowrand <= cutrate)
                {
                    system.jiangli();
                    resultshow.Text = "品阶提升成功";resultshow.Visibility = Visibility.Visible;
                    MainWindow.mysynsuccess.pos = MainWindow.mysyn2.selectplant;
                    MainWindow.mysynsuccess.oldmark = MainWindow.mysynsuccess.newmark =
                        MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].mark;
                    MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                    MainWindow.mysynsuccess.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess);
                    MainWindow.mysyn2.emptysyn();
                    system.App.Delay(1000);resultshow.Visibility = Visibility.Hidden;
                    updatemess();
                }
                else
                {
                    resultshow.Text = "品阶提升失败"; resultshow.Visibility = Visibility.Visible;
                    system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;
                }
            }
            if (MainWindow.mysyn2.selectprop == 103)
            {
                system.jiangli();
                MainWindow.mysynsuccess2.pos = MainWindow.mysyn2.selectplant;
                MainWindow.mysynsuccess2.oldmark = MainWindow.mysynsuccess2.newmark =
                    MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].mark;
                MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                MainWindow.mysynsuccess2.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess2);
                system.App.Delay(2000); 
            }
            if (MainWindow.mysyn2.selectprop == 104)
            {
                system.jiangli();MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                syn2.mycopy();
                MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].lifadd += 5;
                sql.update_plant(MainWindow.mysyn2.selectplant);
                MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
            }
            if (MainWindow.mysyn2.selectprop == 105)
            {
                system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                syn2.mycopy();
                MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].attadd += 5;
                sql.update_plant(MainWindow.mysyn2.selectplant);
                MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
            }
            if (MainWindow.mysyn2.selectprop == 106)
            {
                system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                syn2.mycopy();
                MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].thradd += 5;
                sql.update_plant(MainWindow.mysyn2.selectplant); MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
            }
            if (MainWindow.mysyn2.selectprop == 107)
            {
                system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                syn2.mycopy();
                MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].armadd += 5;
                sql.update_plant(MainWindow.mysyn2.selectplant); MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
            }
            if (MainWindow.mysyn2.selectprop == 108)
            {
                system.jiangli();int addpos = MainWindow.mysyn2.selectplant;int flag108 = 0,leexp = 5000;
                while(flag108 == 0)
                {
                    flag108 = 1;
                    int lv = MainWindow.mymain_interface.plantware[addpos].lv;
                    int exp = MainWindow.mymain_interface.plantware[addpos].exp;
                    exp += leexp; leexp = 0;
                    if (exp > readclass.needexp[lv] )
                    {
                        flag108 = 0;exp -= readclass.needexp[lv];
                        MainWindow.mymain_interface.plantware[addpos].lv++;
                        MainWindow.mymain_interface.plantware[addpos].exp = exp;
                    }
                    else
                    {
                        MainWindow.mymain_interface.plantware[addpos].exp = exp;
                    }
                }
                sql.update_plant(addpos);
                updatemess();
                resultshow.Text = "获得5000经验"; resultshow.Visibility = Visibility.Visible;
                system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;
            }
            if (MainWindow.mysyn2.selectprop == 109)
            {
                system.jiangli(); int addpos = MainWindow.mysyn2.selectplant;
                MainWindow.mymain_interface.plantware[addpos].lv++;sql.update_plant(addpos);
                updatemess();
                resultshow.Text = "提升1级"; resultshow.Visibility = Visibility.Visible;
                system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;
            }
            if (MainWindow.mysyn2.selectprop == 110)
            {
                system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                syn2.mycopy();
                MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].growth += 5;
                sql.update_plant(MainWindow.mysyn2.selectplant);
                MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
                
            }
        }
        public static void mycopy()
        {
            MainWindow.mysynsuccess3.oldlif = readclass.read_lif(MainWindow.mysyn2.selectplant);
            MainWindow.mysynsuccess3.oldatt = readclass.read_att(MainWindow.mysyn2.selectplant);
            MainWindow.mysynsuccess3.oldthr = readclass.read_thr(MainWindow.mysyn2.selectplant);
            MainWindow.mysynsuccess3.oldarm = readclass.read_arm(MainWindow.mysyn2.selectplant);
            MainWindow.mysynsuccess3.oldgrow = MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].growth;
        }
        private void pos33pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(9); 
        }

        public void plantshow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mysyn2.selectplant = 0;
            MainWindow.mysyn2.plantshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2page2.plantshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2.successtext.Text = ""; MainWindow.mysyn2page2.successtext.Text = "";
        }

        private void propshow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mysyn2.selectprop = 0;
            MainWindow.mysyn2.propshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2page2.propshow.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            MainWindow.mysyn2.successtext.Text = ""; MainWindow.mysyn2page2.successtext.Text = "";
        }

        public void successshow()
        {
            if (MainWindow.mysyn2.selectplant == 0 || MainWindow.mysyn2.selectprop == 0) return;
            int supos = MainWindow.mysyn2.selectplant;
            if(MainWindow.mysyn2.selectprop == 102)
            {
                double quanow = MainWindow.mymain_interface.plantware[supos].quality;
                if (quanow < 1.01) successtext.Text = "100%";
                else if (quanow < 1.06) successtext.Text = "60%";
                else if (quanow < 1.11) successtext.Text = "35%";
                else if (quanow < 1.16) successtext.Text = "15%";
                else if (quanow < 1.21) successtext.Text = "10%";
                else if (quanow < 1.26) successtext.Text = "6%";
                else if (quanow < 1.31) successtext.Text = "6%";
                else if (quanow < 1.36) successtext.Text = "3%";
                else if (quanow < 1.41) successtext.Text = "2%";
                else if (quanow < 1.46) successtext.Text = "1%";
                else if (quanow < 1.51) successtext.Text = "1%";
                else if (quanow < 1.56) successtext.Text = "0.5%";
                else if (quanow < 1.61) successtext.Text = "0.5%";
                else if (quanow < 1.66) successtext.Text = "0.3%";
                else if (quanow < 1.71) successtext.Text = "0.3%";
                else if (quanow < 1.76) successtext.Text = "0.1%";
                else if (quanow < 1.81) successtext.Text = "0.1%";
                else successtext.Text = "0%";
            }
           else
            {
                successtext.Text = "100%";
            }

        }
        private void allhidden()
        {
            plant11frame.Visibility = Visibility.Hidden; plant12frame.Visibility = Visibility.Hidden;
            plant13frame.Visibility = Visibility.Hidden; plant31frame.Visibility = Visibility.Hidden;
            plant32frame.Visibility = Visibility.Hidden; plant21frame.Visibility = Visibility.Hidden;
            plant22frame.Visibility = Visibility.Hidden; plant23frame.Visibility = Visibility.Hidden;
            plant33frame.Visibility = Visibility.Hidden;
        }
        private void pos11detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 1) == 0) return;
            plant11frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 1); a.updatemess();
            plant11frame.Navigate(a);
        }
        private void pos11detailhid(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void pos12detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 2) == 0) return;
            plant12frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 2); a.updatemess();
            plant12frame.Navigate(a);
        }
        private void pos13detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 3) == 0) return;
            plant13frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 3); a.updatemess();
            plant13frame.Navigate(a);
        }

        private void pos31detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 7) == 0) return;
            plant31frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 7); a.updatemess();
            plant31frame.Navigate(a);
        }

        private void pos32detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 8) == 0) return;
            plant32frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 8); a.updatemess();
            plant32frame.Navigate(a);
        }

        private void pos21detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 4) == 0) return;
            plant21frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 4); a.updatemess();
            plant21frame.Navigate(a);
        }

        private void pos22detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 5) == 0) return;
            plant22frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 5); a.updatemess();
            plant22frame.Navigate(a);
        }

        private void pos23detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 6) == 0) return;
            plant23frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 6); a.updatemess();
            plant23frame.Navigate(a);
        }

        private void pos33detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 9 + 9) == 0) return;
            plant33frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 9 + 9); a.updatemess();
            plant33frame.Navigate(a);
        }


    }
}
