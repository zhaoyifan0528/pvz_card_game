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
    public partial class supershop_detail : Page
    {
        public supershop_detail()
        {
            InitializeComponent();
        }
        public int nowpos= 0,number = 0,nowpos1;
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex re = new Regex("[^0-9]");

            e.Handled = re.IsMatch(e.Text);

        }
        public void updatemess()
        {
            nowpos = MainWindow.mysupershop.pos;sellnumber.Text = "1";
            nowpos1 = readclass.read_int("data/supershop/" + nowpos.ToString() + "/mark.txt");
            nameshow.Text = readclass.read_string("data/warehouse_prop/" + nowpos1.ToString() + "/name.txt");
            priceshow.Text = "售价："+ readclass.read_string("data/supershop/" + nowpos.ToString() + "/price.txt");
            hasnumbershow.Text = "拥有数量：" + MainWindow.mymain_interface.prop_number[nowpos1].ToString();
            instructionshow.Text = readclass.read_string("data/warehouse_prop/" + nowpos1.ToString() + "/instructions.txt");
            proppic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + nowpos1.ToString() + ".png") as ImageSource;
        }
        private void soldhidden()
        {
            surepic.Visibility = Visibility.Hidden;soldtext.Visibility = Visibility.Hidden;
            soldshow.Visibility = Visibility.Hidden;quit2pic.Visibility = Visibility.Hidden;
        }
        private void soldpicshow()
        {
            surepic.Visibility = Visibility.Visible;soldtext.Visibility = Visibility.Visible;
            soldshow.Visibility = Visibility.Visible; quit2pic.Visibility = Visibility.Visible;
            soldtext.Text = "你确定购买" + number.ToString() + "个" + nameshow.Text + "吗？\n会交付"+(number *
                readclass.read_int("data/supershop/" + nowpos.ToString() + "/price.txt")).ToString()+"礼券";
        }
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消.jpg") as ImageSource;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden; system.dong();
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
            quitpic.Source = new ImageSourceConverter().ConvertFromString("pic/取消亮.jpg") as ImageSource;
        }

        private void soldoutpic_MouseEnter(object sender, MouseEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/购买亮.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeave(object sender, MouseEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/购买.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/购买摁.jpg") as ImageSource;
        }

        private void soldoutpic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            soldoutpic.Source = new ImageSourceConverter().ConvertFromString("pic/购买亮.jpg") as ImageSource;
            number = int.Parse(sellnumber.Text); 
            if (number <= 0) { MessageBox.Show("李在赣神魔","提示");return; }
            soldpicshow();
        }

        private void surepic_MouseEnter(object sender, MouseEventArgs e)
        {
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定亮.jpg") as ImageSource;
        }

        private void surepic_MouseLeave(object sender, MouseEventArgs e)
        {
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定.jpg") as ImageSource;
        }

        private void surepic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定.jpg") as ImageSource;
        }

        private void surepic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.money();
            surepic.Source = new ImageSourceConverter().ConvertFromString("pic/确定亮.jpg") as ImageSource;
            soldhidden();//金钱音效
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden;
            if(MainWindow.mymain_interface.prop_number[123] - number *
                readclass.read_int("data/supershop/" + nowpos.ToString() + "/price.txt")<0)
            {
                MessageBox.Show("没钱买不起QAQ");return;
            }
            MainWindow.mymain_interface.prop_number[123]-= number *
                readclass.read_int("data/supershop/" + nowpos.ToString() + "/price.txt");
            sql.sql_add_prop(123);
            MainWindow.mymain_interface.prop_number[nowpos1] += number;
            sql.sql_add_prop(nowpos1);
            MainWindow.myprop.updatemess();MainWindow.mychest.updatemess(); system.alldollarfresh();
        }

        private void quit2pic_MouseEnter(object sender, MouseEventArgs e)
        {
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1亮.jpg") as ImageSource;
        }

        private void quit2pic_MouseLeave(object sender, MouseEventArgs e)
        {
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1.jpg") as ImageSource;
        }

        private void quit2pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1.jpg") as ImageSource;
        }

        private void quit2pic_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            quit2pic.Source = new ImageSourceConverter().ConvertFromString("pic/取消1亮.jpg") as ImageSource;
            soldhidden(); system.dong();
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
    }
}
