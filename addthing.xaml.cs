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
    public partial class addthing:Window
    {
        public addthing()
        {
            InitializeComponent(); 
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string road = "data/plant_ill/" + nowmark.Text + "/";
            readclass.write_string(road + "name.txt", name.Text);
            readclass.write_string(road + "attritube.txt", attritube.Text);
            readclass.write_string(road + "material.txt", material.Text);
            readclass.write_string(road + "starlevel.txt", star.Text);
            readclass.write_string(road + "mingrowth.txt", ming.Text);
            readclass.write_string(road + "maxgrowth.txt", maxg.Text);
            readclass.write_string(road + "target1mark.txt", mark1.Text);
            readclass.write_string(road + "target2mark.txt", mark2.Text);
            readclass.write_string(road + "target1dollar.txt", do1.Text);
            readclass.write_string(road + "target2dollar.txt", do2.Text);
            readclass.write_string(road + "target1lv.txt", lv1.Text);
            readclass.write_string(road + "target2lv.txt", lv2.Text);
            MessageBox.Show("添加成功");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (nowmark.Text == "") return;
            string road = "data/plant_ill/" + nowmark.Text + "/";
            name.Text = readclass.read_string(road + "name.txt");
            attritube.Text = readclass.read_string(road + "attritube.txt");
            material.Text = readclass.read_string(road + "material.txt");
            star.Text = readclass.read_string(road + "starlevel.txt");
            ming.Text = readclass.read_string(road + "mingrowth.txt");
            maxg.Text = readclass.read_string(road + "maxgrowth.txt");
            mark1.Text = readclass.read_string(road + "target1mark.txt");
            mark2.Text = readclass.read_string(road + "target2mark.txt");
            do1.Text = readclass.read_string(road + "target1dollar.txt");
            do2.Text = readclass.read_string(road + "target2dollar.txt");
            lv1.Text = readclass.read_string(road + "target1lv.txt");
            lv2.Text = readclass.read_string(road + "target2lv.txt");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            attritube.Text = "";
            material.Text = "";
            star.Text = "";
            ming.Text = "";
            maxg.Text = "";
            mark1.Text = "";
            mark2.Text = "";
            do1.Text = "";
            do2.Text = "";
            lv1.Text = "";
            lv2.Text = "";
        }
    }
}
