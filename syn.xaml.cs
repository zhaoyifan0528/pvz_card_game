using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
    public partial class syn : Page
    {
        public syn()
        {
            InitializeComponent();updatemess();
        }
        private int nowpage = 1;
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
        }
        private void gotosyn2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn2);
            MainWindow.mysyn2.updatemess();
        }
        private void gotosyn3(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn3);MainWindow.mysyn3.updatemess();
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
        public int putrealtime = 0; public string putrealmark;
        private int target1 = 0, target2 = 0,mttarget1= 0,mttarget2 = 0;

        private void first_clickbutton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); if (target1go == 0) return;
            first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
            if (target1 == 0) return;
            //string road = "data/warehouse_prop/" + mttarget1.ToString() + "/number.txt";
            MainWindow.mymain_interface.prop_number[mttarget1] -= 1;
            sql.sql_add_prop(mttarget1);
            MainWindow.mymain_interface.peo_dollar -= readclass.read_int("data/plant_ill/" + putrealmark
                + "/target1dollar.txt");
            sql.update_dollar();
            system.jiangli();
            MainWindow.myevo.pos = putrealtime; MainWindow.myevo.oldmark =int.Parse( putrealmark); 
            MainWindow.myevo.newmark = target1;MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
            MainWindow.myevo.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.myevo);
            updatemess();
            emptypic();
        }

        private void first_clickbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (target1go == 0) return;
            first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化亮.jpg") as ImageSource;
        }

        private void first_clickbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (target1go == 0) return;
            first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
        }

        private void first_clickbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (target1go == 0) return;
            first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化亮.jpg") as ImageSource;
        }
        private void second_clickbutton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); if (target2go == 0) return;
            second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
            if (target2 == 0) return;
            MainWindow.mymain_interface.prop_number[mttarget2] -= 1;
            sql.sql_add_prop(mttarget2);
            MainWindow.mymain_interface.peo_dollar -= readclass.read_int("data/plant_ill/" + putrealmark
                + "/target2dollar.txt");
            sql.update_dollar();
            system.jiangli();
            MainWindow.myevo.pos = putrealtime; MainWindow.myevo.oldmark = int.Parse(putrealmark);
            MainWindow.myevo.newmark = target2; MainWindow.mymain_interface.frame3.Visibility = Visibility.Visible;
            MainWindow.myevo.updatemess(); MainWindow.mymain_interface.frame3.Navigate(MainWindow.myevo);
            updatemess();
            emptypic();//10.8 add
        }

        private void second_clickbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (target2go == 0) return;
            second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化亮.jpg") as ImageSource;
        }

        private void second_clickbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (target2go == 0) return;
            second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
        }

        private void second_clickbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (target2go == 0) return;
            second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化亮.jpg") as ImageSource;
        }
        private void emptypic()
        {
            put_plant_pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            first_material_pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            first_target_pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            second_material_pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            second_target_pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            prompt.Text = "";prompt2.Text = "";
            first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
            second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
            target1go = 0; target2go = 0;mttarget1 = 0;mttarget2 = 0;
        }
        private void put_plant_pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            emptypic();
        }

        private int target1go = 0, target2go = 0,putnowpos;public bool putbool = false;
        private void updateevo()
        {
            if (find_mark_plant(putnowpos) == 0) return;
            putrealtime = find_mark_plant(putnowpos); putbool = true;
            putrealmark = MainWindow.mymain_interface.plantware[putrealtime].mark.ToString();
            put_plant_pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" +
                putrealmark.ToString() + ".png") as ImageSource;
            target1 = readclass.read_int("data/plant_ill/" + putrealmark + "/target1mark.txt");
            target2 = readclass.read_int("data/plant_ill/" + putrealmark + "/target2mark.txt");
            if (target1 == 0) return;
            first_target_pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" +
                target1.ToString() + ".png") as ImageSource;
            mttarget1 = readclass.read_int("data/plant_ill/" + target1 + "/material.txt");
            first_material_pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" +
                mttarget1.ToString() + ".png") as ImageSource;
            
            target1go = 1; prompt.Text = "";
            if (MainWindow.mymain_interface.plantware[putrealtime].lv < readclass.read_int("data/plant_ill/"
                + putrealmark + "/target1lv.txt"))
            {
                target1go = 0;
                first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/等级不足.jpg") as ImageSource;
                prompt.Text = "需要" + readclass.read_string("data/plant_ill/"
                + putrealmark + "/target1lv.txt") + "级";
            }
            else if (MainWindow.mymain_interface.prop_number[mttarget1] < 1)
            {
                target1go = 0;
                first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/道具不足.jpg") as ImageSource;
                prompt.Text = "需要" + readclass.read_string("data/warehouse_prop/" + 
                    mttarget1.ToString() +"/name.txt")  ;
            }
            else if (MainWindow.mymain_interface.peo_dollar < readclass.read_int("data/plant_ill/" + putrealmark
                + "/target1dollar.txt"))
            {
                target1go = 0;
                first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/金币不足.jpg") as ImageSource;
                prompt.Text = "金币" + readclass.read_string("data/plant_ill/" + putrealmark
                + "/target1dollar.txt")  ;
            }
            else
                first_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
            if (target2 == 0) return;
            second_target_pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" +
                target2.ToString() + ".png") as ImageSource;
            mttarget2 = readclass.read_int("data/plant_ill/" + target2 + "/material.txt");
            second_material_pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" +
                mttarget2.ToString() + ".png") as ImageSource;

            target2go = 1; prompt2.Text = "";
            if (MainWindow.mymain_interface.plantware[putrealtime].lv < readclass.read_int("data/plant_ill/"
                + putrealmark + "/target2lv.txt"))
            {
                target2go = 0;
                second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/等级不足.jpg") as ImageSource;
                prompt2.Text = "需要" + readclass.read_string("data/plant_ill/"
                + putrealmark + "/target2lv.txt") + "级";
            }
            else if (MainWindow.mymain_interface.prop_number[mttarget2] < 1)
            {
                target2go = 0;
                second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/道具不足.jpg") as ImageSource;
                prompt2.Text = "需要" + readclass.read_string("data/warehouse_prop/" +
                    mttarget2.ToString() + "/name.txt");
            }
            else if (MainWindow.mymain_interface.peo_dollar < readclass.read_int("data/plant_ill/" + putrealmark
                + "/target2dollar.txt"))
            {
                target2go = 0;
                second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/金币不足.jpg") as ImageSource;
                prompt2.Text = "金币" + readclass.read_string("data/plant_ill/" + putrealmark
                + "/target2dollar.txt");
            }
            else
                second_clickbutton.Source = new ImageSourceConverter().ConvertFromString("pic/进化.jpg") as ImageSource;
        }
        private void pos11buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 1; emptypic(); updateevo();
        }
        private void pos12buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 2; emptypic(); updateevo();
        }
        private void pos13buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 3; emptypic(); updateevo();
        }
        private void pos21buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 4; emptypic(); updateevo();
        }
        private void pos22buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 5; emptypic(); updateevo();
        }
        private void pos23buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 6; emptypic(); updateevo();
        }
        private void pos31buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 7; emptypic(); updateevo();
        }
        private void pos32buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 8; emptypic(); updateevo();
        }
        private void pos33buttonclick(object sender, MouseButtonEventArgs e)
        {
            system.dong(); putnowpos = (nowpage - 1) * 9 + 9; emptypic(); updateevo();
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

        private void first_material_pic_MouseEnter(object sender, MouseEventArgs e)
        {
            if (mttarget1 == 0) return;
            prop_smdetail a = new prop_smdetail();a.pos = mttarget1;a.updatemess();
            prop1frame.Visibility = Visibility.Visible;prop1frame.Navigate(a);
        }

        private void first_material_pic_MouseLeave(object sender, MouseEventArgs e)
        {
            prop1frame.Visibility = Visibility.Hidden;
        }

        private void second_material_pic_MouseEnter(object sender, MouseEventArgs e)
        {
            if (mttarget2 == 0) return;
            prop_smdetail a = new prop_smdetail(); a.pos = mttarget2; a.updatemess();
            prop2frame.Visibility = Visibility.Visible; prop2frame.Navigate(a);
        }

        private void second_material_pic_MouseLeave(object sender, MouseEventArgs e)
        {
            prop2frame.Visibility = Visibility.Hidden;
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
