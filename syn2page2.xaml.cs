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
    public partial class syn2page2 : Page
    {
        public syn2page2()
        {
            InitializeComponent();
            successtext.Text = "";
            updatemess();
        }
        private int nowpage = 1; 
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
            MainWindow.mysyn2.updatemess();
        }
        private void gotosyn3(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn3); MainWindow.mysyn3.updatemess();
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
        }
        public void updatemess()
        {
            emptypage();
            int nowpos = (nowpage - 1) * 9 + 1; int realtime; 
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos11lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString()+"个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos12lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos13lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos21lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos22lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos23lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos31pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos31lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos32pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos32lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == 0) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos33pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos33lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
        }
        private int find_mark_plant(int findnumber)
        {
            int marknumber = 0, rem_answer = 0;
            int allnumber = readclass.read_int("data/synprop_number.txt");
            for (int i = 1; i <= allnumber; ++i)
            {
                if (MainWindow.mymain_interface.prop_number[i+101] <= 0) continue;
                marknumber++;
                if (marknumber == findnumber) rem_answer = i+101;
            }
            return rem_answer;
        }
        private void selectaplant(int kk)
        {
            int nowselect = find_mark_plant((nowpage - 1) * 9 + kk);
            if (nowselect == 0) return; MainWindow.mysyn2.selectprop = nowselect;
            propshow.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + nowselect.ToString() + ".png") as ImageSource;
            MainWindow.mysyn2.propshow.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + nowselect.ToString() + ".png") as ImageSource;
            successshow();MainWindow.mysyn2.successshow();
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
            if (MainWindow.mymain_interface.prop_number[MainWindow.mysyn2.selectprop] < 1) { MessageBox.Show("物品不足"); return; }
            MainWindow.mymain_interface.prop_number[MainWindow.mysyn2.selectprop]--;
            sql.sql_add_prop(MainWindow.mysyn2.selectprop);
            MainWindow.mysyn2page2.updatemess();
            rate = rate * 100;
            if (MainWindow.mysyn2.selectprop == 102)
            {
                int cutrate = (int)rate;
                int nowrand = (new Random()).Next(1, 10000);
                if (nowrand <= cutrate)
                {
                    system.jiangli();
                    resultshow.Text = "品阶提升成功"; resultshow.Visibility = Visibility.Visible;
                    MainWindow.mysynsuccess.pos = MainWindow.mysyn2.selectplant;
                    MainWindow.mysynsuccess.oldmark = MainWindow.mysynsuccess.newmark =
                        MainWindow.mymain_interface.plantware[MainWindow.mysyn2.selectplant].mark;
                    MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                    MainWindow.mysynsuccess.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess);
                    MainWindow.mysyn2.emptysyn();
                    system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;
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
                system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
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
                system.jiangli(); int addpos = MainWindow.mysyn2.selectplant; int flag108 = 0, leexp = 5000;
                while (flag108 == 0)
                {
                    flag108 = 1;
                    int lv = MainWindow.mymain_interface.plantware[addpos].lv;
                    int exp = MainWindow.mymain_interface.plantware[addpos].exp;
                    exp += leexp; leexp = 0;
                    if (exp > readclass.needexp[lv])
                    {
                        flag108 = 0; exp -= readclass.needexp[lv];
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
                MainWindow.mymain_interface.plantware[addpos].lv++; sql.update_plant(addpos);
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
            /*  system.dong();
              synbutton.Source = new ImageSourceConverter().ConvertFromString("pic/合成亮.jpg") as ImageSource;
              if (MainWindow.mysyn2.selectplant == 0 || MainWindow.mysyn2.selectprop == 0) return;
              int supos = MainWindow.mysyn2.selectplant;
              double rate = double.Parse(successtext.Text.Replace("%", ""));
              string road = "data/warehouse_prop/" + MainWindow.mysyn2.selectprop.ToString() + "/number.txt";
              if (readclass.read_int(road) < 1) { MessageBox.Show("物品不足"); return; }
              readclass.write_int(road, readclass.read_int(road) - 1);
              MainWindow.mysyn2page2.updatemess();
              rate = rate * 100;
              string mark = readclass.read_string("data/warehouse_plant/" + supos.ToString() + "/mark.txt");
              if (MainWindow.mysyn2.selectprop == 102)
              {
                  double quanow = readclass.read_double("data/warehouse_plant/" + supos.ToString() + "/quality.txt");
                  int cutrate = (int)rate;
                  int nowrand = (new Random()).Next(1, 10000);
                  if (nowrand <= cutrate)
                  {
                      system.jiangli();
                      resultshow.Text = "品阶提升成功"; resultshow.Visibility = Visibility.Visible;
                      MainWindow.mysynsuccess.pos = MainWindow.mysyn2.selectplant;
                      MainWindow.mysynsuccess.oldmark = MainWindow.mysynsuccess.newmark =
                          readclass.read_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/mark.txt");
                      MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                      MainWindow.mysynsuccess.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess);
                      MainWindow.mysyn2.emptysyn();
                      system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;

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
                      readclass.read_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/mark.txt");
                  MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                  MainWindow.mysynsuccess2.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess2);
              }
              if (MainWindow.mysyn2.selectprop == 104)
              {
                  system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                  syn2.mycopy();
                  readclass.write_int("data/warehouse_plant/99999/lifadd.txt", readclass.read_int("data/warehouse_plant/99999/lifadd.txt") + 5);
                  MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                  MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
                  readclass.write_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/lifadd.txt",
                      readclass.read_int("data/warehouse_plant/99999/lifadd.txt"));
              }
              if (MainWindow.mysyn2.selectprop == 105)
              {
                  system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                  syn2.mycopy();
                  readclass.write_int("data/warehouse_plant/99999/attadd.txt", readclass.read_int("data/warehouse_plant/99999/attadd.txt") + 5);
                  MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                  MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
                  readclass.write_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/attadd.txt",
                      readclass.read_int("data/warehouse_plant/99999/attadd.txt"));
              }
              if (MainWindow.mysyn2.selectprop == 106)
              {
                  system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                  syn2.mycopy();
                  readclass.write_int("data/warehouse_plant/99999/thradd.txt", readclass.read_int("data/warehouse_plant/99999/thradd.txt") + 5);
                  MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                  MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
                  readclass.write_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/thradd.txt",
                      readclass.read_int("data/warehouse_plant/99999/thradd.txt"));
              }
              if (MainWindow.mysyn2.selectprop == 107)
              {
                  system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                  syn2.mycopy();
                  readclass.write_int("data/warehouse_plant/99999/armadd.txt", readclass.read_int("data/warehouse_plant/99999/armadd.txt") + 5);
                  MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                  MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
                  readclass.write_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/armadd.txt",
                      readclass.read_int("data/warehouse_plant/99999/armadd.txt"));
              }
              if (MainWindow.mysyn2.selectprop == 108)
              {
                  system.jiangli(); int addpos = MainWindow.mysyn2.selectplant; int flag108 = 0, leexp = 5000;
                  while (flag108 == 0)
                  {
                      flag108 = 1;
                      int lv = readclass.read_int("data/warehouse_plant/" + addpos.ToString() + "/level.txt");
                      int exp = readclass.read_int("data/warehouse_plant/" + addpos.ToString() + "/exp.txt");
                      exp += leexp; leexp = 0;
                      if (exp > readclass.needexp[lv])
                      {
                          flag108 = 0; exp -= readclass.needexp[lv];
                          readclass.write_int("data/warehouse_plant/" + addpos.ToString() + "/level.txt", lv + 1);
                          readclass.write_int("data/warehouse_plant/" + addpos.ToString() + "/exp.txt", exp);
                      }
                      else
                      {
                          readclass.write_int("data/warehouse_plant/" + addpos.ToString() + "/level.txt", lv);
                          readclass.write_int("data/warehouse_plant/" + addpos.ToString() + "/exp.txt", exp);
                      }
                  }
                  updatemess();
                  resultshow.Text = "获得5000经验"; resultshow.Visibility = Visibility.Visible;
                  system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;
              }
              if (MainWindow.mysyn2.selectprop == 109)
              {
                  system.jiangli(); int addpos = MainWindow.mysyn2.selectplant;
                  readclass.write_int("data/warehouse_plant/" + addpos.ToString() + "/level.txt",
                      readclass.read_int("data/warehouse_plant/" + addpos.ToString() + "/level.txt") + 1);
                  updatemess();
                  resultshow.Text = "提升1级"; resultshow.Visibility = Visibility.Visible;
                  system.App.Delay(1000); resultshow.Visibility = Visibility.Hidden;
              }
              if (MainWindow.mysyn2.selectprop == 110)
              {
                  system.jiangli(); MainWindow.mysynsuccess3.pos = MainWindow.mysyn2.selectplant;
                  syn2.mycopy();
                  readclass.write_int("data/warehouse_plant/99999/growth.txt", readclass.read_int("data/warehouse_plant/99999/growth.txt") + 5);
                  MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
                  MainWindow.mysynsuccess3.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.mysynsuccess3);
                  readclass.write_int("data/warehouse_plant/" + MainWindow.mysyn2.selectplant.ToString() + "/growth.txt",
                      readclass.read_int("data/warehouse_plant/99999/growth.txt"));
              }*/
        }

        private void pos33pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); selectaplant(9);
        }
        public void successshow()
        {
            if (MainWindow.mysyn2.selectplant == 0 || MainWindow.mysyn2.selectprop == 0) return;
            int supos = MainWindow.mysyn2.selectplant;
            if (MainWindow.mysyn2.selectprop == 102)
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
       
    }
}
