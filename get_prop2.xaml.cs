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
    public partial class get_prop2: Page
    {

        public int zombie = 0,gamemode = 0;
        public int drop1, drop1number, drop2, drop2number, drop3, drop3number, drop4, drop4number;
        public void mkdrop(int a1,int b1,int a2,int b2,int a3,int b3,int a4,int b4)
        {
            drop1 = a1; drop1number = b1;drop2 = a2; drop2number = b2; 
            drop3 = a3; drop3number = b3;drop4 = a4; drop4number = b4;
        }
        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.lingdang();
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
            MainWindow.mychest.updatemess();MainWindow.myprop.updatemess();
            if(gamemode == 3)
            {
                gamemode = 0;
                MainWindow.mypvz1.frame1.Visibility = Visibility.Hidden;
            }
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
        public get_prop2()
        {
            InitializeComponent();
        }
        private void allhidden()
        {
            drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop2pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop3pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop4pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            numbershow1.Text = ""; numbershow2.Text = ""; numbershow3.Text = ""; numbershow4.Text = "";
        }
        public void start_interface()
        {
            allhidden();
            if(drop1 != 0&& drop1number!=0)
            {
                drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + drop1.ToString() + ".png") as ImageSource;
                MainWindow.mymain_interface.prop_number[drop1] += drop1number;
                sql.sql_add_prop(drop1);
                numbershow1.Text = drop1number.ToString();
            }
            if (drop2 != 0 && drop2number != 0)
            {
                drop2pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + drop2.ToString() + ".png") as ImageSource;
                MainWindow.mymain_interface.prop_number[drop2] += drop2number;
                sql.sql_add_prop(drop2);
                numbershow2.Text = drop2number.ToString();
            }
            if (drop3 != 0 && drop3number != 0)
            {
                drop3pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + drop3.ToString() + ".png") as ImageSource;
                MainWindow.mymain_interface.prop_number[drop3] += drop3number;
                sql.sql_add_prop(drop3);
                numbershow3.Text = drop3number.ToString();
            }
            if (drop4 != 0 && drop4number != 0)
            {
                drop4pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + drop4.ToString() + ".png") as ImageSource;
                MainWindow.mymain_interface.prop_number[drop4] += drop4number;
                sql.sql_add_prop(drop4);
                numbershow4.Text = drop4number.ToString();
            }
            if(gamemode == 3)
            {
                text1.Text = "";text2.Text = "";
            }
        }
    }
}
