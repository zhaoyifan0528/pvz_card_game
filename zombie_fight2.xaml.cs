﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
using WpfAnimatedGif;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class zombie_fight2 : Page
    {
        public zombie_fight2()
        {
            InitializeComponent();
            lessbl_text_hideen();
        }
        public int plant1bl = 0, plant2bl = 0, plant3bl = 0, plant4bl = 0, plant5bl = 0, zombie = 0;
        public int zombie1bl = 0, zombie2bl = 0, zombie3bl = 0, zombie4bl = 0,jump = 0;
        public int zombieatt1, zombiethr1, zombiearm1, selectzombie = 0;
        public int zombieatt2, zombiethr2, zombiearm2, zombieatt3, zombiethr3, zombiearm3, zombieatt4, zombiethr4, zombiearm4;
        public int zombielif1, zombielif2, zombielif3, zombielif4;

        private void back_MouseEnter(object sender, MouseEventArgs e)
        {
            back.Source = new ImageSourceConverter().ConvertFromString("pic/返回2.png") as ImageSource;
        }

        private void back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            back.Source = new ImageSourceConverter().ConvertFromString("pic/返回.png") as ImageSource;
            plant1bl = 0;plant2bl = 0;plant3bl = 0;plant4bl = 0;plant5bl = 0;system.dong();
        }

        private void back_MouseLeave(object sender, MouseEventArgs e)
        {
            back.Source = new ImageSourceConverter().ConvertFromString("pic/返回.png") as ImageSource;
        }

        public int remark = 0;
        int pos1 = MainWindow.myzombie_bf_fight.select1;
        int pos2 = MainWindow.myzombie_bf_fight.select2;
        int pos3 = MainWindow.myzombie_bf_fight.select3;
        int pos4 = MainWindow.myzombie_bf_fight.select4;
        int pos5 = MainWindow.myzombie_bf_fight.select5;
        int mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0, mark5 = 0;

       
        private void plantpic1_MediaEnded(object sender, RoutedEventArgs e)
        {
            (sender as MediaElement).Stop();
            (sender as MediaElement).Play();
        }

        private bool plant_all_die()
        {
            if (plant1bl > 0) return false; if (plant2bl > 0) return false; if (plant3bl > 0) return false;
            if (plant4bl > 0) return false; if (plant5bl > 0) return false;return true;
        }
        private bool zombie_all_die()
        {
            if (zombie1bl > 0) return false; if (zombie2bl > 0) return false; if (zombie3bl > 0) return false;
            if (zombie4bl > 0) return false;    return true;
        }
        public void fight()
        {
            bool flag = true;
            while(!plant_all_die()&&!zombie_all_die())
            {
                if (flag) plant_attack();
                else zombie_attack();
                flag = !flag;
            }
            jump = 0;
            if(zombie_all_die())
            {
                frame1.Visibility = Visibility.Visible; system.jiangli();MainWindow.myget_exp.zombie = selectzombie;
                frame1.Navigate(MainWindow.myget_exp);MainWindow.myget_exp.updatepos();
            }
            else
            {
                int num1 = 0, num2 = 0,num3 = 0,num4 = 0;
                int oldmark = MainWindow.mymain_interface.peo_qun;
                if(remark >= 100)
                {
                    int p = remark / 10 + 1;
                    num1 += p * 3;
                    num2 += p * 1;
                    int re = (remark - 100) / 10 - (oldmark - 100) / 10;
                    if (re < 0) re = 0;
                    num3 += re * 5;
                    num4 += re * 2;
                }
                if (remark >= 90) { num1 += 3;num2 += 1;if (oldmark < 90) { num3 += 5; num4 += 2; } }
                if (remark >= 80) { num1 += 2;num2 += 1; if (oldmark < 80) { num3 += 5; num4 += 2; } }
                if (remark >= 70) { num1 += 2; num2 += 1; if (oldmark < 70) { num3 += 4; num4 += 2; } }
                if (remark >= 60) { num1 += 1; num2 += 1; if (oldmark < 60) { num3 += 4; num4 += 1; } }
                if (remark >= 50) { num1 += 1; num2 += 0; if (oldmark < 50) { num3 += 3; num4 += 1; } }
                if (remark >= 40) { num1 += 0; num2 += 1; if (oldmark < 40) { num3 += 3; num4 += 1; } }
                if (remark >= 30) { num1 += 0; num2 += 0; if (oldmark < 30) { num3 += 2; num4 += 1; } }
                if (remark >= 20) { num1 += 0; num2 += 1; if (oldmark < 20) { num3 += 1; num4 += 1; } }
                if (remark >= 10) { num1 += 0; num2 += 0; if (oldmark < 10) { num3 += 1; num4 += 1; } }
                if(remark + 5 < oldmark) { num1 = 0;num2 = 0; }
                MainWindow.myget_prop2.mkdrop(944, num2, 126, num1, 944, num4, 126, num3);
                if (remark > oldmark) oldmark = remark;
                MainWindow.mymain_interface.peo_qun = oldmark;
                sql.sqlsolve("UPDATE MESSAGE SET ZOMBIEQUN = " + oldmark.ToString() + " WHERE MARK = " + 
                    MainWindow.mymain_interface.id.ToString());
                frame1.Visibility = Visibility.Visible; system.jiangli();
                frame1.Navigate(MainWindow.myget_prop2);
                MainWindow.myget_prop2.start_interface();
            }
        }
        private void plant_attack_detail(int num,int att,int thr)
        {
            
            int flag2 = 0;
            if (zombie_all_die()) return;
            while(flag2 == 0)
            {
                int p = (new Random()).Next(1, 5);
                if(p == 1&& zombie1bl > 0)
                {
                    double bei = (double)thr / (double)zombiearm1;
                    if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                    int lessbl = (int)((double)att * bei);
                    int upplant = zombie1bl;
                    zombie1bl -= lessbl;bullet.Visibility = Visibility.Visible;
                    if (num == 1) mymove(0, 0, 728, -135);
                    if (num == 2) mymove(126, 0, 728, -135);
                    if (num == 3) mymove(0, 135, 728, -135);
                    if (num == 4) mymove(126, 135, 728, -135);
                    if (num == 5) mymove(0, 270, 728, -135);
                    system.daji();
                    if (jump == 0) system.App.Delay(1000);
                    lessbl_text_hideen();bullet.Visibility = Visibility.Hidden;
                    zombie1lessblshow.Text = "-" + lessbl;
                    picmove(getpos(98, upplant, zombielif1), 0, getpos(98, zombie1bl, zombielif1), 0, zombie1xuetiao);
                    if (jump == 0) system.App.Delay(1000);
                    zombie1lessblshow.Text = "";
                    start_interface();flag2 = 1;
                }
                if(p == 2&& zombie2bl > 0)
                {
                    double bei = (double)thr / (double)zombiearm2;
                    if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                    int lessbl = (int)((double)att * bei);
                    int upplant = zombie2bl;
                    zombie2bl -= lessbl; bullet.Visibility = Visibility.Visible;
                    if (num == 1) mymove(0, 0, 728, 0);
                    if (num == 2) mymove(126, 0, 728, 0);
                    if (num == 3) mymove(0, 135, 728, 0);
                    if (num == 4) mymove(126, 135, 728, 0);
                    if (num == 5) mymove(0, 270, 728, 0); system.daji();
                    if (jump == 0) system.App.Delay(1000);
                    lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                    zombie2lessblshow.Text = "-" + lessbl;
                    picmove(getpos(93, upplant, zombielif2), 0, getpos(93, zombie2bl, zombielif2), 0, zombie2xuetiao);
                    if (jump == 0) system.App.Delay(1000);
                    zombie2lessblshow.Text = "";
                    start_interface(); flag2 = 1;
                }
                if (p == 3 && zombie3bl > 0)
                {
                    double bei = (double)thr / (double)zombiearm3;
                    if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                    int lessbl = (int)((double)att * bei);
                    int upplant = zombie3bl;
                    zombie3bl -= lessbl; bullet.Visibility = Visibility.Visible;
                    if (num == 1) mymove(0, 0, 728, 135);
                    if (num == 2) mymove(126, 0, 728, 135);
                    if (num == 3) mymove(0, 135, 728, 135);
                    if (num == 4) mymove(126, 135, 728, 135);
                    if (num == 5) mymove(0, 270, 728, 135); system.daji();
                    if (jump == 0) system.App.Delay(1000);
                    lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                    zombie3lessblshow.Text = "-" + lessbl;
                    picmove(getpos(93, upplant, zombielif3), 0, getpos(93, zombie3bl, zombielif3), 0, zombie3xuetiao);
                    if (jump == 0) system.App.Delay(1000);
                    zombie3lessblshow.Text = "";
                    start_interface(); flag2 = 1;
                }
                if (p == 4 && zombie4bl > 0)
                {
                    double bei = (double)thr / (double)zombiearm4;
                    if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                    int lessbl = (int)((double)att * bei);
                    int upplant = zombie4bl;
                    zombie4bl -= lessbl; bullet.Visibility = Visibility.Visible;
                    if (num == 1) mymove(0, 0, 728, 270);
                    if (num == 2) mymove(126, 0, 728, 270);
                    if (num == 3) mymove(0, 135, 728, 270);
                    if (num == 4) mymove(126, 135, 728, 270);
                    if (num == 5) mymove(0, 270, 728, 270); system.daji();
                    if (jump == 0) system.App.Delay(1000);
                    lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                    zombie4lessblshow.Text = "-" + lessbl;
                    picmove(getpos(93, upplant, zombielif4), 0, getpos(93, zombie4bl, zombielif4), 0, zombie4xuetiao);
                    if (jump == 0) system.App.Delay(1000);
                    zombie4lessblshow.Text = "";
                    start_interface(); flag2 = 1;
                }
            }
            
           
            
        }
        private void plant_attack()
        {
            if(plant1bl > 0)
            {
                int att = readclass.read_att(pos1), thr = readclass.read_thr(pos1);
                bullet.Source = new ImageSourceConverter().ConvertFromString("pic/bullet/" + mark1.ToString() + ".png") as ImageSource;
                plant_attack_detail(1,att, thr);
            }
            if (plant2bl > 0)
            {
                int att = readclass.read_att(pos2), thr = readclass.read_thr(pos2);
                bullet.Source = new ImageSourceConverter().ConvertFromString("pic/bullet/" + mark2.ToString() + ".png") as ImageSource;
                plant_attack_detail(2, att, thr); 
            }
            if (plant3bl > 0)
            {
                int att = readclass.read_att(pos3), thr = readclass.read_thr(pos3);
                bullet.Source = new ImageSourceConverter().ConvertFromString("pic/bullet/" + mark3.ToString() + ".png") as ImageSource;
                plant_attack_detail(3, att, thr);  
            }
            if (plant4bl > 0)
            {
                int att = readclass.read_att(pos4), thr = readclass.read_thr(pos4);
                bullet.Source = new ImageSourceConverter().ConvertFromString("pic/bullet/" + mark4.ToString() + ".png") as ImageSource;
                plant_attack_detail(4, att, thr);  
            }
            if (plant5bl > 0)
            {
                int att = readclass.read_att(pos5), thr = readclass.read_thr(pos5);
                bullet.Source = new ImageSourceConverter().ConvertFromString("pic/bullet/" + mark5.ToString() + ".png") as ImageSource;
                plant_attack_detail(5, att, thr);  
            }
            bullet.Source = new ImageSourceConverter().ConvertFromString("pic/bullet/41.png") as ImageSource;
        }
        private int zombielif;
        private int getpos(int alllen,int nowbl,int alllif)
        {
            int a = (int)(-(alllen - (double)alllen * ((double)nowbl / (double)alllif)));
            return a;
        }
        private void zombie_attack_detail(int num,int att,int thr)
        {
            if (plant1bl > 0)
            {
                double bei = (double)thr/ (double)readclass.read_arm(pos1);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)att * bei);
                int upplant = plant1bl;
                plant1bl -= lessbl; bullet.Visibility = Visibility.Visible;
                if (num == 1) mymove(728, -135, 0, 2);
                if (num == 2) mymove(728, 0, 0, 2);
                if (num == 3) mymove(728, 135, 0, 2);
                if (num == 4) mymove(728, 270, 0, 2); system.daji();
                if (jump == 0) system.App.Delay(1000);
                lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                plant1lessblshow.Text = "-" + lessbl;
                picmove(getpos(82, upplant,readclass.read_lif(pos1)), 0,
                    getpos(82,plant1bl, readclass.read_lif(pos1)),0,plant1xuetiao);
                if (jump == 0) system.App.Delay(1000);
                plant1lessblshow.Text = "";
                start_interface();
            }
            else if (plant2bl > 0)
            {
                double bei = (double)thr / (double)readclass.read_arm(pos2);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)att * bei);
                int upplant = plant2bl;
                plant2bl -= lessbl; bullet.Visibility = Visibility.Visible;
                if (num == 1) mymove(728, -135, 126, 0);
                if (num == 2) mymove(728, 0, 126, 0);
                if (num == 3) mymove(728, 135, 126, 0);
                if (num == 4) mymove(728, 270, 126, 0); system.daji();
                if (jump == 0) system.App.Delay(1000);
                lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                plant2lessblshow.Text = "-" + lessbl;
                picmove(getpos(91, upplant, readclass.read_lif(pos2)), 0,
                    getpos(91, plant2bl, readclass.read_lif(pos2)), 0, plant2xuetiao);
                if (jump == 0) system.App.Delay(1000);
                plant2lessblshow.Text = "";
                start_interface();
            }
            else if (plant3bl > 0)
            {
                double bei = (double)thr / (double)readclass.read_arm(pos3);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)att * bei);
                int upplant = plant3bl;
                plant3bl -= lessbl; bullet.Visibility = Visibility.Visible;
                if (num == 1) mymove(728, -135, 0, 135);
                if (num == 2) mymove(728, 0, 0, 135);
                if (num == 3) mymove(728, 135, 0,135);
                if (num == 4) mymove(728, 270, 0, 135); system.daji();
                if (jump == 0) system.App.Delay(1000);
                lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                plant3lessblshow.Text = "-" + lessbl;
                picmove(getpos(90, upplant, readclass.read_lif(pos3)), 0,
                    getpos(90, plant3bl, readclass.read_lif(pos3)), 0, plant3xuetiao);
                if (jump == 0) system.App.Delay(1000);
                plant3lessblshow.Text = "";
                start_interface();
            }
            else if (plant4bl > 0)
            {
                double bei = (double)thr / (double)readclass.read_arm(pos4);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)att * bei);
                int upplant = plant4bl;
                plant4bl -= lessbl; bullet.Visibility = Visibility.Visible;
                if (num == 1) mymove(728, -135, 126, 135);
                if (num == 2) mymove(728, 0, 126, 135);
                if (num == 3) mymove(728, 135, 126, 135);
                if (num == 4) mymove(728, 270, 126, 135); system.daji();
                if (jump == 0) system.App.Delay(1000);
                lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                plant4lessblshow.Text = "-" + lessbl;
                picmove(getpos(84, upplant, readclass.read_lif(pos4)), 0, 
                    getpos(84, plant4bl, readclass.read_lif(pos4)), 0, plant4xuetiao);
                if (jump == 0) system.App.Delay(1000);
                plant4lessblshow.Text = "";
                start_interface();
            }
            else if (plant5bl > 0)
            {
                double bei = (double)thr / (double)readclass.read_arm(pos5);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)att * bei);
                int upplant = plant5bl;
                plant5bl -= lessbl; bullet.Visibility = Visibility.Visible;
                if (num == 1) mymove(728, -135, 0, 270);
                if (num == 2) mymove(728, 0, 0, 270);
                if (num == 3) mymove(728, 135, 0, 270);
                if (num == 4) mymove(728, 270, 0, 270); system.daji();
                if (jump == 0) system.App.Delay(1000);
                lessbl_text_hideen(); bullet.Visibility = Visibility.Hidden;
                plant5lessblshow.Text = "-" + lessbl;
                picmove(getpos(90, upplant, readclass.read_lif(pos5)), 0,
                    getpos(90, plant5bl, readclass.read_lif(pos5)), 0, plant5xuetiao);
                if (jump == 0) system.App.Delay(1000);
                plant5lessblshow.Text = "";
                start_interface();
            }
        }
        private void zombie_attack()
        {
            if (zombie1bl > 0)
            {
                zombie_attack_detail(1,zombieatt1,zombiethr1); 
            }
            if (zombie2bl > 0)
            {
                zombie_attack_detail(2, zombieatt2, zombiethr2);  
            }
            if (zombie3bl > 0)
            {
                zombie_attack_detail(3, zombieatt3, zombiethr3);
            }
            if (zombie4bl > 0)
            {
                zombie_attack_detail(4, zombieatt4, zombiethr4); 
            }
            
        }
        public void setgif(Image img,int mark)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@Environment.CurrentDirectory+"\\pic/move/"+mark.ToString()+".gif");
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);
        }
        public void start_interface()
        {
            frame1.Visibility = Visibility.Hidden;
            pos1 = MainWindow.myzombie_bf_fight.select1; plantpic1.Visibility = Visibility.Visible;
            pos2 = MainWindow.myzombie_bf_fight.select2; plantpic2.Visibility = Visibility.Visible;
            pos3 = MainWindow.myzombie_bf_fight.select3; plantpic3.Visibility = Visibility.Visible;
            pos4 = MainWindow.myzombie_bf_fight.select4; plantpic4.Visibility = Visibility.Visible;
            pos5 = MainWindow.myzombie_bf_fight.select5; plantpic5.Visibility = Visibility.Visible;
            if (pos1 != 0) mark1 = MainWindow.mymain_interface.plantware[pos1].mark; else mark1 = 0;
            if (pos2 != 0) mark2 = MainWindow.mymain_interface.plantware[pos2].mark; else mark2 = 0;
            if (pos3 != 0) mark3 = MainWindow.mymain_interface.plantware[pos3].mark; else mark3 = 0;
            if (pos4 != 0) mark4 = MainWindow.mymain_interface.plantware[pos4].mark; else mark4 = 0;
            if (pos5 != 0) mark5 = MainWindow.mymain_interface.plantware[pos5].mark; else mark5 = 0;
            if (mark1 == 0 || plant1bl <= 0) plantpic1.Visibility = Visibility.Hidden;
            else setgif(plantpic1,mark1);
            if (mark2 == 0 || plant2bl <= 0) plantpic2.Visibility = Visibility.Hidden;
            else setgif(plantpic2, mark2);
            if (mark3 == 0 || plant3bl <= 0) plantpic3.Visibility = Visibility.Hidden;
            else setgif(plantpic3, mark3);
            if (mark4 == 0 || plant4bl <= 0) plantpic4.Visibility = Visibility.Hidden;
            else setgif(plantpic4, mark4);
            if (mark5 == 0 || plant5bl <= 0) plantpic5.Visibility = Visibility.Hidden;
            else setgif(plantpic5, mark5);

            if (zombie1bl <= 0)
            {
                remark++;
                zombiearm1 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/arm.txt") + 30 * remark*(int)Math.Pow(1.5,(double)remark/10.0);
                zombieatt1 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/att.txt") + 30 * remark *(int)Math.Pow(1.5, (double)remark/10.0);
                zombiethr1 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/thr.txt") + 30 * remark *(int)Math.Pow(1.5, (double)remark/10.0);
                zombie1bl = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/lif.txt") + 200 * remark * (int)Math.Pow(1.5, (double)remark / 10.0);
                zombielif1 = zombie1bl;
                picmove(0, 0, 0, 0, zombie1xuetiao);
            }
            else zombiepic1.Source = new ImageSourceConverter().ConvertFromString("pic/zombie/"+selectzombie.ToString()+".png") as ImageSource;
            if (zombie2bl <= 0)
            {
                remark++;
                zombiearm2 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/arm.txt") + 30 * remark * (int)Math.Pow(1.5, (double)remark/10.0);
                zombieatt2 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/att.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombiethr2 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/thr.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombie2bl = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/lif.txt") + 200 * remark * (int)Math.Pow(1.5, (double)remark / 10.0);
                zombielif2 = zombie2bl;
                picmove(0, 0, 0, 0, zombie2xuetiao);
            }
            else zombiepic2.Source = new ImageSourceConverter().ConvertFromString("pic/zombie/" + selectzombie.ToString() + ".png") as ImageSource;
            if (zombie3bl <= 0)
            {
                remark++;
                zombiearm3 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/arm.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombieatt3 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/att.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombiethr3 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/thr.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombie3bl = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/lif.txt") + 200 * remark * (int)Math.Pow(1.5, (double)remark / 10.0);
                zombielif3 = zombie3bl;
                picmove(0, 0, 0, 0, zombie3xuetiao);
            }
            else zombiepic3.Source = new ImageSourceConverter().ConvertFromString("pic/zombie/" + selectzombie.ToString() + ".png") as ImageSource;
            if (zombie4bl <= 0)
            {
                remark++;
                zombiearm4 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/arm.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombieatt4 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/att.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombiethr4 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/thr.txt") + 30 * remark * (int)Math.Pow(1.5,(double)remark/10.0);
                zombie4bl = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/lif.txt") + 200 * remark * (int)Math.Pow(1.5, (double)remark / 10.0);
                zombielif4 = zombie4bl;
                picmove(0, 0, 0, 0, zombie4xuetiao);
            }
            else zombiepic4.Source = new ImageSourceConverter().ConvertFromString("pic/zombie/" + selectzombie.ToString() + ".png") as ImageSource;
            kkshow.Text = "第"+remark.ToString()+"等级";
        }
        public void lessbl_text_hideen()
        {
            plant1lessblshow.Text = ""; plant2lessblshow.Text = ""; plant3lessblshow.Text = ""; plant4lessblshow.Text = "";
            plant5lessblshow.Text = "";zombie1lessblshow.Text = ""; zombie2lessblshow.Text = ""; zombie3lessblshow.Text = "";
            zombie4lessblshow.Text = "";
        }
        public void start_bl()
        {
            frame1.Visibility = Visibility.Hidden;kkshow.Text = "第0等级";
            pos1 = MainWindow.myzombie_bf_fight.select1;
            pos2 = MainWindow.myzombie_bf_fight.select2;
            pos3 = MainWindow.myzombie_bf_fight.select3;
            pos4 = MainWindow.myzombie_bf_fight.select4;
            pos5 = MainWindow.myzombie_bf_fight.select5;
            if (pos1 == 0) plant1bl = 0; else plant1bl = readclass.read_lif(pos1);
            if (pos2 == 0) plant2bl = 0; else plant2bl = readclass.read_lif(pos2);
            if (pos3 == 0) plant3bl = 0; else plant3bl = readclass.read_lif(pos3);
            if (pos4 == 0) plant4bl = 0; else plant4bl = readclass.read_lif(pos4);
            if (pos5 == 0) plant5bl = 0; else plant5bl = readclass.read_lif(pos5);
            zombie1bl = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/lif.txt");
            zombie2bl = zombie1bl; zombie3bl = zombie1bl; zombie4bl = zombie1bl;zombielif =zombielif1 = zombielif2 = zombielif3 = zombielif4 =  zombie1bl;
            zombieatt1 = zombieatt2 = zombieatt3 = zombieatt4 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/att.txt");
            zombiethr1 = zombiethr2 = zombiethr3 = zombiethr4 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/thr.txt");
            zombiearm1 = zombiearm2 = zombiearm3 = zombiearm4 = readclass.read_int("data/zombie/" + selectzombie.ToString() + "/arm.txt");
            if (pos1 != 0) { picmove(0, 0, 0, 0, plant1xuetiao); plant1xuetiao.Visibility = Visibility.Visible; }
            else plant1xuetiao.Visibility = Visibility.Hidden;
            if (pos2 != 0) { picmove(0, 0, 0, 0, plant2xuetiao); plant2xuetiao.Visibility = Visibility.Visible; }
            else plant2xuetiao.Visibility = Visibility.Hidden;
            if (pos3 != 0) { picmove(0, 0, 0, 0, plant3xuetiao); plant3xuetiao.Visibility = Visibility.Visible; }
            else plant3xuetiao.Visibility = Visibility.Hidden;
            if (pos4 != 0) { picmove(0, 0, 0, 0, plant4xuetiao); plant4xuetiao.Visibility = Visibility.Visible; }
            else plant4xuetiao.Visibility = Visibility.Hidden;
            if (pos5 != 0) { picmove(0, 0, 0, 0, plant5xuetiao); plant5xuetiao.Visibility = Visibility.Visible; }
            else plant5xuetiao.Visibility = Visibility.Hidden;


            picmove(0, 0, 0, 0, zombie1xuetiao);
            picmove(0, 0, 0, 0, zombie2xuetiao); picmove(0, 0, 0, 0, zombie3xuetiao); picmove(0, 0, 0, 0, zombie4xuetiao);
        }
        private void picmove(int stxpos, int stypos, int movex, int movey,Image img)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.Duration = new Duration
                (TimeSpan.FromSeconds(1));

            TranslateTransform transform = new TranslateTransform();
            img.RenderTransform = transform;
            transform.X = stxpos;

            doubleAnimation.To = movex;
            transform.Y = stypos;


            transform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
            doubleAnimation.To = movey;
            transform.BeginAnimation(TranslateTransform.YProperty, doubleAnimation);
        }
        private void mymove(int stxpos,int stypos,int movex,int movey)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.Duration = new Duration
                (TimeSpan.FromSeconds(1));

            TranslateTransform transform = new TranslateTransform();
            bullet.RenderTransform = transform;
            transform.X = stxpos;

            doubleAnimation.To = movex;
            transform.Y = stypos;

            
            transform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
            doubleAnimation.To = movey;
            transform.BeginAnimation(TranslateTransform.YProperty, doubleAnimation);
        }

        
    }
}
