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
    public partial class gongjupage1:Page
    {
        
        public gongjupage1()
        {
            InitializeComponent();
            startit();
        }
        private void emptytext()
        {
            markshow.Text = "";nameshow.Text = "";mingrshow.Text = "";maxgrshow.Text = "";
            levelshow.Text = "";attshow.Text = "";materialshow.Text = "";markshow.Text = "";
            target1doshow.Text = "";target1markshow.Text = "";target1lvshow.Text = "";
            target2doshow.Text = ""; target2markshow.Text = ""; target2lvshow.Text = "";
        }
        public void startit()
        {
            DirectoryInfo folder = new DirectoryInfo("data/plant_ill");
            foreach (DirectoryInfo file in folder.GetDirectories())
            {
                readplantshow.Items.Add(file.Name);
            }
        }

        private void readplantshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readplantshow.SelectedItem == null) return;
            string mark = readplantshow.SelectedItem.ToString();string road = "data/plant_ill/" + mark + "/";
            nameshow.Text = readclass.read_string(road + "name.txt");
            levelshow.Text = readclass.read_string(road + "starlevel.txt");
            materialshow.Text = readclass.read_string(road + "material.txt");
            mingrshow.Text = readclass.read_string(road + "mingrowth.txt");
            maxgrshow.Text = readclass.read_string(road + "maxgrowth.txt");
            attshow.Text = readclass.read_string(road + "attritube.txt");
            target1doshow.Text = readclass.read_string(road + "target1dollar.txt");
            target1lvshow.Text = readclass.read_string(road + "target1lv.txt");
            target1markshow.Text = readclass.read_string(road + "target1mark.txt");
            target2doshow.Text = readclass.read_string(road + "target2dollar.txt");
            target2lvshow.Text = readclass.read_string(road + "target2lv.txt");
            target2markshow.Text = readclass.read_string(road + "target2mark.txt");
        }

        private void emptybutton_Click(object sender, RoutedEventArgs e)
        {
            emptytext();
        }

        private void writebutton_Click(object sender, RoutedEventArgs e)
        {
            string mark = markshow.Text;
            if (!File.Exists("pic/plantpic/" + mark + ".png")) { MessageBox.Show("请先创建pic/plantpic/"+mark+".png");return; } 
            if(target1markshow.Text == ""||target2markshow.Text =="")
            {
                MessageBox.Show("目标植物编号为必填项，若无进化目标填入0");return;
            }
            if(nameshow.Text == ""||levelshow.Text ==""||attshow.Text==""||mingrshow.Text ==""||maxgrshow.Text==""||materialshow.Text=="")
            {
                MessageBox.Show("必填项为空"); return;
            }
            sure.Visibility = Visibility.Visible;
            no.Visibility = Visibility.Visible;makesure.Visibility = Visibility.Visible;
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
            string mark = markshow.Text;
            if (!Directory.Exists("data/plant_ill/" + mark))
            {
                Directory.CreateDirectory("data/plant_ill/" + mark);
            }
            string road = "data/plant_ill/" + mark + "/";
            readclass.write_string(road + "name.txt",nameshow.Text);
            readclass.write_string(road + "starlevel.txt",levelshow.Text);
            readclass.write_string(road + "material.txt",materialshow.Text);
            readclass.write_string(road + "mingrowth.txt",mingrshow.Text);
            readclass.write_string(road + "maxgrowth.txt",maxgrshow.Text);
            readclass.write_string(road + "attritube.txt",attshow.Text);
            readclass.write_string(road + "target1dollar.txt",target1doshow.Text);
            readclass.write_string(road + "target1lv.txt",target1lvshow.Text);
            readclass.write_string(road + "target1mark.txt",target1markshow.Text);
            readclass.write_string(road + "target2dollar.txt",target2doshow.Text);
            readclass.write_string(road + "target2lv.txt",target2lvshow.Text);
            readclass.write_string(road + "target2mark.txt",target2markshow.Text);
            readplantshow.Items.Clear();startit(); MessageBox.Show("添加成功!");markshow.Text = "";
        }
        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
        }
    
    }

   
}

