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
    public partial class gongjupage5:Page
    {
        
        public gongjupage5()
        {
            InitializeComponent();startit(); emptytext();
            speciesshow.Items.Add("植物宝箱");speciesshow.Items.Add("道具宝箱");
        }
        private void emptytext()
        {
            nameshow.Text = "";numbershow.Text = "";instructions.Text = "";plantmarkshow.Text = "";
            speciesshow.Text = "";prop1.Text = "";prop2.Text = "";propnumbershow.Text = "";
            prop3.Text = ""; prop4.Text = "";  prop5.Text = ""; prop6.Text = "";  prop7.Text = ""; prop8.Text = "";
            prop9.Text = ""; prop10.Text = "";  prop11.Text = ""; prop12.Text = "";  prop13.Text = ""; prop14.Text = "";
        }
        public void startit()
        {
            readboxshow.Items.Clear();
            int num = readclass.read_int("data/box_number.txt");
            for(int i = 1;i <= num;++i)
            {
                readboxshow.Items.Add((i+900).ToString());
            }
        }
        string mark; string road;
        private void readplantshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readboxshow.SelectedItem == null) return;emptytext();
            string road2 = "data/warehouse_prop/" + readboxshow.SelectedItem.ToString() + "/";
            nameshow.Text = readclass.read_string(road2 + "name.txt");
            numbershow.Text = readclass.read_string(road2 + "number.txt");
            instructions.Text = readclass.read_string(road2 + "instructions.txt");
            if(readclass.read_int(road2 + "species.txt") != 0)
            {
                speciesshow.Text = "植物宝箱";plantmarkshow.Text = readclass.read_string(road2 + "species.txt");
                return;
            }
            speciesshow.Text = "道具宝箱";
            StreamReader sr = new StreamReader(road2 + "drop_prop.txt", Encoding.Default);
            String line; line = sr.ReadLine();
            int ndrop = int.Parse(line);
            propnumbershow.Text = ndrop.ToString();
            if (ndrop == 0) return;
            for (int i = 1; i <= ndrop; ++i)
            {
                line = sr.ReadLine();
                if (i == 1) prop1.Text = line;
                if (i == 2) prop2.Text = line;
                if (i == 3) prop3.Text = line;
                if (i == 4) prop4.Text = line;
                if (i == 5) prop5.Text = line;
                if (i == 6) prop6.Text = line;
                if (i == 7) prop7.Text = line;
                if (i == 8) prop8.Text = line;
                if (i == 9) prop9.Text = line;
                if (i == 10) prop10.Text = line;
                if (i == 11) prop11.Text = line;
                if (i == 12) prop12.Text = line;
                if (i == 13) prop13.Text = line;
                if (i == 14) prop14.Text = line;
            }
            sr.Close();
        }

        private void emptybutton_Click(object sender, RoutedEventArgs e)
        {
            emptytext();
        }

        private void writebutton_Click(object sender, RoutedEventArgs e)
        {
            if(posshow.Text == ""||int.Parse(posshow.Text) > (readclass.read_int("data/box_number.txt") + 901))
            {
                MessageBox.Show("编号错误");return;
            }
            int pos = int.Parse(posshow.Text);
            if (!File.Exists("pic/prop/" + pos.ToString() + ".png"))
            { MessageBox.Show("请先创建pic/prop/" + pos.ToString() + ".png"); return; }
            if(nameshow.Text==""||numbershow.Text==""||speciesshow.Text=="")
            {
                MessageBox.Show("必填项为空");return;
            }
            if(plantmarkshow.Text==""&&propnumbershow.Text=="")
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
            int pos = int.Parse(posshow.Text);
            if (!Directory.Exists("data/warehouse_prop/" + pos.ToString()))
            {
                readclass.write_int("data/box_number.txt", readclass.read_int("data/box_number.txt") + 1);
                Directory.CreateDirectory("data/warehouse_prop/" + pos.ToString());
            }
            string road2 = "data/warehouse_prop/" + pos.ToString() + "/";
            readclass.write_string(road2 + "name.txt", nameshow.Text);
            readclass.write_string(road2 + "price.txt", "0");
            readclass.write_string(road2 + "number.txt", numbershow.Text);
            readclass.write_string(road2 + "instructions.txt", instructions.Text);
            if (!File.Exists(road2 + "getnumber.txt"))
            readclass.write_string(road2 + "getnumber.txt", "1");
            if (speciesshow.Text == "植物宝箱")
            {
                readclass.write_string(road2 + "species.txt",plantmarkshow.Text);
                readclass.write_string(road2 + "drop_prop.txt","0");
                startit(); MessageBox.Show("添加成功");return;
            }
            readclass.write_string(road2 + "species.txt", "0");
            int ndrop = int.Parse(propnumbershow.Text);
            StreamWriter sw = new StreamWriter(road2 + "drop_prop.txt");
            sw.WriteLine(ndrop);
            if (ndrop == 0)
            {
                sw.Flush(); sw.Close(); MessageBox.Show("添加成功!"); startit();posshow.Text = "";
                return;
            }
            for (int i = 1; i <= ndrop; ++i)
            {
                if (i == 1) sw.WriteLine(prop1.Text);
                if (i == 2) sw.WriteLine(prop2.Text);
                if (i == 3) sw.WriteLine(prop3.Text);
                if (i == 4) sw.WriteLine(prop4.Text);
                if (i == 5) sw.WriteLine(prop5.Text);
                if (i == 6) sw.WriteLine(prop6.Text);
                if (i == 7) sw.WriteLine(prop7.Text);
                if (i == 8) sw.WriteLine(prop8.Text);
                if (i == 9) sw.WriteLine(prop9.Text);
                if (i == 10) sw.WriteLine(prop10.Text);
                if (i == 11) sw.WriteLine(prop11.Text);
                if (i == 12) sw.WriteLine(prop12.Text);
                if (i == 13) sw.WriteLine(prop13.Text);
                if (i == 14) sw.WriteLine(prop14.Text);
            }
            sw.Flush(); sw.Close();
            startit();MessageBox.Show("添加成功"); posshow.Text = "";
        }
        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
        }

    }
}
