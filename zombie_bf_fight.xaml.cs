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
    public partial class zombie_bf_fight : Page
    {
        public zombie_bf_fight()
        {
            InitializeComponent();
            updatemess();
        }

        private int nowpage = 1;public int gamemode = 0;
        public int select1 = 0, select2 = 0, select3 = 0, select4 = 0, select5 = 0,zombie = 0;
        private void close_Mouseclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
        }
        public int find_mark_plant(int findnumber)
        {
            if (findnumber > MainWindow.mymain_interface.allnumber) return 0;
            else return findnumber;
        }
        private void emptypage()
        {
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos14pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos15pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos24pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos25pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            
            pos11lvshow.Text = ""; pos12lvshow.Text = ""; pos13lvshow.Text = ""; pos14lvshow.Text = "";
            pos15lvshow.Text = ""; pos21lvshow.Text = ""; pos22lvshow.Text = "";
            pos23lvshow.Text = ""; pos24lvshow.Text = ""; pos25lvshow.Text = "";
            pos11back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos12back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos13back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos14back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos15back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos24back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos21back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos22back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos23back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
            pos25back.Source = new ImageSourceConverter().ConvertFromString("pic/back/劣质.png") as ImageSource;
        }
        private void emptyup()
        {
            select1pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            select2pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            select3pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            select4pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            select5pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            select1 = 0;select2 = 0; select3 = 0; select4 = 0; select5 = 0;
            select1lv.Text = ""; select2lv.Text = ""; select3lv.Text = ""; select4lv.Text = ""; select5lv.Text = "";
        }
        private int get_nextpos()
        {
            int now = 0;
            if (select1 == 0) now = 1;
            else if (select2 == 0) now = 2;
            else if (select3 == 0) now = 3;
            else if (select4 == 0) now = 4;
            else if (select5 == 0) now = 5;
            return now;
        }
        public void updateup()
        {
            if(select1 != 0)
            {
                string mark = MainWindow.mymain_interface.plantware[select1].mark.ToString();
                select1pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select1lv.Text = "LV." + MainWindow.mymain_interface.plantware[select1].lv;                   
            }
            if (select2 != 0)
            {
                string mark = MainWindow.mymain_interface.plantware[select2].mark.ToString();
                select2pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select2lv.Text = "LV." + MainWindow.mymain_interface.plantware[select2].lv;
            }
            if (select3 != 0)
            {
                string mark = MainWindow.mymain_interface.plantware[select3].mark.ToString();
                select3pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select3lv.Text = "LV." + MainWindow.mymain_interface.plantware[select3].lv;
            }
            if (select4 != 0)
            {
                string mark = MainWindow.mymain_interface.plantware[select4].mark.ToString();
                select4pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select4lv.Text = "LV." + MainWindow.mymain_interface.plantware[select4].lv;
            }
            if (select5 != 0)
            {
                string mark = MainWindow.mymain_interface.plantware[select5].mark.ToString();
                select5pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select5lv.Text = "LV." + MainWindow.mymain_interface.plantware[select5].lv;
            }
        }
        private void goup(int pos)
        {
            //string road = "data/warehouse_plant/" + pos.ToString() + "/";
            string mark = MainWindow.mymain_interface.plantware[pos].mark.ToString();
            string road2 = "data/plant_ill/" + mark + "/";
            int selectpos = get_nextpos();
            if (selectpos == 0||select1 == pos||select2 == pos||select3 == pos||select4 == pos||select5 == pos) return;
            if (selectpos == 1)
            {
                select1 = pos;
                select1pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select1lv.Text = "LV." + MainWindow.mymain_interface.plantware[pos].lv.ToString();
            }
            if (selectpos == 2)
            {
                select2 = pos;
                select2pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select2lv.Text = "LV." + MainWindow.mymain_interface.plantware[pos].lv.ToString();
            }
            if (selectpos == 3)
            {
                select3 = pos;
                select3pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select3lv.Text = "LV." + MainWindow.mymain_interface.plantware[pos].lv.ToString();
            }
            if (selectpos == 4)
            {
                select4 = pos;
                select4pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select4lv.Text = "LV." + MainWindow.mymain_interface.plantware[pos].lv.ToString();
            }
            if (selectpos == 5)
            {
                select5 = pos;
                select5pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark + ".png") as ImageSource;
                select5lv.Text = "LV." + MainWindow.mymain_interface.plantware[pos].lv.ToString();
            }
        }
        public void updatemess()
        {
            emptypage();
            if (gamemode == 3)
            {
                frame3.Visibility = Visibility.Visible; frame3.Navigate(MainWindow.mypvz_select);
            }
            else frame3.Visibility = Visibility.Hidden;
            if (zombie != 0)
                zombiepic.Source = new ImageSourceConverter().ConvertFromString("pic/zombie/" +
                    zombie.ToString() + ".png") as ImageSource;
            int nowpos = (nowpage - 1) * 10 + 1; int realtime; string realmark;
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

        }
        private void pos11click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int nowpos = (nowpage - 1) * 10 + 1;
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos12click(object sender, MouseButtonEventArgs e)
        {
            system.dong(); int nowpos = (nowpage - 1) * 10 + 2;
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos13click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 3; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos14click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 4; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos15click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 5; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos21click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 6; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos22click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 7; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos23click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 8; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos24click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 9; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
        }
        private void pos25click(object sender, MouseButtonEventArgs e)
        {
            int nowpos = (nowpage - 1) * 10 + 10; system.dong();
            int realtime = find_mark_plant(nowpos);
            if (realtime == 0) return;
            goup(realtime);
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
            if (nowpage == 1) return;nowpage--;updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void goleft_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.dong(); goleft.Source = new ImageSourceConverter().ConvertFromString("pic/left亮.jpg") as ImageSource;
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
            nowpage++;updatemess();pageshow.Text = nowpage.ToString();
        }

        private void goright_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            goright.Source = new ImageSourceConverter().ConvertFromString("pic/right亮.jpg") as ImageSource;
        }

        private void fightstartpic_MouseEnter(object sender, MouseEventArgs e)
        {
            fightstartpic.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始亮.jpg") as ImageSource;
        }

        private void fightstartpic_MouseLeave(object sender, MouseEventArgs e)
        {
            fightstartpic.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始.jpg") as ImageSource;
        }

        private void fightstartpic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
             fightstartpic.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始按.jpg") as ImageSource;
        }

        private void fightstartpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.lingdang(); fightstartpic.Source = new ImageSourceConverter().ConvertFromString("pic/战斗开始亮.jpg") as ImageSource;
            if(gamemode == 1)
            {
                MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_fight2);
                MainWindow.myzombie_fight2.selectzombie = 1;
                MainWindow.myzombie_fight2.start_bl(); 
                MainWindow.myzombie_fight2.start_interface();
                MainWindow.myzombie_fight2.fight();
                gamemode = 0;return;
            }
            if (gamemode == 2)
            {
                MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_fight3);
                MainWindow.myzombie_fight3.start_bl();
                MainWindow.myzombie_fight3.start_interface();
                MainWindow.myzombie_fight3.fight();
                gamemode = 0; return;
            }
            if(gamemode == 3)
            {
                MainWindow.mymain_interface.frame2.Navigate(MainWindow.mypvz1);
                MainWindow.mypvz1.start_interface();
                MainWindow.mypvz1.fight();
                gamemode = 0;return;
            }
            MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_fight);
            MainWindow.myzombie_fight.selectzombie = zombie;
            MainWindow.myzombie_fight.start_bl(); MainWindow.myzombie_fight.jumpfight.Visibility = Visibility.Visible;
            MainWindow.myzombie_fight.start_interface();
            MainWindow.myzombie_fight.fight();
        }

        private void select1pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            select1 = 0; system.dong();
            select1pic.Source = new ImageSourceConverter().ConvertFromString("pic/9781tou.png") as ImageSource;
            select1lv.Text = "";
        }

        private void select2pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            select2 = 0; system.dong();
            select2pic.Source = new ImageSourceConverter().ConvertFromString("pic/9781tou.png") as ImageSource;
            select2lv.Text = "";
        }
        private void select3pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            select3 = 0; system.dong();
            select3pic.Source = new ImageSourceConverter().ConvertFromString("pic/9781tou.png") as ImageSource;
            select3lv.Text = "";
        }
        private void select4pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            select4 = 0; system.dong();
            select4pic.Source = new ImageSourceConverter().ConvertFromString("pic/9781tou.png") as ImageSource;
            select4lv.Text = "";
        }
        private void select5pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            select5 = 0; system.dong();
            select5pic.Source = new ImageSourceConverter().ConvertFromString("pic/9781tou.png") as ImageSource;
            select5lv.Text = "";
        }

        private void zombiepic_MouseEnter(object sender, MouseEventArgs e)
        {
            zombie1frame.Visibility = Visibility.Visible;
            if(gamemode == 2)
            {
                zombie1frame.Navigate(MainWindow.myzombieattr);return;
            }
            zombieattr a = new zombieattr();a.zombie = zombie;a.updatemess();
            zombie1frame.Navigate(a);
        }

        private void zombiepic_MouseLeave(object sender, MouseEventArgs e)
        {
            zombie1frame.Visibility = Visibility.Hidden;
        }

        private void quitpic_MouseEnter(object sender, MouseEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消2亮.jpg") as ImageSource;
        }

        private void quitpic_MouseLeave(object sender, MouseEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消2.jpg") as ImageSource;
        }

        private void quitpic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消2按.jpg") as ImageSource;
            
        }

        private void quitpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.dong(); quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消2亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden; gamemode = 0;
        }
        private void allhidden()
        {
            plant11frame.Visibility = Visibility.Hidden; plant12frame.Visibility = Visibility.Hidden;
            plant13frame.Visibility = Visibility.Hidden; plant14frame.Visibility = Visibility.Hidden;
            plant15frame.Visibility = Visibility.Hidden; plant21frame.Visibility = Visibility.Hidden;
            plant22frame.Visibility = Visibility.Hidden; plant23frame.Visibility = Visibility.Hidden;
            plant24frame.Visibility = Visibility.Hidden; plant25frame.Visibility = Visibility.Hidden;
        }
        private void pos11detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 1) == 0) return;
            plant11frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr();a.pos = find_mark_plant((nowpage - 1) * 10 + 1);a.updatemess();
            plant11frame.Navigate(a);
        }
        private void pos11detailhid(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void pos12detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 2) == 0) return;
            plant12frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 2); a.updatemess();
            plant12frame.Navigate(a);
        }
        private void pos13detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 3)== 0) return;
            plant13frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 3); a.updatemess();
            plant13frame.Navigate(a);
        }
     
        private void pos14detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 4) == 0) return;
            plant14frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 4); a.updatemess();
            plant14frame.Navigate(a);
        }
       
        private void pos15detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 5) == 0) return;
            plant15frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 5); a.updatemess();
            plant15frame.Navigate(a);
        }
      
        private void pos21detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 6) == 0) return;
            plant21frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 6); a.updatemess();
            plant21frame.Navigate(a);
        }
       
        private void pos22detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 7) == 0) return;
            plant22frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 7); a.updatemess();
            plant22frame.Navigate(a);
        }
      
        private void pos23detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 8) == 0) return;
            plant23frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 8); a.updatemess();
            plant23frame.Navigate(a);
        }
       
        private void pos24detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 9) == 0) return;
            plant24frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 9); a.updatemess();
            plant24frame.Navigate(a);
        }
        private void pos25detailshow(object sender, MouseEventArgs e)
        {
            if (find_mark_plant((nowpage - 1) * 10 + 10) == 0) return;
            plant25frame.Visibility = Visibility.Visible;
            plantattr a = new plantattr(); a.pos = find_mark_plant((nowpage - 1) * 10 + 10); a.updatemess();
            plant25frame.Navigate(a);
        }

    }
}
