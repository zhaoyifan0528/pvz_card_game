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
    public partial class gongjupage6:Page
    {
        
        public gongjupage6()
        {
            InitializeComponent();startit(); emptytext1();emptytext2();
            int nprop = readclass.read_int("data/prop_number.txt");
            for(int i=1;i<=nprop;++i)
            {
                propselect1.Items.Add(i); propselect2.Items.Add(i);
            }
            nprop = readclass.read_int("data/box_number.txt");
            for (int i = 1; i <= nprop; ++i)
            {
                propselect1.Items.Add((i+900).ToString()); propselect2.Items.Add((i + 900).ToString());
            }
        }
        private void emptytext1()
        {
            propselect1.SelectedItem = null;price1.Text = "";propname1.Text = "";
        }
        private void emptytext2()
        {
            propselect2.SelectedItem = null; price2.Text = ""; propname2.Text = "";
        }
        public void startit()
        {
            readshopshow1.Items.Clear();
            int num = readclass.read_int("data/normalshop_number.txt");
            for(int i = 1;i <= num;++i)
            {
                readshopshow1.Items.Add(i.ToString());
            }
            readshopshow2.Items.Clear();
            num = readclass.read_int("data/supershop_number.txt");
            for (int i = 1; i <= num; ++i)
            {
                readshopshow2.Items.Add(i.ToString());
            }
        }
        private void readplantshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readshopshow1.SelectedItem == null) return;emptytext1();
            string road2 = "data/normalshop/" + readshopshow1.SelectedItem.ToString() + "/";
            propselect1.Text = readclass.read_string(road2 + "mark.txt");
            int mark = readclass.read_int(road2 + "mark.txt");
            propname1.Text = readclass.read_string("data/warehouse_prop/" + mark.ToString() + "/name.txt");
            price1.Text = readclass.read_string(road2 + "price.txt");
        }
        private void readplantshow_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            if (readshopshow2.SelectedItem == null) return; emptytext2();
            string road2 = "data/supershop/" + readshopshow2.SelectedItem.ToString() + "/";
            propselect2.Text = readclass.read_string(road2 + "mark.txt");
            int mark = readclass.read_int(road2 + "mark.txt");
            propname2.Text = readclass.read_string("data/warehouse_prop/" + mark.ToString() + "/name.txt");
            price2.Text = readclass.read_string(road2 + "price.txt");
        }
        public int se = 0;
        private void writebutton_Click1(object sender, RoutedEventArgs e)
        {
            if(posshow1.Text == ""||int.Parse(posshow1.Text) > (readclass.read_int("data/normalshop_number.txt") + 1))
            {
                MessageBox.Show("编号错误");return;
            }
            if(price1.Text==""||propselect1.Text=="")
            {
                MessageBox.Show("必填项为空");return;
            }
            se = 1;
            sure.Visibility = Visibility.Visible;
            no.Visibility = Visibility.Visible; makesure.Visibility = Visibility.Visible;
        }
        private void writebutton_Click2(object sender, RoutedEventArgs e)
        {
            if (posshow2.Text == "" || int.Parse(posshow2.Text) > (readclass.read_int("data/supershop_number.txt") + 1))
            {
                MessageBox.Show("编号错误"); return;
            }
            if (price2.Text == "" || propselect2.Text == "")
            {
                MessageBox.Show("必填项为空"); return;
            }
            se = 2;
            sure.Visibility = Visibility.Visible;
            no.Visibility = Visibility.Visible; makesure.Visibility = Visibility.Visible;
        }
        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;int pos;string road2;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
            if(se == 1)
            {
                pos = int.Parse(posshow1.Text);road2 = "data/normalshop/" + pos.ToString() + "/";
                if (!Directory.Exists("data/normalshop/" + pos.ToString()))
                {
                    readclass.write_int("data/normalshop_number.txt", readclass.read_int("data/normalshop_number.txt") + 1);
                    Directory.CreateDirectory("data/normalshop/" + pos.ToString());
                }
                readclass.write_string(road2 + "mark.txt", propselect1.Text);
                readclass.write_string(road2 + "price.txt", price1.Text);
                posshow1.Text = "";
            }
            else
            {
                pos = int.Parse(posshow2.Text); road2 = "data/supershop/" + pos.ToString() + "/";
                if (!Directory.Exists("data/supershop/" + pos.ToString()))
                {
                    readclass.write_int("data/supershop_number.txt", readclass.read_int("data/supershop_number.txt") + 1);
                    Directory.CreateDirectory("data/supershop/" + pos.ToString());
                }
                readclass.write_string(road2 + "mark.txt", propselect2.Text);
                readclass.write_string(road2 + "price.txt", price2.Text);
                posshow2.Text = "";
            }
            startit();MessageBox.Show("添加成功");
        }
        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
        }

        private void propselect1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (propselect1.SelectedItem == null) return;
            int mark = int.Parse(propselect1.SelectedItem.ToString());
            propname1.Text = readclass.read_string("data/warehouse_prop/" + mark.ToString() + "/name.txt");
        }

        private void propselect2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (propselect2.SelectedItem == null) return;
            int mark = int.Parse(propselect2.SelectedItem.ToString());
            propname2.Text = readclass.read_string("data/warehouse_prop/" + mark.ToString() + "/name.txt");
        }

        private void emptybutton1_Click(object sender, RoutedEventArgs e)
        {
            emptytext1();
        }

        private void emptybutton2_Click(object sender, RoutedEventArgs e)
        {
            emptytext2();
        }
    }
}
