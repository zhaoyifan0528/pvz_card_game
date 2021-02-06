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
    public partial class addthing2:Window
    {
        public addthing2()
        {
            InitializeComponent(); 
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string road = "data/warehouse_prop/" + nowmark.Text + "/";
            readclass.write_string(road + "name.txt", name.Text);
            readclass.write_string(road + "number.txt", number.Text);
            readclass.write_string(road + "price.txt", price.Text);
           
            MessageBox.Show("添加成功");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (nowmark.Text == "") return;
            string road = "data/warehouse_prop/" + nowmark.Text + "/";
            name.Text = readclass.read_string(road + "name.txt");
            number.Text = readclass.read_string(road + "number.txt");
            price.Text = readclass.read_string(road + "price.txt");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            number.Text = "";
            price.Text = "";
        }
    }
}
