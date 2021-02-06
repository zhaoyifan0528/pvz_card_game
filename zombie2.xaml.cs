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
    public partial class zombie2 : Page
    {
        public zombie2()
        {
            InitializeComponent();
            quanshow.Text = readclass.read_string("data/warehouse_prop/123/number.txt");
            moneyshow.Text = readclass.read_string("data/dollar.txt");
        }
        public int selectzombie = 0,seezombie = 0;private int nowpage = 1;
      
        private void close_MouseEnter(object sender, MouseEventArgs e)
        {
            backpic.Source = new ImageSourceConverter().ConvertFromString("pic/返回2.png") as ImageSource;
        }
        private void close_MouseLeave(object sender, MouseEventArgs e)
        {
            backpic.Source = new ImageSourceConverter().ConvertFromString("pic/返回.png") as ImageSource;
        }

        private void close_Mouseclick(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            if (nowpage == 1)
            {
                MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden; allhidden(); 
            }
            else
            {
                nowpage--; pageshow.Text = "第" + nowpage.ToString() + "层";
            }
        }
        private void gogogo()
        {
            if (selectzombie > readclass.read_int("data/zombie_number.txt")) return;
            MainWindow.myzombie_bf_fight.zombie = selectzombie;
            MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_bf_fight); system.dong();
            MainWindow.myzombie_bf_fight.updatemess(); allhidden(); MainWindow.myzombie_bf_fight.updateup();
        }
        private void pos11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1)*9 + 1+12;gogogo();
        }
        private void pos12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 2 + 12; gogogo();
        }
        private void pos13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 3 + 12; gogogo();
        }
        private void pos21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 4 + 12; gogogo();
        }
        private void pos22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 5 + 12; gogogo();
        }
        private void pos23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 6 + 12; gogogo();
        }
        private void pos31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 7 + 12; gogogo();
        }
        private void pos32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 8 + 12; gogogo();
        }
        private void pos33_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 9 + 9 + 12; gogogo();
        }
        private void allhidden()
        {
            zombie1frame.Visibility = Visibility.Hidden; zombie2frame.Visibility = Visibility.Hidden;
            zombie3frame.Visibility = Visibility.Hidden; zombie4frame.Visibility = Visibility.Hidden;
            zombie5frame.Visibility = Visibility.Hidden; zombie6frame.Visibility = Visibility.Hidden;
            zombie7frame.Visibility = Visibility.Hidden; zombie8frame.Visibility = Visibility.Hidden;
            zombie9frame.Visibility = Visibility.Hidden; 
        }
        private void zombie11_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 1+12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return; 
            zombie1frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie1frame.Navigate(a);
        }

        private void zombie11_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie12_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 2 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return; 
            zombie2frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie2frame.Navigate(a);
        }

        private void zombie12_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie13_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 3 + 12;if (seezombie > readclass.read_int("data/zombie_number.txt")) return;
            zombie3frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie3frame.Navigate(a);
        }

        private void zombie13_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie21_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 4 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return;
            zombie4frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie4frame.Navigate(a);
        }

        private void zombie21_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie22_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 5 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return;
            zombie5frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie5frame.Navigate(a);
        }

        private void zombie22_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie23_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 6 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return;
            zombie6frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie6frame.Navigate(a);
        }

        private void zombie23_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie31_MouseEnter(object sender, MouseEventArgs e)
        {
           seezombie = (nowpage - 1) * 9 + 7 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return; 
            zombie7frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie7frame.Navigate(a);
        }

        private void zombie31_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie32_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 8 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return;
            zombie8frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie8frame.Navigate(a);
        }

        private void zombie32_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie33_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 9 + 9 + 12; if (seezombie > readclass.read_int("data/zombie_number.txt")) return;
            zombie9frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie;a.updatemess(); zombie9frame.Navigate(a);
        }

        private void zombie33_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
       

        private void goleft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();if (nowpage == 1) return;nowpage--;
            
        }

        private void goright_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();  nowpage++;
            pageshow.Text = "第" + nowpage.ToString() + "层";
        }

        
    }
}
