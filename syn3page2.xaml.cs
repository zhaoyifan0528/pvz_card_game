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
    public partial class syn3page2 : Page
    {
        public syn3page2()
        {
            InitializeComponent();
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
        }
        private void gotosyn2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn2);
        }
        private void gotosyn3(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn3);
        }
        private void gotosyn3page2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(MainWindow.mysyn3); MainWindow.mysyn3.updatemess();
        }
    }
}
