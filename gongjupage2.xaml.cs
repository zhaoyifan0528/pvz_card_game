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
    public partial class gongjupage2:Page
    {
        
        public gongjupage2()
        {
            InitializeComponent();startit();
        }
        private void emptytext()
        {
            levelshow.Text = "";growthshow.Text = "";qualityshow.SelectedItem = null;
        }
        public void startit()
        {
            DirectoryInfo folder = new DirectoryInfo("data/plant_ill");
            foreach (DirectoryInfo file in folder.GetDirectories())
            {
                readplantshow.Items.Add(file.Name);
            }
            for(double now = 1.0;now < 1.66;now = now+0.05)
            {
                qualityshow.Items.Add(system.qualityword(now));
            }
        }
        string mark; string road;
        private void readplantshow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readplantshow.SelectedItem == null) return;
            mark = readplantshow.SelectedItem.ToString(); road = "data/plant_ill/" + mark + "/";
            nameshow.Text = readclass.read_string(road + "name.txt");
        }

        private void emptybutton_Click(object sender, RoutedEventArgs e)
        {
            emptytext();
        }

        private void writebutton_Click(object sender, RoutedEventArgs e)
        {
            if (readplantshow.SelectedItem == null || qualityshow.SelectedItem == null) {MessageBox.Show("请添加编号和品质"); return; }
            if(levelshow.Text ==""||growthshow.Text =="") { MessageBox.Show("请添加等级和成长"); return; }
            sure.Visibility = Visibility.Visible;
            no.Visibility = Visibility.Visible; makesure.Visibility = Visibility.Visible;
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
            readclass.write_int("data/warehouse_plant_number.txt", readclass.read_int("data/warehouse_plant_number.txt") + 1);
            int pos = readclass.read_int("data/warehouse_plant_number.txt");
            if (!Directory.Exists("data/warehouse_plant/" + pos.ToString()))
            {
                Directory.CreateDirectory("data/warehouse_plant/" + pos.ToString());
            }

            MainWindow.mymain_interface.warehouse_plant[++MainWindow.mymain_interface.plant_number] = pos;
            string road2 = "data/warehouse_plant/" + pos.ToString() + "/";
            readclass.write_int(road2 + "exist.txt", 1); readclass.write_int(road2 + "exp.txt", 0);
            readclass.write_string(road2 + "growth.txt", growthshow.Text);
            readclass.write_string(road2 + "level.txt", levelshow.Text);
            readclass.write_string(road2 + "mark.txt", mark);
            readclass.write_int(road2 + "lifadd.txt",0 );
            readclass.write_int(road2 + "attadd.txt", 0);
            readclass.write_int(road2 + "armadd.txt", 0);
            readclass.write_int(road2 + "thradd.txt", 0);
            readclass.write_double(road2 + "quality.txt", system.qualitynumber(qualityshow.SelectedItem.ToString()));
            MessageBox.Show("添加成功!");
        }
        private void no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Visibility = Visibility.Hidden;
            no.Visibility = Visibility.Hidden; makesure.Visibility = Visibility.Hidden;
        }

    }
}
