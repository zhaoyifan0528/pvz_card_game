using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public partial class pvz1 : Page
    {
        public int alltimemark = 0;
        DateTime st;public int plant_sun_mark = 0;
        public pvz1()
        {
            InitializeComponent();
            pos[1] = new int[12];pos[2] = new int[12];pos[3] = new int[12];pos[4] = new int[12];pos[5] = new int[12];
            posatt[1] = new int[12]; posatt[2] = new int[12]; posatt[3] = new int[12]; posatt[4] = new int[12]; posatt[5] = new int[12];
            st = DateTime.Now;
            planty[1] = 46;planty[2] = 155;planty[3] = 264;planty[4] = 372;planty[5] = 482;planty[6] = 594;
            planty[7] = 696; planty[8] = 801;planty[9] = 915;plantx[1] = 124;plantx[2] = 252;plantx[3] = 386;
            plantx[4] = 520;plantx[5] = 648; 
        }
        public int[] planty = new int[12];public int[] plantx = new int[6];
        public int select1, select2, select3, select4, select5,flag_select = 0;
        public int mark1, mark2, mark3, mark4, mark5;
        public int[][] pos = new int[6][],posatt = new int[6][];
        public int planttime1 = -99999, planttime2 = -99999, planttime3 = -99999, planttime4 = -99999, planttime5 = -99999;
        static private Dictionary<int, int> zombie = new Dictionary<int, int>();
        static private Dictionary<int, int> zombiebl = new Dictionary<int, int>();
        static private Dictionary<int, int> zombiedietime = new Dictionary<int, int>();
        static private Dictionary<int, int> zombieline = new Dictionary<int, int>();
        static private Dictionary<int, Image> zombiepic = new Dictionary<int, Image>();
        static private Dictionary<int, Image> bullet = new Dictionary<int, Image>();
        static private Dictionary<int, Image> sunpic = new Dictionary<int, Image>();
        static private Dictionary<int, int> bulletdietime = new Dictionary<int, int>();
        static private Dictionary<int, int> sundietime = new Dictionary<int, int>();
        static private Dictionary<int, Image> mksunpic = new Dictionary<int, Image>();

        public int zombietime = 0,bulletnumber = 0,suntime = -30,sunmark = 0,mksunmark = 0;
        public int flag1_blhid = 0, flag2_blhid = 0, flag3_blhid = 0, flag4_blhid = 0, flag5_blhid = 0;
        public int nowzombie_number = 0,needmoney = 0;
        public void setgif(Image img, int mark)
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(@Environment.CurrentDirectory + "\\pic/move/" + mark.ToString() + ".gif");
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);
           
        }
        public int get_nowtime()
        {
            int a = (DateTime.Now.Day - st.Day) * 24;
            a = (a + DateTime.Now.Hour - st.Hour) * 60;
            a = (a + DateTime.Now.Minute - st.Minute) * 60;
            a = (a + DateTime.Now.Second - st.Second) * 1000;
            a = (a + DateTime.Now.Millisecond - st.Millisecond);
            return a;
        }
        public void allclear()
        {
            flag_select = 0;bulletnumber = 0;moneyshow.Text = "50";suntime =-30;zombietime = 0;
            flag1_blhid = 0; flag2_blhid = 0; flag3_blhid = 0; flag4_blhid = 0; flag5_blhid = 0;
            planttime1 = -99999; planttime2 = -99999; planttime3 = -99999; planttime4 = -99999; planttime5 = -99999;
            for (int i = 1; i <= 5; ++i) for (int j = 1; j <= 9; ++j) { pos[i][j] = 0;posatt[i][j] = 0; }
            setgif(pos11pic, 99999); setgif(pos12pic, 99999); setgif(pos13pic, 99999); setgif(pos14pic, 99999);
            setgif(pos15pic, 99999); setgif(pos16pic, 99999); setgif(pos17pic, 99999); setgif(pos18pic, 99999);
            setgif(pos19pic, 99999);
            setgif(pos21pic, 99999); setgif(pos22pic, 99999); setgif(pos23pic, 99999); setgif(pos24pic, 99999);
            setgif(pos25pic, 99999); setgif(pos26pic, 99999); setgif(pos27pic, 99999); setgif(pos28pic, 99999);
            setgif(pos29pic, 99999);
            setgif(pos31pic, 99999); setgif(pos32pic, 99999); setgif(pos33pic, 99999); setgif(pos34pic, 99999);
            setgif(pos35pic, 99999); setgif(pos36pic, 99999); setgif(pos37pic, 99999); setgif(pos38pic, 99999);
            setgif(pos39pic, 99999);
            setgif(pos41pic, 99999); setgif(pos42pic, 99999); setgif(pos43pic, 99999); setgif(pos44pic, 99999);
            setgif(pos45pic, 99999); setgif(pos46pic, 99999); setgif(pos47pic, 99999); setgif(pos48pic, 99999);
            setgif(pos49pic, 99999);
            setgif(pos51pic, 99999); setgif(pos52pic, 99999); setgif(pos53pic, 99999); setgif(pos54pic, 99999);
            setgif(pos55pic, 99999); setgif(pos56pic, 99999); setgif(pos57pic, 99999); setgif(pos58pic, 99999);
            setgif(pos59pic, 99999);
            select1 = MainWindow.myzombie_bf_fight.select1; select2 = MainWindow.myzombie_bf_fight.select2;
            select3 = MainWindow.myzombie_bf_fight.select3; select4 = MainWindow.myzombie_bf_fight.select4;
            select5 = MainWindow.myzombie_bf_fight.select5;blackhidden();
        }
        public void start_interface()
        {
            allclear();flag = true;zombie.Clear();zombiepic.Clear();zombiebl.Clear();zombietime = 0;alltimemark = 0;nowzombie_number = 0;
            st = DateTime.Now;
            if (select1 != 0) mark1 = MainWindow.mymain_interface.plantware[select1].mark;
            if (select2 != 0) mark2 = MainWindow.mymain_interface.plantware[select2].mark;
            if (select3 != 0) mark3 = MainWindow.mymain_interface.plantware[select3].mark;
            if (select4 != 0) mark4 = MainWindow.mymain_interface.plantware[select4].mark;
            if (select5 != 0) mark5 = MainWindow.mymain_interface.plantware[select5].mark;
            if (select1 != 0)
            { plantselect_img_1.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark1.ToString() + ".png") as ImageSource;
                plant_select_needtext1.Text = readclass.read_string("data/plant_ill/" + mark1.ToString() + "/sunneed.txt");
            }
            else { plantselect_img_1.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource; select1_black.Visibility = Visibility.Visible; flag1_blhid = 1; }
            if (select2 != 0)
            { plantselect_img_2.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark2.ToString() + ".png") as ImageSource; 
                plant_select_needtext2.Text = readclass.read_string("data/plant_ill/" + mark2.ToString() + "/sunneed.txt"); }
            else { plantselect_img_2.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource; select2_black.Visibility = Visibility.Visible; flag2_blhid = 1; }
            if (select3 != 0)
            { plantselect_img_3.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark3.ToString() + ".png") as ImageSource;
                plant_select_needtext3.Text = readclass.read_string("data/plant_ill/" + mark3.ToString() + "/sunneed.txt");
            }
            else { plantselect_img_3.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource; select3_black.Visibility = Visibility.Visible; flag3_blhid = 1; }
            if (select4 != 0)
            { plantselect_img_4.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark4.ToString() + ".png") as ImageSource;
                plant_select_needtext4.Text = readclass.read_string("data/plant_ill/" + mark4.ToString() + "/sunneed.txt");
            }
            else { plantselect_img_4.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource; select4_black.Visibility = Visibility.Visible; flag4_blhid = 1; }
            if (select5 != 0)
            { plantselect_img_5.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark5.ToString() + ".png") as ImageSource;
                plant_select_needtext5.Text = readclass.read_string("data/plant_ill/" + mark5.ToString() + "/sunneed.txt");
            }
            else { plantselect_img_5.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource; select5_black.Visibility = Visibility.Visible; flag5_blhid = 1; }

        }
        private void blackhidden()
        {
            if (flag1_blhid == 0) select1_black.Visibility = Visibility.Hidden;
            if (flag2_blhid == 0) select2_black.Visibility = Visibility.Hidden;
            if (flag3_blhid == 0) select3_black.Visibility = Visibility.Hidden;
            if (flag4_blhid == 0) select4_black.Visibility = Visibility.Hidden;
            if (flag5_blhid == 0) select5_black.Visibility = Visibility.Hidden;
            chan_black.Visibility = Visibility.Hidden;
        }
        private void select1_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (flag1_blhid == 1||select1 == 0||int.Parse(moneyshow.Text) < int.Parse(plant_select_needtext1.Text)) { system.buzzer(); return; }
            blackhidden(); select1_black.Visibility = Visibility.Visible;system.getplant();
            flag_select = select1;needmoney = int.Parse(plant_select_needtext1.Text); 
        }
        private void select2_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (flag2_blhid == 1 || select2 == 0 || int.Parse(moneyshow.Text) < int.Parse(plant_select_needtext2.Text)) { system.buzzer(); return; }
            blackhidden(); select2_black.Visibility = Visibility.Visible; system.getplant();
            flag_select = select2; needmoney = int.Parse(plant_select_needtext2.Text);
        }
        private void select3_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (flag3_blhid == 1 || select3 == 0 || int.Parse(moneyshow.Text) < int.Parse(plant_select_needtext3.Text)) { system.buzzer(); return; }
            blackhidden(); select3_black.Visibility = Visibility.Visible; system.getplant();
            flag_select = select3; needmoney = int.Parse(plant_select_needtext3.Text);
        }
        private void select4_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (flag4_blhid == 1 || select4 == 0 || int.Parse(moneyshow.Text) < int.Parse(plant_select_needtext4.Text)) { system.buzzer(); return; }
            blackhidden(); select4_black.Visibility = Visibility.Visible; system.getplant();
            flag_select = select4; needmoney = int.Parse(plant_select_needtext4.Text);
        }
        private void select5_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (flag5_blhid == 1 || select5 == 0 || int.Parse(moneyshow.Text) < int.Parse(plant_select_needtext5.Text)) {system.buzzer(); return; }
            blackhidden(); select5_black.Visibility = Visibility.Visible; system.getplant();
            flag_select = select5; needmoney = int.Parse(plant_select_needtext5.Text);
        }
        public void moveblack()
        {
            if(select1 == flag_select)
            {
                flag1_blhid = 1;planttime1 = get_nowtime();
                system.picmove(0, 0, 0, -89, select1_black, 10);
            }
            if (select2 == flag_select)
            {
                flag2_blhid = 1; planttime2 = get_nowtime();
                system.picmove(0, 0, 0, -89, select2_black, 10);
            }
            if (select3 == flag_select)
            {
                flag3_blhid = 1; planttime3 = get_nowtime();
                system.picmove(0, 0, 0, -89, select3_black, 10);
            }
            if (select4 == flag_select)
            {
                flag4_blhid = 1; planttime4 = get_nowtime();
                system.picmove(0, 0, 0, -89, select4_black, 10);
            }
            if (select5 == flag_select)
            {
                flag5_blhid = 1; planttime5 = get_nowtime();
                system.picmove(0, 0, 0, -89, select5_black, 10);
            }
        }
        public bool flag = true;
        public void clear_allzombie()
        {
            foreach(var item in zombie)
            {
                mygrid.Children.Remove(zombiepic[item.Key]);
                zombiepic.Remove(item.Key);zombiebl.Remove(item.Key);zombie.Remove(item.Key);
            }
        }
        public void clear_allsun()
        {
            foreach(var item in mksunpic)
            {
                mygrid.Children.Remove(mksunpic[item.Key]);
                mksunpic.Remove(item.Key);
            }
        }
        public void clear_allbullet()
        {
            foreach (var item in bullet)
            {
                mygrid.Children.Remove(bullet[item.Key]);
                bullet.Remove(item.Key);
            }
        }
        public void fight()
        {
            while(flag)
            {
                GC.Collect();if (alltimemark == 0) { system.pvzmusic();system.readyput(); }
                system.App.Delay(200);alltimemark++;
                if (get_nowtime() - planttime1 >= 10000&&flag1_blhid == 1) 
                { flag1_blhid = 0; system.picmove(0, 0, 0, 0, select1_black,0); select1_black.Visibility = Visibility.Hidden; }
                if (get_nowtime() - planttime2 >= 10000 && flag2_blhid == 1)
                { flag2_blhid = 0; system.picmove(0, 0, 0, 0, select2_black, 0); select2_black.Visibility = Visibility.Hidden; }
                if (get_nowtime() - planttime3 >= 10000 && flag3_blhid == 1)
                { flag3_blhid = 0; system.picmove(0, 0, 0, 0, select3_black, 0); select3_black.Visibility = Visibility.Hidden; }
                if (get_nowtime() - planttime4 >= 10000 && flag4_blhid == 1)
                { flag4_blhid = 0; system.picmove(0, 0, 0, 0, select4_black, 0); select4_black.Visibility = Visibility.Hidden; }
                if (get_nowtime() - planttime5 >= 10000 && flag5_blhid == 1)
                { flag5_blhid = 0; system.picmove(0, 0, 0, 0, select5_black, 0); select5_black.Visibility = Visibility.Hidden; }
                for(int i = 1;i <= Math.Min(10,Math.Max(1,alltimemark/60))  //刷新僵尸
                    && alltimemark - zombietime > Math.Max(1, 5000 / alltimemark); ++i)
                {
                    if (get_nowtime() > 180000) continue;
                    zombie[++nowzombie_number] = get_nowtime();
                    if (nowzombie_number == 1) system.zombiecom();
                    zombieline[nowzombie_number] = (new Random()).Next(1, 6);
                    zombiebl[nowzombie_number] = (int)(200.0*Math.Pow(1.15,MainWindow.mypvz_select.diff));
                    zombiedietime[nowzombie_number] = 0;
                    zombiepic[nowzombie_number] = new Image();
                    zombiepic[nowzombie_number].Height = zombic.Height;
                    zombiepic[nowzombie_number].Width = zombic.Width;
                    Thickness p = zombic.Margin;
                    p.Top = plantx[zombieline[nowzombie_number]] - 20;
                    zombiepic[nowzombie_number].Margin = p;
                    zombiepic[nowzombie_number].Source = zombic.Source;
                    zombiepic[nowzombie_number].HorizontalAlignment = zombic.HorizontalAlignment;
                    zombiepic[nowzombie_number].VerticalAlignment = zombic.VerticalAlignment;
                    mygrid.Children.Add(zombiepic[nowzombie_number]);
                    system.picmove(30, 0, -1120, 0, zombiepic[nowzombie_number],40);
                    if(i == Math.Min(10, Math.Max(1, alltimemark / 100))) zombietime = alltimemark;
                }
                if(get_nowtime()>180000&&zombie.Count() <= 0)
                {
                    system.winmusic();
                    int num1 = 0, num2 = 0;
                    num2 = (int) Math.Pow(1.1, MainWindow.mypvz_select.diff) * 10;
                    num1 = Math.Max(1, (int)Math.Pow(1.3, MainWindow.mypvz_select.diff-10));
                    MainWindow.myget_prop2.mkdrop(123, num2, 110, num1, 0, 0, 0, 0);
                    MainWindow.mypvz1.flag = false; MainWindow.mypvz1.clear_allsun(); MainWindow.mypvz1.clear_allzombie();
                    clear_allbullet();
                    MainWindow.mymain_interface.pvzmusic.Stop();
                    frame1.Visibility = Visibility.Visible; system.jiangli();
                    frame1.Navigate(MainWindow.myget_prop2);
                    MainWindow.myget_prop2.gamemode = 3;
                    MainWindow.myget_prop2.start_interface();
                }
                foreach(var item in zombie)
                {
                    double tim = (get_nowtime() - item.Value);
                    if(tim > 40000)
                    {
                        system.losemusic();
                        flag = false; clear_allsun(); clear_allzombie(); MainWindow.mymain_interface.pvzmusic.Stop(); clear_allbullet();
                        system.App.Delay(3000);
                        MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
                        break;
                    }
                }
                if(alltimemark - suntime > 40)
                {
                    sun.Visibility = Visibility.Visible;
                    suntime = alltimemark;
                    sunpic[++sunmark] = new Image();
                    sunpic[sunmark] = sun;
                    int rd = (new Random()).Next(0, 1000);
                    system.picmove(rd, -100, rd, 700, sunpic[sunmark], 15);
                   
                }
                foreach(var item in zombie)                         //删除僵尸
                {
                    if (zombiedietime[item.Key] == 0||zombiebl[item.Key] > 0) continue;
                    if(zombiedietime[item.Key] <= get_nowtime())
                    {
                        zombiepic[item.Key].Visibility = Visibility.Hidden;
                        zombie.Remove(item.Key);zombiebl.Remove(item.Key);
                        mygrid.Children.Remove(zombiepic[item.Key]);
                        zombiepic.Remove(item.Key);
                    }
                }
                foreach(var item in bulletdietime)                  //删除子弹
                {
                    if(get_nowtime() >= item.Value)
                    {
                        bullet[item.Key].Visibility = Visibility.Hidden;
                        mygrid.Children.Remove(bullet[item.Key]);
                        bulletdietime.Remove(item.Key);bullet.Remove(item.Key);
                        int musicmark = (new Random()).Next(1, 4);
                        if (musicmark == 1) system.splat1();
                        if (musicmark == 2) system.splat2();
                        if (musicmark == 3) system.splat3();
                    }
                }
                for(int i=1;i<=5;++i)                               
                     for(int j=1;j<=9;++j)
                     {
                        if (pos[i][j] == 0) continue;
                        int mark = MainWindow.mymain_interface.plantware[pos[i][j]].mark; 
                        if (alltimemark - posatt[i][j] >= 10&&readclass.read_int("data/plant_ill/"+mark.ToString()+"/pvz_mt.txt") == 1)//发射子弹
                        {
                            posatt[i][j] = alltimemark;double mindis = 2222;int mykey = 0;
                            foreach (var item in zombie)
                            {
                                if (zombieline[item.Key] != i) continue;
                                if (1025 - (28.75 * 0.001 * (get_nowtime() - item.Value)) - planty[j] + 5 <= 0) continue;
                                if (zombiebl[item.Key] <= 0) continue;                          //子弹hidden时间戳
                                double dis = 1025 - (28.75 * 0.001 * (get_nowtime() - item.Value)) - planty[j] + 5;
                                if(dis < mindis) { mindis = dis;mykey = item.Key; }
                            }
                            if (mykey == 0) continue;
                            system.shoop();
                            zombiebl[mykey] -= (int)(10 * Math.Pow(2, Math.Log10(readclass.read_att(pos[i][j])) / Math.Log10(5)));
                            bullet[++bulletnumber] = new Image();
                            bullet[bulletnumber].Source = new ImageSourceConverter().ConvertFromString("pic/bullet2/" +
                                mark + ".png") as ImageSource;
                            bullet[bulletnumber].Height = bullet_test.Height;
                            bullet[bulletnumber].Width = bullet_test.Width;
                            bullet[bulletnumber].VerticalAlignment = bullet_test.VerticalAlignment;
                            bullet[bulletnumber].HorizontalAlignment = bullet_test.HorizontalAlignment;
                            Thickness nowth = bullet_test.Margin;
                            nowth.Left = planty[j] + 33; nowth.Top = plantx[i] + 27;
                            bullet[bulletnumber].Margin = nowth;
                            mygrid.Children.Add(bullet[bulletnumber]);
                            system.picmove(0, 0, (int)((mindis / 328.75) * 300), 0, bullet[bulletnumber], mindis / 328.75);
                            //dis/257.5是碰撞的时间点，*200得到距离发射点的碰撞位置
                            bulletdietime[bulletnumber] = get_nowtime() + (int)(mindis / 328.75 * 1000);
                            zombiedietime[mykey] = Math.Max(get_nowtime() + (int)(mindis / 328.75 * 1000),zombiedietime[mykey]);
                        }
                        if (alltimemark - posatt[i][j] >= 40 && readclass.read_int("data/plant_ill/" + mark.ToString() + "/pvz_mt.txt") == 2)//阳光
                        {
                            if (plant_sun_mark == 0 || readclass.read_att(pos[i][j]) > readclass.read_att(plant_sun_mark))
                                plant_sun_mark = pos[i][j];
                            posatt[i][j] = alltimemark;
                            mksunpic[++mksunmark] = new Image();
                            mksunpic[mksunmark].Source = new ImageSourceConverter().ConvertFromString("pic/bullet2/" + mark.ToString() + ".png") as ImageSource;
                            mksunpic[mksunmark].VerticalAlignment = sun.VerticalAlignment;
                            mksunpic[mksunmark].HorizontalAlignment = sun.HorizontalAlignment;
                            mksunpic[mksunmark].Width = sun.Width;
                            mksunpic[mksunmark].Height = sun.Height;
                            Thickness p = sun.Margin; p.Left = planty[j] + 20;p.Top = plantx[i] + 20;
                            mksunpic[mksunmark].Margin = p;
                            MouseButtonEventHandler tes = new MouseButtonEventHandler(get_mk_sun);
                            mksunpic[mksunmark].MouseLeftButtonDown += tes;
                            mygrid.Children.Add(mksunpic[mksunmark]);
                            system.picmove(0, 0, 10, 10, mksunpic[mksunmark], 1);
                        }
                    }
               
            }
        }
        public int solve_sun()
        {
            if (plant_sun_mark == 0) return 0;
            int att = readclass.read_att(plant_sun_mark);
            return (int)(25.0 / Math.Pow(1.13,MainWindow.mypvz_select.diff) * Math.Pow(2, Math.Log2(att) / Math.Log2(10)));
        }
        private void get_mk_sun(object sender , MouseButtonEventArgs e)
        {
            Image p = (Image)sender;system.getsun();
            Point point = p.TranslatePoint(new Point(0, 0), mygrid);
            MouseButtonEventHandler p2 = new MouseButtonEventHandler(get_mk_sun);
            p.MouseLeftButtonDown -= p2;
            system.picmove(0, 0, 20 - (int)point.X, 3 - (int)point.Y,p, 0.3);
            system.App.Delay(300);moneyshow.Text = (int.Parse(moneyshow.Text) + solve_sun()).ToString();p.Visibility = Visibility.Hidden;
            mygrid.Children.Remove(p);
        }
        public void posallsolve(Image img,int x,int y)
        {
            if (flag_select == 0) return;
            if (flag_select == 99999)
            {
                pos[x][y] = 0;setgif(img, 99999);system.putback();
                chan_black.Visibility = Visibility.Hidden; flag_select = 0;
                return;
            }
            if (pos[x][y] != 0) return;system.putplant();
            if (int.Parse(moneyshow.Text) < needmoney) return;
            moneyshow.Text = (int.Parse(moneyshow.Text) - needmoney).ToString();
            pos[x][y] = flag_select;posatt[x][y] = alltimemark;
            setgif(img, MainWindow.mymain_interface.plantware[flag_select].mark);
            moveblack(); flag_select = 0;
        }
        private void pos11pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos11pic,1,1);
        }
        private void pos12pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos12pic, 1, 2);
        }
        private void pos13pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos13pic, 1, 3);
        }
        private void pos14pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos14pic, 1, 4);
        }
        private void pos15pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos15pic, 1, 5);
        }
        private void pos16pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos16pic, 1, 6);
        }
        private void pos17pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos17pic, 1, 7);
        }
        private void pos18pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos18pic, 1, 8);
        }
        private void pos19pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos19pic, 1, 9);
        }
        private void pos21pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos21pic, 2, 1);
        }
        private void pos22pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos22pic, 2, 2);
        }
        private void pos23pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos23pic, 2, 3);
        }
        private void pos24pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos24pic, 2, 4);
        }
        private void pos25pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos25pic, 2, 5);
        }
        private void pos26pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos26pic, 2, 6);
        }
        private void pos27pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos27pic, 2, 7);
        }
        private void pos28pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos28pic, 2, 8);
        }
        private void pos29pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos29pic, 2, 9);
        }
        private void pos31pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos31pic, 3, 1);
        }
        private void pos32pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos32pic, 3, 2);
        }
        private void pos33pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos33pic, 3, 3);
        }
        private void pos34pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos34pic, 3, 4);
        }
        private void pos35pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos35pic, 3, 5);
        }
        private void pos36pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos36pic, 3, 6);
        }
        private void pos37pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos37pic, 3, 7);
        }

        private void chan_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            blackhidden(); chan_black.Visibility = Visibility.Visible;
            flag_select = 99999;system.shovel();
        }

        private void menureturn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menureturn.Source = new ImageSourceConverter().ConvertFromString("pic/主菜单1按.png") as ImageSource;
            system.gomain();
        }

        private void menureturn_MouseLeave(object sender, MouseEventArgs e)
        {
             menureturn.Source = new ImageSourceConverter().ConvertFromString("pic/主菜单1.png") as ImageSource;
        }

        private void menureturn_MouseEnter(object sender, MouseEventArgs e)
        {
            menureturn.Source = new ImageSourceConverter().ConvertFromString("pic/主菜单1亮.png") as ImageSource;
        }

        private void menureturn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            menureturn.Source = new ImageSourceConverter().ConvertFromString("pic/主菜单1亮.png") as ImageSource;
            flag = false;MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden; clear_allbullet();
            clear_allsun(); clear_allzombie();menu.Visibility = Visibility.Hidden; MainWindow.mymain_interface.pvzmusic.Stop();
            menureturn.Visibility = Visibility.Hidden;backgamepic.Visibility = Visibility.Hidden;
        }

        private void gomenupic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menu.Visibility = Visibility.Visible;menureturn.Visibility = Visibility.Visible; backgamepic.Visibility = Visibility.Visible;
            gomenupic.Source = new ImageSourceConverter().ConvertFromString("pic/菜单4按.png") as ImageSource;system.pause();
        }

        private void backgamepic_MouseEnter(object sender, MouseEventArgs e)
        {
            backgamepic.Source = new ImageSourceConverter().ConvertFromString("pic/返回游戏亮.png") as ImageSource;
        }

        private void backgamepic_MouseLeave(object sender, MouseEventArgs e)
        {
            backgamepic.Source = new ImageSourceConverter().ConvertFromString("pic/返回游戏.png") as ImageSource;
        }

        private void backgamepic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            backgamepic.Source = new ImageSourceConverter().ConvertFromString("pic/返回游戏按.png") as ImageSource;
            system.back_game();
        }

        private void backgamepic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            backgamepic.Source = new ImageSourceConverter().ConvertFromString("pic/返回游戏亮.png") as ImageSource;
            menu.Visibility = Visibility.Hidden;
            menureturn.Visibility = Visibility.Hidden; backgamepic.Visibility = Visibility.Hidden;
        }

        private void gomenupic_MouseEnter(object sender, MouseEventArgs e)
        {
            gomenupic.Source = new ImageSourceConverter().ConvertFromString("pic/菜单4亮.png") as ImageSource;
        }

        private void gomenupic_MouseLeave(object sender, MouseEventArgs e)
        {
            gomenupic.Source = new ImageSourceConverter().ConvertFromString("pic/菜单4.png") as ImageSource;
        }

        private void gomenupic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            gomenupic.Source = new ImageSourceConverter().ConvertFromString("pic/菜单4亮.png") as ImageSource;
        }

        private void chan_black_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            blackhidden();flag_select = 0; system.putback();
        }

        private void sun_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
         //   Point point = e.GetPosition(mygrid);
            Image testpic = new Image(); testpic = sun; system.getsun();
            Point point = testpic.TranslatePoint(new Point(0, 0), mygrid);
            MouseButtonEventHandler p = new MouseButtonEventHandler(sun_MouseLeftButtonDown);
            sun.MouseLeftButtonDown -= p;
            system.picmove((int)point.X, (int)point.Y, 0,0, testpic,0.3);
            system.App.Delay(300);testpic.Visibility = Visibility.Hidden;
            moneyshow.Text = (int.Parse(moneyshow.Text)+25).ToString();
            sun.MouseLeftButtonDown += p;
        }

        private void pos38pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos38pic, 3, 8);
        }
        private void pos39pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos39pic, 3, 9);
        }
        private void pos41pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos41pic, 4, 1);
        }
        private void pos42pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos42pic, 4, 2);
        }
        private void pos43pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos43pic, 4, 3);
        }
        private void pos44pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos44pic, 4, 4);
        }
        private void pos45pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos45pic, 4, 5);
        }
        private void pos46pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos46pic, 4, 6);
        }
        private void pos47pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos47pic, 4, 7);
        }
        private void pos48pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos48pic, 4, 8);
        }
        private void pos49pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos49pic, 4, 9);
        }
        private void pos51pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos51pic, 5, 1);
        }
        private void pos52pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos52pic, 5, 2);
        }
        private void pos53pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos53pic, 5, 3);
        }
        private void pos54pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos54pic, 5, 4);
        }
        private void pos55pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos55pic, 5, 5);
        }
        private void pos56pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos56pic, 5, 6);
        }
        private void pos57pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos57pic, 5, 7);
        }
        private void pos58pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos58pic, 5, 8);
        }
        private void pos59pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posallsolve(pos59pic, 5, 9);
        }
        private void select1_black_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            blackhidden(); flag_select = 0;system.putback();
        }
    }
}
