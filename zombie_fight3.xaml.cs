using System;
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
    public partial class zombie_fight3 : Page
    {
        public zombie_fight3()
        {
            InitializeComponent();
            lessbl_text_hideen();
        }
        public int plant1bl = 0, plant2bl = 0, plant3bl = 0, plant4bl = 0, plant5bl = 0, zombie = 0;
        public int zombie3bl = 0,jump = 0;
        public int zombieatt, zombiethr, zombiearm, selectzombie = 0;
        int pos1 = MainWindow.myzombie_bf_fight.select1;
        int pos2 = MainWindow.myzombie_bf_fight.select2;
        int pos3 = MainWindow.myzombie_bf_fight.select3;
        int pos4 = MainWindow.myzombie_bf_fight.select4;
        int pos5 = MainWindow.myzombie_bf_fight.select5;
        int mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0, mark5 = 0;

        private void jumpfight_MouseEnter(object sender, MouseEventArgs e)
        {
            jumpfight.Source = new ImageSourceConverter().ConvertFromString("pic/跳过战斗亮.jpg") as ImageSource;
        }

        private void jumpfight_MouseLeave(object sender, MouseEventArgs e)
        {
            jumpfight.Source = new ImageSourceConverter().ConvertFromString("pic/跳过战斗.jpg") as ImageSource;
        }

        private void plantpic1_MediaEnded(object sender, RoutedEventArgs e)
        {
            (sender as MediaElement).Stop();
            (sender as MediaElement).Play();
        }

        private void jumpfight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            jumpfight.Source = new ImageSourceConverter().ConvertFromString("pic/跳过战斗按.jpg") as ImageSource;
        }

        private void jumpfight_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            jumpfight.Source = new ImageSourceConverter().ConvertFromString("pic/跳过战斗亮.jpg") as ImageSource;
            jump = 1;jumpfight.Visibility = Visibility.Hidden;
        }

        private bool plant_all_die()
        {
            if (plant1bl > 0) return false; if (plant2bl > 0) return false; if (plant3bl > 0) return false;
            if (plant4bl > 0) return false; if (plant5bl > 0) return false;return true;
        }
        private bool zombie_all_die()
        {
            if (zombie3bl > 0) return false;  return true;
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
            jump = 0;jumpfight.Visibility = Visibility.Hidden;
            if(zombie_all_die())
            {
                if(MainWindow.mytask.picmark == 1) readclass.write_int("data/task/final_fight/finished.txt", 1);
                else if(MainWindow.mytask.picmark == 2)  readclass.write_int("data/task/guijiao/finished.txt", readclass.read_int("data/task/guijiao/finished.txt") +1);
                MainWindow.mytask.judge();
                frame1.Visibility = Visibility.Visible; system.jiangli(); MainWindow.myget_prop.zombie = MainWindow.myzombieattr.zombie;
                frame1.Navigate(MainWindow.myget_prop); MainWindow.myget_prop.start_interface();
            }
            else
            {
                system.App.Delay(2000);system.jiangshi();
                MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
            }
        }
        private void plant_attack_detail(int num,int att,int thr)
        {
            double bei = (double)thr / (double)zombiearm; 
            if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
            int lessbl = (int)((double)att * bei);
            if (zombie_all_die()) return;
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
            picmove(getpos(93, upplant, zombielif), 0, getpos(93, zombie3bl, zombielif), 0, zombie3xuetiao);
            if (jump == 0) system.App.Delay(1000);
            zombie3lessblshow.Text = "";
            start_interface(); 
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
        private void zombie_attack_detail(int num)
        {
            if (plant1bl > 0)
            {
                double bei = (double)zombiethr/ (double)readclass.read_arm(pos1);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)zombieatt * bei);
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
                double bei = (double)zombiethr / (double)readclass.read_arm(pos2);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)zombieatt * bei);
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
                double bei = (double)zombiethr / (double)readclass.read_arm(pos3);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)zombieatt * bei);
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
                double bei = (double)zombiethr / (double)readclass.read_arm(pos4);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)zombieatt * bei);
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
                double bei = (double)zombiethr / (double)readclass.read_arm(pos5);
                if (bei > 1.8) bei = 1.8; if (bei < 0.6) bei = 0.6;
                int lessbl = (int)((double)zombieatt * bei);
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
            if (zombie3bl > 0)
            {
                zombie_attack_detail(3);
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

            if (zombie3bl <= 0) zombiepic3.Source = new ImageSourceConverter().ConvertFromString("pic/119141tou.png") as ImageSource;
            else zombiepic3.Source = new ImageSourceConverter().ConvertFromString("pic/zombie3/" + MainWindow.mytask.picmark.ToString()+ ".png") as ImageSource;
            
        }
        public void lessbl_text_hideen()
        {
            plant1lessblshow.Text = ""; plant2lessblshow.Text = ""; plant3lessblshow.Text = ""; plant4lessblshow.Text = "";
            plant5lessblshow.Text = ""; zombie3lessblshow.Text = "";
        }
        public void start_bl()
        {
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
            zombie3bl = zombielif = MainWindow.mytask.lif;
            zombieatt = MainWindow.mytask.att;
            zombiearm = MainWindow.mytask.arm;
            zombiethr = MainWindow.mytask.thr;
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


            picmove(0, 0, 0, 0, zombie3xuetiao); 
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
