using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class pvz_select: Page
    {
        public double diff = 1;
        public pvz_select()
        {
            InitializeComponent();
            instruction.Text = "难度越高，僵尸血量越多，刷新速度越快，植物产生的阳光越少\n向日葵妹妹一系产出阳光，阳光值和攻击呈正比\n" +
                 "其他植物发射子弹，攻击影响子弹伤害\n\n1.08版本僵尸不会对植物造成伤害";
        }
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex re = new Regex("[^0-9]");

            e.Handled = re.IsMatch(e.Text);

        }
        private void sure_MouseEnter(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定3亮.png") as ImageSource;
        }

        private void sure_MouseLeave(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定3.png") as ImageSource;
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定3按.png") as ImageSource;
            nowdiff.Text = "当前难度：" + writediff.Text;
            diff = double.Parse(writediff.Text);
        }

        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定3亮.png") as ImageSource;
        }
    }
}
