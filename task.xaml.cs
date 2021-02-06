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
    public partial class task: Page
    {
        public task()
        {
            InitializeComponent();allhidden();
            // mystack.Children.Remove(task2);
            judge();
        }
        public int picmark = 0, att = 0, arm = 0, lif = 0, thr = 0;// for zombie2
        public void judge()
        {
            if(readclass.read_int("data/task/start/finished.txt") >= 1) mystack.Children.Remove(task_start);
            if (readclass.read_int("data/task/new_friend/finished.txt") >= 1) mystack.Children.Remove(task_new_friend);
            if (readclass.read_int("data/task/first_fight/finished.txt") >= 1) mystack.Children.Remove(task_fitst_fight);
            if (readclass.read_int("data/task/first_syn/finished.txt") >= 1) mystack.Children.Remove(task_first_syn);
            if (readclass.read_int("data/task/afanda/finished.txt") >= 1) mystack.Children.Remove(task_afanda);
            if (readclass.read_int("data/task/anye/finished.txt") >= 1) mystack.Children.Remove(task_anye);
            if (readclass.read_int("data/task/zombiequn/finished.txt") >= 1) mystack.Children.Remove(task_zombiequn);
            if (readclass.read_int("data/task/anye_first/finished.txt") >= 1) mystack.Children.Remove(task_anye_first);
            if (readclass.read_int("data/task/plant_grow/finished.txt") >= 1) mystack.Children.Remove(task_plant_grow);
            if (readclass.read_int("data/task/final_fight/finished.txt") >= 1) mystack.Children.Remove(task_final_fight);
            if (readclass.read_int("data/task/guijiao/finished.txt") > 15) mystack.Children.Remove(task_guijiao);
        }
        public string select = " ";int flag = 0;
        public void allhidden()
        {
            instructions.Visibility = Visibility.Hidden;finish.Visibility = Visibility.Hidden;
            needlabel.Visibility = Visibility.Hidden;needtext.Visibility = Visibility.Hidden;
            giftlabe.Visibility = Visibility.Hidden;gifttext.Visibility = Visibility.Hidden;
        }
        public void allshow()
        {
            instructions.Visibility = Visibility.Visible; finish.Visibility = Visibility.Visible;
            needlabel.Visibility = Visibility.Visible; needtext.Visibility = Visibility.Visible;
            giftlabe.Visibility = Visibility.Visible; gifttext.Visibility = Visibility.Visible;
        }
        private void close_MouseEnter(object sender, MouseEventArgs e)
        {
            close.Source = new ImageSourceConverter().ConvertFromString("pic/close亮.png") as ImageSource;
        }

        private void close_MouseLeave(object sender, MouseEventArgs e)
        {
            close.Source = new ImageSourceConverter().ConvertFromString("pic/close.png") as ImageSource;
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            close.Source = new ImageSourceConverter().ConvertFromString("pic/close按.png") as ImageSource;
            system.dong();
        }

        private void close_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            close.Source = new ImageSourceConverter().ConvertFromString("pic/close亮.png") as ImageSource;
            MainWindow.mymain_interface.frame6.Visibility = Visibility.Hidden;
        }
        private void givetext()
        {
            instructions.Text = readclass.read_string("data/task/" + select + "/instructions.txt");
            needtext.Text = readclass.read_string("data/task/" + select + "/need.txt");
            readclass.intext("data/task/" + select + "/give.txt", gifttext);
           
        }
        private void tast_start_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "start";allshow();givetext(); 
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void finish_MouseEnter(object sender, MouseEventArgs e)
        {
            if (flag == 0) return; 
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成亮.png") as ImageSource;
        }

        private void finish_MouseLeave(object sender, MouseEventArgs e)
        {
            if (flag == 0) return;
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
        }

        private void finish_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (flag == 0) return;
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成按.png") as ImageSource;
            system.dong();
        }

        private void finish_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (flag == 0) return;MainWindow.myzombie_fight3.jumpfight.Visibility = Visibility.Visible;
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成亮.png") as ImageSource;
            if(select =="start")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(124, 1);
                MainWindow.mymain_interface.peo_exp+= 20;system.solve_peo_exp();
            }
            if (select == "new_friend")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(108, 2);
                readclass.prop_change(944, 1);
                MainWindow.mymain_interface.peo_exp += 20; system.solve_peo_exp();
            }
            if (select == "first_fight")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(1, 1);
                readclass.prop_change(944, 1);
                MainWindow.mymain_interface.peo_exp += 20; system.solve_peo_exp();
            }
            if (select == "first_syn")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(123, 20);
                readclass.prop_change(944, 1);
                MainWindow.mymain_interface.peo_exp += 20; system.solve_peo_exp();
            }
            if (select == "afanda")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(138, -3);
                readclass.prop_change(123, 30);
                readclass.prop_change(944, 1);
                readclass.prop_change(108, 5);
                MainWindow.mymain_interface.peo_exp += 40; system.solve_peo_exp();
            }
            if (select == "anye")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(139, -1);
                readclass.prop_change(124, 20);
                readclass.prop_change(944, 1);
                MainWindow.mymain_interface.peo_exp += 40; system.solve_peo_exp();
            }
            if (select == "zombiequn")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(944, 1);
                readclass.prop_change(103, 10);
                readclass.prop_change(137, 1);
                MainWindow.mymain_interface.peo_exp += 40; system.solve_peo_exp();
            }
            if (select == "anye_first")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(140, -1);
                readclass.prop_change(137, 1);
                readclass.prop_change(944, 2);
                readclass.prop_change(108, 5);
                MainWindow.mymain_interface.peo_exp += 60; system.solve_peo_exp();
            }
            if (select == "plant_grow")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(137, 1);
                readclass.prop_change(944, 2);
                readclass.prop_change(108, 5);
                MainWindow.mymain_interface.peo_exp += 60; system.solve_peo_exp();
            }
            if (select == "yumi")
            {
                readclass.write_int("data/task/" + select + "/finished.txt", 1); system.jiangli();
                readclass.prop_change(52, -1);
                readclass.prop_change(109, 2);
                readclass.prop_change(124, 10);
                MainWindow.mymain_interface.peo_exp += 10; system.solve_peo_exp();
            }
            if (select == "final_fight")
            {
                picmark = 1;lif = 100000000;att = 10000000; arm = 10000000; thr = 10000000;system.jiangshi();
                MainWindow.mymain_interface.frame6.Visibility = Visibility.Hidden;
                MainWindow.myzombie_bf_fight.zombie = 9991;
                MainWindow.mymain_interface.frame2.Visibility = Visibility.Visible; MainWindow.myzombie_bf_fight.updatemess();
                MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_bf_fight); MainWindow.myzombie_bf_fight.gamemode = 2;
                MainWindow.myzombieattr.zombie = 9991; MainWindow.myzombieattr.updatemess();
            }
            if (select == "guijiao")
            {
                picmark = 2; system.jiangshi();
                lif = readclass.read_int("data/zombie/" + (9992 + readclass.read_int("data/task/guijiao/finished.txt")).ToString() + "/lif.txt");
                att = readclass.read_int("data/zombie/" + (9992 + readclass.read_int("data/task/guijiao/finished.txt")).ToString() + "/att.txt");
                arm = readclass.read_int("data/zombie/" + (9992 + readclass.read_int("data/task/guijiao/finished.txt")).ToString() + "/arm.txt");
                thr = readclass.read_int("data/zombie/" + (9992 + readclass.read_int("data/task/guijiao/finished.txt")).ToString() + "/thr.txt");
                MainWindow.mymain_interface.frame6.Visibility = Visibility.Hidden;
                MainWindow.myzombie_bf_fight.zombie = 9992;
                MainWindow.mymain_interface.frame2.Visibility = Visibility.Visible; MainWindow.myzombie_bf_fight.updatemess();
                MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_bf_fight); MainWindow.myzombie_bf_fight.gamemode = 2;
                MainWindow.myzombieattr.zombie = 9992+ readclass.read_int("data/task/guijiao/finished.txt"); 
                MainWindow.myzombieattr.updatemess();
            }
            judge();allhidden();
        }

        private void tast_new_friend_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "new_friend"; allshow(); givetext();
            if(MainWindow.mymain_interface.allnumber < 5) { finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource;flag = 0; return; }

            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_fitst_fight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "first_fight"; allshow(); givetext();
            if (MainWindow.mymain_interface.prop_number[97]== 0&& MainWindow.mymain_interface.prop_number[98] == 0&&
                MainWindow.mymain_interface.prop_number[99] == 0 && MainWindow.mymain_interface.prop_number[100] == 0&&
                MainWindow.mymain_interface.prop_number[101] == 0)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_first_syn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "first_syn"; allshow(); givetext();
            int flag_task = 0;
            for (int i = 1; i <= MainWindow.mymain_interface.allnumber; ++i)
                if (MainWindow.mymain_interface.plantware[i].mark == 2) flag_task = 1;
            if(flag_task == 0)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void tast_afanda_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "afanda"; allshow(); givetext();
            if (MainWindow.mymain_interface.prop_number[138] < 3)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_final_fight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "final_fight"; allshow(); givetext();
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_guijiao_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "guijiao"; allshow(); givetext();
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_yumi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "yumi"; allshow(); givetext();
            if (MainWindow.mymain_interface.prop_number[52] < 1)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_anye_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "anye"; allshow(); givetext();
            if (MainWindow.mymain_interface.prop_number[139] < 1)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_zombiequn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "zombiequn"; allshow(); givetext();
            if (MainWindow.mymain_interface.peo_qun < 20)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_anye_first_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "anye_first"; allshow(); givetext();
            if (MainWindow.mymain_interface.prop_number[140] < 1)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }

        private void task_plant_grow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); select = "plant_grow"; allshow(); givetext();
            int flag_task = 0;
            for (int i = 1; i <= MainWindow.mymain_interface.allnumber; ++i)
                if (MainWindow.mymain_interface.plantware[i].lv >= 50) flag_task = 1;
            if (flag_task == 0)
            {
                finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成暗.png") as ImageSource; flag = 0; return;
            }
            finish.Source = new ImageSourceConverter().ConvertFromString("pic/完成1.png") as ImageSource;
            flag = 1;
        }
    }
}
