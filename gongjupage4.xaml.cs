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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class gongjupage4:Page
    {
        
        public gongjupage4()
        {
            InitializeComponent();startit();
        }
        private void emptytext()
        {
            nameshow.Text = "";numbershow.Text = "";instructions.Text = "";priceshow.Text = "";
        }
        public void startit()
        {
            readpropshow.Items.Clear();
            int num = readclass.read_int("data/prop_number.txt");
            for(int i = 1;i <= num;++i)
            {
                readpropshow.Items.Add(i.ToString());
            }
        }
        string mark; string road;
        private void readplantshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readpropshow.SelectedItem == null) return;
            string road2 = "data/warehouse_prop/" + readpropshow.SelectedItem.ToString() + "/";
            nameshow.Text = readclass.read_string(road2 + "name.txt");
            priceshow.Text = readclass.read_string(road2 + "price.txt");
            numbershow.Text = readclass.read_string(road2 + "number.txt");
            instructions.Text = readclass.read_string(road2 + "instructions.txt");
        }

        private void emptybutton_Click(object sender, RoutedEventArgs e)
        {
            emptytext();
        }

        private void writebutton_Click(object sender, RoutedEventArgs e)
        {
            if(posshow.Text == ""||int.Parse(posshow.Text) > (readclass.read_int("data/prop_number.txt") + 1))
            {
                MessageBox.Show("编号错误");return;
            }
            int pos = int.Parse(posshow.Text);
            if (!File.Exists("pic/prop/" + pos.ToString() + ".png")) 
            { MessageBox.Show("请先创建pic/prop/" + pos.ToString() + ".png"); return; }
            if(nameshow.Text ==""||priceshow.Text==""||instructions.Text==""||numbershow.Text=="")
            {
                MessageBox.Show("必填项为空");return;
            }
            sure.Visibility = Visibility.Visible;
            no.Visibility = Visibility.Visible; makesure.Visibility = Visibility.Visible;
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
            int pos = int.Parse(posshow.Text);
            if (!Directory.Exists("data/warehouse_prop/" + pos.ToString()))
            {
                readclass.write_int("data/prop_number.txt", readclass.read_int("data/prop_number.txt") + 1);
                Directory.CreateDirectory("data/warehouse_prop/" + pos.ToString());
            }
            string road2 = "data/warehouse_prop/" + pos.ToString() + "/";
            readclass.write_string(road2 + "name.txt", nameshow.Text);
            readclass.write_string(road2 + "number.txt", numbershow.Text);
            readclass.write_string(road2 + "price.txt", priceshow.Text);
            readclass.write_string(road2 + "instructions.txt", instructions.Text);
            startit();MessageBox.Show("添加成功");posshow.Text = "";
        }
        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
        }

    }
}
