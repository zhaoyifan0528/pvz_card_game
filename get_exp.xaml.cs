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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class get_exp: Page
    {
        private int pos1, pos2, pos3, pos4, pos5,number = 0;string road, road2;
        private int mark1, mark2, mark3, mark4, mark5,exp,exp1,exp2,exp3,exp4,exp5;

        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.lingdang();delay = 1;
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
            MainWindow.myzombie_fight.frame1.Navigate(MainWindow.myget_prop); MainWindow.myget_prop.zombie = zombie;
            MainWindow.myget_prop.start_interface();
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2按.jpg") as ImageSource;
        }

        private void sure_MouseLeave(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2.jpg") as ImageSource;
        }

        private void sure_MouseEnter(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
        }

        public get_exp()
        {
            InitializeComponent();
        }
        private void cinnowpos(int cinpos)
        {
            if (pos1 == 0) pos1 = cinpos;
            else if (pos2 == 0) pos2 = cinpos;
            else if (pos3 == 0) pos3 = cinpos;
            else if (pos4 == 0) pos4 = cinpos;
            else pos5 = cinpos;
        }
        private void allhidden()
        {
            plant1pic.Visibility = Visibility.Hidden;plant1jingtiao.Visibility = Visibility.Hidden;
            plant1lvshow.Text = "";plant1nameshow.Text = "";di1.Visibility = Visibility.Hidden;
            kuang1.Visibility = Visibility.Hidden;
            plant2pic.Visibility = Visibility.Hidden; plant2jingtiao.Visibility = Visibility.Hidden;
            plant2lvshow.Text = ""; plant2nameshow.Text = ""; di2.Visibility = Visibility.Hidden;
            kuang2.Visibility = Visibility.Hidden;
            plant3pic.Visibility = Visibility.Hidden; plant3jingtiao.Visibility = Visibility.Hidden;
            plant3lvshow.Text = ""; plant3nameshow.Text = ""; di3.Visibility = Visibility.Hidden;
            kuang3.Visibility = Visibility.Hidden;
            plant4pic.Visibility = Visibility.Hidden; plant4jingtiao.Visibility = Visibility.Hidden;
            plant4lvshow.Text = ""; plant4nameshow.Text = ""; di4.Visibility = Visibility.Hidden;
            kuang4.Visibility = Visibility.Hidden;
            plant5pic.Visibility = Visibility.Hidden; plant5jingtiao.Visibility = Visibility.Hidden;
            plant5lvshow.Text = ""; plant5nameshow.Text = ""; di5.Visibility = Visibility.Hidden;
            kuang5.Visibility = Visibility.Hidden;
        }
        private int calculate(int alllen,int nowexp,int allexp)
        {
            if (nowexp > allexp) nowexp = allexp;
            return (int)((double)alllen* ((double)nowexp / (double)allexp));
        }
        private bool allthingshow()
        {
            bool flag = false;
            if (pos1 != 0)
            {
                plant1pic.Visibility = Visibility.Visible; plant1jingtiao.Visibility = Visibility.Visible;
                di1.Visibility = Visibility.Visible; kuang1.Visibility = Visibility.Visible;
                plant1pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark1.ToString() + ".png") as ImageSource;
                plant1nameshow.Text = readclass.read_string("data/plant_ill/" + mark1.ToString() + "/name.txt");
                int lv = MainWindow.mymain_interface.plantware[pos1].lv;
                int nowexp = MainWindow.mymain_interface.plantware[pos1].exp;
                plant1lvshow.Text = "LV."+lv.ToString(); //所以每次访问最多升一级
                int addexo = nowexp + exp;              //每一次访问都保证没有升级就退出
                picmove(calculate(100, nowexp, readclass.needexp[lv]), 0, 
                    calculate(100,exp1, readclass.needexp[lv]),0,plant1jingtiao);
                if(exp1 >= readclass.needexp[lv])
                {
                    flag = true; exp1 -= readclass.needexp[lv];
                    MainWindow.mymain_interface.plantware[pos1].exp = 0;
                    MainWindow.mymain_interface.plantware[pos1].lv = lv + 1;
                }
                else MainWindow.mymain_interface.plantware[pos1].exp = exp1;
            }
            if (pos2 != 0)
            {
                plant2pic.Visibility = Visibility.Visible; plant2jingtiao.Visibility = Visibility.Visible;
                di2.Visibility = Visibility.Visible; kuang2.Visibility = Visibility.Visible;
                plant2pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark2.ToString() + ".png") as ImageSource;
                plant2nameshow.Text = readclass.read_string("data/plant_ill/" + mark2.ToString() + "/name.txt");
                int lv = MainWindow.mymain_interface.plantware[pos2].lv;
                int nowexp = MainWindow.mymain_interface.plantware[pos2].exp;
                plant2lvshow.Text = "LV." + lv.ToString(); //所以每次访问最多升一级
                int addexo = nowexp + exp;              //每一次访问都保证没有升级就退出
                picmove(calculate(100, nowexp, readclass.needexp[lv]), 0,
                    calculate(100, exp2, readclass.needexp[lv]), 0, plant2jingtiao);
                if (exp2 >= readclass.needexp[lv])
                {
                    flag = true; exp2 -= readclass.needexp[lv];
                    MainWindow.mymain_interface.plantware[pos2].exp = 0;
                    MainWindow.mymain_interface.plantware[pos2].lv = lv + 1;
                }
                else MainWindow.mymain_interface.plantware[pos2].exp = exp2;
            }
            if (pos3 != 0)
            {
                plant3pic.Visibility = Visibility.Visible; plant3jingtiao.Visibility = Visibility.Visible;
                di3.Visibility = Visibility.Visible; kuang3.Visibility = Visibility.Visible;
                plant3pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark3.ToString() + ".png") as ImageSource;
                plant3nameshow.Text = readclass.read_string("data/plant_ill/" + mark3.ToString() + "/name.txt");
                int lv = MainWindow.mymain_interface.plantware[pos3].lv;
                int nowexp = MainWindow.mymain_interface.plantware[pos3].exp;
                plant3lvshow.Text = "LV." + lv.ToString(); //所以每次访问最多升一级
                int addexo = nowexp + exp;              //每一次访问都保证没有升级就退出
                picmove(calculate(100, nowexp, readclass.needexp[lv]), 0,
                    calculate(100, exp3, readclass.needexp[lv]), 0, plant3jingtiao);
                if (exp3 >= readclass.needexp[lv])
                {
                    flag = true; exp3 -= readclass.needexp[lv];
                    MainWindow.mymain_interface.plantware[pos3].exp = 0;
                    MainWindow.mymain_interface.plantware[pos3].lv = lv + 1;
                }
                else MainWindow.mymain_interface.plantware[pos3].exp = exp3;
            }
            if (pos4 != 0)
            {
                plant4pic.Visibility = Visibility.Visible; plant4jingtiao.Visibility = Visibility.Visible;
                di4.Visibility = Visibility.Visible; kuang4.Visibility = Visibility.Visible;
                plant4pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark4.ToString() + ".png") as ImageSource;
                plant4nameshow.Text = readclass.read_string("data/plant_ill/" + mark4.ToString() + "/name.txt");
                int lv = MainWindow.mymain_interface.plantware[pos4].lv;
                int nowexp = MainWindow.mymain_interface.plantware[pos4].exp;
                plant4lvshow.Text = "LV." + lv.ToString(); //所以每次访问最多升一级
                int addexo = nowexp + exp;              //每一次访问都保证没有升级就退出
                picmove(calculate(100, nowexp, readclass.needexp[lv]), 0,
                    calculate(100, exp4, readclass.needexp[lv]), 0, plant4jingtiao);
                if (exp4 >= readclass.needexp[lv])
                {
                    flag = true; exp4 -= readclass.needexp[lv];
                    MainWindow.mymain_interface.plantware[pos4].exp = 0;
                    MainWindow.mymain_interface.plantware[pos4].lv = lv + 1;
                }
                else MainWindow.mymain_interface.plantware[pos4].exp = exp4;
            }
            if (pos5 != 0)
            {
                plant5pic.Visibility = Visibility.Visible; plant5jingtiao.Visibility = Visibility.Visible;
                di5.Visibility = Visibility.Visible; kuang5.Visibility = Visibility.Visible;
                plant5pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark5.ToString() + ".png") as ImageSource;
                plant5nameshow.Text = readclass.read_string("data/plant_ill/" + mark5.ToString() + "/name.txt");
                int lv = MainWindow.mymain_interface.plantware[pos5].lv;
                int nowexp = MainWindow.mymain_interface.plantware[pos5].exp;
                plant5lvshow.Text = "LV." + lv.ToString(); //所以每次访问最多升一级
                int addexo = nowexp + exp;              //每一次访问都保证没有升级就退出
                picmove(calculate(100, nowexp, readclass.needexp[lv]), 0,
                    calculate(100, exp5, readclass.needexp[lv]), 0, plant5jingtiao);
                if (exp5 >= readclass.needexp[lv])
                {
                    flag = true; exp5 -= readclass.needexp[lv];
                    MainWindow.mymain_interface.plantware[pos5].exp = 0;
                    MainWindow.mymain_interface.plantware[pos5].lv = lv + 1;
                }
                else MainWindow.mymain_interface.plantware[pos5].exp = exp5;
            }
            return flag;
        }
        public int zombie = 0,delay;
        public void updatepos()
        {
            number = 0;pos1 = 0;pos2 = 0;pos3 = 0;pos4 = 0;pos5 = 0;mark1 = 0;mark2 = 0;mark3 = 0;mark4 = 0;mark5 = 0;
            delay = 0;
            if (MainWindow.myzombie_fight.plant1bl > 0) cinnowpos(MainWindow.myzombie_bf_fight.select1);
            if (MainWindow.myzombie_fight.plant2bl > 0) cinnowpos(MainWindow.myzombie_bf_fight.select2);
            if (MainWindow.myzombie_fight.plant3bl > 0) cinnowpos(MainWindow.myzombie_bf_fight.select3);
            if (MainWindow.myzombie_fight.plant4bl > 0) cinnowpos(MainWindow.myzombie_bf_fight.select4);
            if (MainWindow.myzombie_fight.plant5bl > 0) cinnowpos(MainWindow.myzombie_bf_fight.select5);
            exp = readclass.read_int("data/zombie/" + zombie + "/exp.txt") / readallnumber();
            exp++;
            if (pos1 != 0) mark1 = MainWindow.mymain_interface.plantware[pos1].mark;
            if (pos2 != 0) mark2 = MainWindow.mymain_interface.plantware[pos2].mark;
            if (pos3 != 0) mark3 = MainWindow.mymain_interface.plantware[pos3].mark;
            if (pos4 != 0) mark4 = MainWindow.mymain_interface.plantware[pos4].mark;
            if (pos5 != 0) mark5 = MainWindow.mymain_interface.plantware[pos5].mark;
            if (pos1 != 0) exp1 = exp + MainWindow.mymain_interface.plantware[pos1].exp;
            if (pos2 != 0) exp2 = exp + MainWindow.mymain_interface.plantware[pos2].exp;
            if (pos3 != 0) exp3 = exp + MainWindow.mymain_interface.plantware[pos3].exp;
            if (pos4 != 0) exp4 = exp + MainWindow.mymain_interface.plantware[pos4].exp;
            if (pos5 != 0) exp5 = exp + MainWindow.mymain_interface.plantware[pos5].exp;
            allhidden();
            while (allthingshow()) if(delay == 0) system.App.Delay(1000);
            if(pos1 != 0)
            {
                sql.sqlsolve("UPDATE PLANT SET PLANT_EXP = " + MainWindow.mymain_interface.plantware[pos1].exp.ToString() + ",PLANT_LV = " +
                    MainWindow.mymain_interface.plantware[pos1].lv.ToString() + " WHERE PLANT_POS = " +
                    MainWindow.mymain_interface.plantware[pos1].plant_pos.ToString());
            }
            if (pos2 != 0)
            {
                sql.sqlsolve("UPDATE PLANT SET PLANT_EXP = " + MainWindow.mymain_interface.plantware[pos2].exp.ToString() + ",PLANT_LV = " +
                    MainWindow.mymain_interface.plantware[pos2].lv.ToString() + " WHERE PLANT_POS = " +
                    MainWindow.mymain_interface.plantware[pos2].plant_pos.ToString());
            }
            if (pos3 != 0)
            {
                sql.sqlsolve("UPDATE PLANT SET PLANT_EXP = " + MainWindow.mymain_interface.plantware[pos3].exp.ToString() + ",PLANT_LV = " +
                    MainWindow.mymain_interface.plantware[pos3].lv.ToString() + " WHERE PLANT_POS = " +
                    MainWindow.mymain_interface.plantware[pos3].plant_pos.ToString());
            }
            if (pos4 != 0)
            {
                sql.sqlsolve("UPDATE PLANT SET PLANT_EXP = " + MainWindow.mymain_interface.plantware[pos4].exp.ToString() + ",PLANT_LV = " +
                    MainWindow.mymain_interface.plantware[pos4].lv.ToString() + " WHERE PLANT_POS = " +
                    MainWindow.mymain_interface.plantware[pos4].plant_pos.ToString());
            }
            if (pos5 != 0)
            {
                sql.sqlsolve("UPDATE PLANT SET PLANT_EXP = " + MainWindow.mymain_interface.plantware[pos5].exp.ToString() + ",PLANT_LV = " +
                    MainWindow.mymain_interface.plantware[pos5].lv.ToString() + " WHERE PLANT_POS = " +
                    MainWindow.mymain_interface.plantware[pos5].plant_pos.ToString());
            }
        }
        public int readallnumber()
        {
            if (pos1 == 0) return 0;if (pos2 == 0) return 1;
            if (pos3 == 0) return 2;if (pos4 == 0) return 3;
            if (pos5 == 0) return 4;return 5;
        }
        private void picmove(int stxpos, int stypos, int movex, int movey, Image img)
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
    }
}
