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
    public partial class gongjupage3:Page
    {
        
        public gongjupage3()
        {
            InitializeComponent();startit();
        }
        private void emptytext()
        {
            lifshow.Text = "";attshow.Text = "";armshow.Text = "";thrshow.Text = "";
            expshow.Text = "";dropnumbershow.Text = "";drop1show.Text = ""; drop2show.Text = "";
            drop3show.Text = ""; drop4show.Text = ""; drop5show.Text = ""; drop6show.Text = "";
            drop7show.Text = ""; drop8show.Text = ""; drop9show.Text = ""; drop10show.Text = "";
        }
        public void startit()
        {
            int num = readclass.read_int("data/zombie_number.txt");
            for(int i=1;i<=num;++i)
            {
                readzombieshow.Items.Add(i.ToString());
            }
        }
        private void readplantshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readzombieshow.SelectedItem == null) return;emptytext();
            int pos = int.Parse(readzombieshow.SelectedItem.ToString());
            string road2 = "data/zombie/" + pos.ToString() + "/";
            if (pos <= 12)
            {
                poshow.Text = "位于僵尸狩猎场第" + pos.ToString() + "个僵尸";
            }
            else
            {
                poshow.Text = "位于暗夜狩猎场第" + ((pos-13)/9+1).ToString() + "层"+"第"+((pos-13)%9+1).ToString()+"个僵尸";
            }
            lifshow.Text = readclass.read_string(road2 + "lif.txt");
            attshow.Text = readclass.read_string(road2 + "att.txt");
            armshow.Text = readclass.read_string(road2 + "arm.txt");
            thrshow.Text = readclass.read_string(road2 + "thr.txt");
            expshow.Text = readclass.read_string(road2 + "exp.txt");
            StreamReader sr = new StreamReader(road2+ "drop.txt", Encoding.Default);
            String line; line = sr.ReadLine();
            int ndrop = int.Parse(line);
            dropnumbershow.Text = ndrop.ToString();
            if (ndrop == 0) return;
            for (int i = 1; i <= ndrop; ++i)
            {
                line = sr.ReadLine();
                if (i == 1) drop1show.Text = line;
                if (i == 2) drop2show.Text = line;
                if (i == 3) drop3show.Text = line;
                if (i == 4) drop4show.Text = line;
                if (i == 5) drop5show.Text = line;
                if (i == 6) drop6show.Text = line;
                if (i == 7) drop7show.Text = line;
                if (i == 8) drop8show.Text = line;
                if (i == 9) drop9show.Text = line;
                if (i == 10) drop10show.Text = line;
            }
            sr.Close();
        }

        private void emptybutton_Click(object sender, RoutedEventArgs e)
        {
            emptytext();
        }

        private void writebutton_Click(object sender, RoutedEventArgs e)
        {
            if (zombiemark.Text=="") {MessageBox.Show("请添加编号"); return; }
            int pos = int.Parse(zombiemark.Text);
            if (pos > readclass.read_int("data/zombie_number.txt") + 1) { MessageBox.Show("编号异常"); return; }
            if (!File.Exists("pic/zombie/" + pos.ToString() + ".png")) 
            { MessageBox.Show("请先创建pic/zombie/" + pos.ToString() + ".png"); return; }
            if (lifshow.Text==""||attshow.Text==""||armshow.Text==""||thrshow.Text=="")
            {
                MessageBox.Show("四维不能为空"); return;
            }
            if(expshow.Text==""||dropnumbershow.Text=="")
            {
                MessageBox.Show("必填项为空"); return;
            }
            sure.Visibility = Visibility.Visible;
            no.Visibility = Visibility.Visible; makesure.Visibility = Visibility.Visible;
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
            int pos = int.Parse(zombiemark.Text);
            if (!Directory.Exists("data/zombie/" + pos.ToString()))
            {
                readclass.write_int("data/zombie_number.txt", readclass.read_int("data/zombie_number.txt") + 1);
                Directory.CreateDirectory("data/zombie/" + pos.ToString());
            }
            string road2 = "data/zombie/" + pos.ToString() + "/";
            readclass.write_string(road2 + "lif.txt", lifshow.Text);
            readclass.write_string(road2 + "att.txt", attshow.Text);
            readclass.write_string(road2 + "arm.txt", armshow.Text);
            readclass.write_string(road2 + "thr.txt", thrshow.Text);
            readclass.write_string(road2 + "exp.txt", expshow.Text);
            readclass.write_string(road2 + "dropnumber.txt", "5");
            int ndrop =int.Parse( dropnumbershow.Text);
            StreamWriter sw = new StreamWriter(road2 + "drop.txt");
            sw.WriteLine(ndrop);
            if (ndrop == 0)
            {
                sw.Flush(); sw.Close(); MessageBox.Show("添加成功!");readzombieshow.Items.Clear();startit();
                return;
            }
            for(int i = 1;i <= ndrop;++i)
            {
                if(i == 1) sw.WriteLine(drop1show.Text);
                if (i == 2) sw.WriteLine(drop2show.Text);
                if (i == 3) sw.WriteLine(drop3show.Text);
                if (i == 4) sw.WriteLine(drop4show.Text);
                if (i == 5) sw.WriteLine(drop5show.Text);
                if (i == 6) sw.WriteLine(drop6show.Text);
                if (i == 7) sw.WriteLine(drop7show.Text);
                if (i == 8) sw.WriteLine(drop8show.Text);
                if (i == 9) sw.WriteLine(drop9show.Text);
                if (i == 10) sw.WriteLine(drop10show.Text);
            }
            sw.Flush(); sw.Close(); readzombieshow.Items.Clear(); startit(); zombiemark.Text = "";
            MessageBox.Show("添加成功!");
        }
        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
        }

    }
}
