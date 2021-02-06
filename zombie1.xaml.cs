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
    public partial class zombie1 : Page
    {
        public zombie1()
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
            MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden; allhidden(); system.dong();
        }
        private void gogogo()
        {
            MainWindow.myzombie_bf_fight.zombie = selectzombie;
            MainWindow.mymain_interface.frame2.Navigate(MainWindow.myzombie_bf_fight); system.dong();
            MainWindow.myzombie_bf_fight.updatemess(); allhidden();
            MainWindow.myzombie_bf_fight.updateup();
        }
        private void pos11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1)*12 + 1;gogogo();
        }
        private void pos12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 2; gogogo();
        }
        private void pos13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 3; gogogo();
        }
        private void pos21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 4; gogogo();
        }
        private void pos22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 5; gogogo();
        }
        private void pos23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 6; gogogo();
        }
        private void pos31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 7; gogogo();
        }
        private void pos32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 8; gogogo();
        }
        private void pos33_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 9; gogogo();
        }
        private void pos41_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 10; gogogo();
        }
        private void pos42_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 11; gogogo();
        }
        private void allhidden()
        {
            zombie1frame.Visibility = Visibility.Hidden; zombie2frame.Visibility = Visibility.Hidden;
            zombie3frame.Visibility = Visibility.Hidden; zombie4frame.Visibility = Visibility.Hidden;
            zombie5frame.Visibility = Visibility.Hidden; zombie6frame.Visibility = Visibility.Hidden;
            zombie7frame.Visibility = Visibility.Hidden; zombie8frame.Visibility = Visibility.Hidden;
            zombie9frame.Visibility = Visibility.Hidden; zombie10frame.Visibility = Visibility.Hidden;
            zombie11frame.Visibility = Visibility.Hidden; zombie12frame.Visibility = Visibility.Hidden;
        }
        private void zombie11_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 1;zombie1frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail();a.zombie = seezombie ;a.updatemess(); zombie1frame.Navigate(a);
        }

        private void zombie11_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie12_MouseEnter(object sender, MouseEventArgs e)
        {
             seezombie = (nowpage - 1) * 12 + 2; zombie2frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie2frame.Navigate(a);
        }

        private void zombie12_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie13_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 3; zombie3frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie3frame.Navigate(a);
        }

        private void zombie13_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie21_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 4; zombie4frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie4frame.Navigate(a);
        }

        private void zombie21_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie22_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 5; zombie5frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie5frame.Navigate(a);
        }

        private void zombie22_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie23_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 6; zombie6frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie6frame.Navigate(a);
        }

        private void zombie23_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie31_MouseEnter(object sender, MouseEventArgs e)
        {
           seezombie = (nowpage - 1) * 12 + 7; zombie7frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie7frame.Navigate(a);
        }

        private void zombie31_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie32_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 8; zombie8frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie8frame.Navigate(a);
        }

        private void zombie32_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie33_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 9; zombie9frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie9frame.Navigate(a);
        }

        private void zombie33_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie41_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 10; zombie10frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie10frame.Navigate(a);
        }

        private void zombie41_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie42_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1) * 12 + 11; zombie11frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie11frame.Navigate(a);
        }

        private void zombie42_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }
        private void zombie43_MouseEnter(object sender, MouseEventArgs e)
        {
            seezombie = (nowpage - 1)*12+12; zombie12frame.Visibility = Visibility.Visible;
            zombiedetail a = new zombiedetail(); a.zombie = seezombie; a.updatemess(); zombie12frame.Navigate(a);
        }

        private void zombie43_MouseLeave(object sender, MouseEventArgs e)
        {
            allhidden();
        }

        

        private void pos43_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.jiangshi(); selectzombie = (nowpage - 1) * 12 + 12; gogogo();
        }
    }
}
