    using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class chest_detail: Page
    {
        public chest_detail()
        {
            InitializeComponent();
        }
        public int nowpos= 0,number = 0;public int opennumber = 0;
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex re = new Regex("[^0-9]");

            e.Handled = re.IsMatch(e.Text);

        }
        public void updatemess()
        {
            nowpos = MainWindow.mychest.pos;sellnumber.Text = "1";
            if (readclass.read_int("data/warehouse_prop/" + nowpos.ToString() + "/species.txt") != 0) sellnumber.IsEnabled = false;
            else sellnumber.IsEnabled = true;
            nameshow.Text = readclass.read_string("data/warehouse_prop/" + nowpos.ToString() + "/name.txt");
            priceshow.Text = "卖出价格："+ readclass.read_string("data/warehouse_prop/" + nowpos.ToString() + "/price.txt");
            hasnumbershow.Text = "拥有数量：" + MainWindow.mymain_interface.prop_number[nowpos].ToString();
            instructionshow.Text = readclass.read_string("data/warehouse_prop/" + nowpos.ToString() + "/instructions.txt");
            proppic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + nowpos.ToString() + ".png") as ImageSource;
        }
        
        
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消.jpg") as ImageSource;
        }

        private void quitpic_MouseEnter(object sender, MouseEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消亮.jpg") as ImageSource;
        }

        private void quitpic_MouseLeave(object sender, MouseEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消.jpg") as ImageSource;
        }

        private void quitpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden; 
        }

        private void soldoutpic_MouseEnter(object sender, MouseEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/使用亮.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeave(object sender, MouseEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/使用.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/使用按.jpg") as ImageSource;
            
        }

        private void numberright_MouseEnter(object sender, MouseEventArgs e)
        {
            numberright.Source = new ImageSourceConverter().ConvertFromString("pic/button2亮3.png") as ImageSource;
        }

        private void numberright_MouseLeave(object sender, MouseEventArgs e)
        {
            numberright.Source = new ImageSourceConverter().ConvertFromString("pic/button2.png") as ImageSource;
        }

        private void numberright_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            numberright.Source = new ImageSourceConverter().ConvertFromString("pic/button2按3.png") as ImageSource;
            if (sellnumber.Text == "") return;
            int nownumber = int.Parse(sellnumber.Text);
            if (nownumber == MainWindow.mymain_interface.prop_number[nowpos]) return;
            sellnumber.Text = (nownumber + 1).ToString();
        }

        private void numberright_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            numberright.Source = new ImageSourceConverter().ConvertFromString("pic/button2亮3.png") as ImageSource;
        }

        private void numberleft_MouseEnter(object sender, MouseEventArgs e)
        {
            numberleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1亮3.png") as ImageSource;
        }

        private void numberleft_MouseLeave(object sender, MouseEventArgs e)
        {
            numberleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1.png") as ImageSource;
        }

        private void numberleft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            numberleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1按3.png") as ImageSource;
            if (sellnumber.Text == "") return;
            int nownumber = int.Parse(sellnumber.Text);
            if (nownumber <= 1) return;
            sellnumber.Text = (nownumber - 1).ToString();
        }

        private void numberleft_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            numberleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1亮3.png") as ImageSource;
        }

        private void soldoutpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            opennumber = int.Parse(sellnumber.Text);
            if (opennumber > MainWindow.mymain_interface.prop_number[nowpos]) return;            
            system.lingdang(); system.jiangli();
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/使用亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden;
            MainWindow.mymain_interface.prop_number[nowpos] =
                int.Parse(sql.sqlget("SELECT * FROM PROP WHERE MARK = "+MainWindow.mymain_interface.id.ToString(),
                "p"+nowpos.ToString())) - opennumber;
            sql.sqlsolve("UPDATE PROP SET p" + nowpos.ToString() + " = " + MainWindow.mymain_interface.prop_number[nowpos].ToString() +
                "WHERE MARK = " + MainWindow.mymain_interface.id.ToString());
            MainWindow.mymain_interface.frame4.Visibility = Visibility.Visible;
            MainWindow.mymain_interface.frame4.Navigate(MainWindow.mychestopen);
            MainWindow.mychestopen.pos = nowpos;
            MainWindow.mychestopen.start_interface();
            MainWindow.mychest.updatemess();
        }

        
    }
}
