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
    public partial class get_prop: Page
    {

        public int zombie = 0;
        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.lingdang();
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
            MainWindow.mychest.updatemess();MainWindow.myprop.updatemess();
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
        public get_prop()
        {
            InitializeComponent();
        }
        private void allhidden()
        {
            drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop2pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop3pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop4pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop5pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
        }
        public void start_interface()
        {
            allhidden();
            string road = "data/zombie/" + zombie.ToString() + "/";
            int number = readclass.read_int(road + "dropnumber.txt");if (number == 0) return;
            number = (new Random()).Next(1, number + 1);
            int mark = readclass.read_many_int(road + "drop.txt");
            drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" +mark.ToString()+".png") as ImageSource;
            MainWindow.mymain_interface.prop_number[mark] = MainWindow.mymain_interface.prop_number[mark] + 1;
            sql.sqlsolve("UPDATE PROP SET p" + mark.ToString() + " = " + MainWindow.mymain_interface.prop_number[mark].ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString());
            mark = readclass.read_many_int(road + "drop.txt"); if (number == 1) return;
            drop2pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + mark.ToString() + ".png") as ImageSource;
            MainWindow.mymain_interface.prop_number[mark] = MainWindow.mymain_interface.prop_number[mark] + 1;
            sql.sqlsolve("UPDATE PROP SET p" + mark.ToString() + " = " + MainWindow.mymain_interface.prop_number[mark].ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString());
            mark = readclass.read_many_int(road + "drop.txt"); if (number == 2) return;
            drop3pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + mark.ToString() + ".png") as ImageSource;
            MainWindow.mymain_interface.prop_number[mark] = MainWindow.mymain_interface.prop_number[mark] + 1;
            sql.sqlsolve("UPDATE PROP SET p" + mark.ToString() + " = " + MainWindow.mymain_interface.prop_number[mark].ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString());
            mark = readclass.read_many_int(road + "drop.txt"); if (number == 3) return;
            drop4pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + mark.ToString() + ".png") as ImageSource;
            MainWindow.mymain_interface.prop_number[mark] = MainWindow.mymain_interface.prop_number[mark] + 1;
            sql.sqlsolve("UPDATE PROP SET p" + mark.ToString() + " = " + MainWindow.mymain_interface.prop_number[mark].ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString());
            mark = readclass.read_many_int(road + "drop.txt"); if (number == 4) return;
            drop5pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + mark.ToString() + ".png") as ImageSource;
            MainWindow.mymain_interface.prop_number[mark] = MainWindow.mymain_interface.prop_number[mark] + 1;
            sql.sqlsolve("UPDATE PROP SET p" + mark.ToString() + " = " + MainWindow.mymain_interface.prop_number[mark].ToString() +
                " WHERE MARK = " + MainWindow.mymain_interface.id.ToString());
            system.alldollarfresh();
        }
    }
}
