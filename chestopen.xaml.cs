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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class chestopen: Page
    {
        

        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            system.lingdang();
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
            MainWindow.mymain_interface.frame4.Visibility = Visibility.Hidden;
            MainWindow.mymain_interface.frame3.Visibility = Visibility.Hidden;
        }

        private void sure_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2按.jpg") as ImageSource;
        }

        private void sure_MouseLeave(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2.jpg") as ImageSource;
        }

        private void sure_MouseEnter(object sender, MouseEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定2亮.jpg") as ImageSource;
        }
        public int pos;
        public chestopen()
        {
            InitializeComponent();
        }
        private void allhidden()
        {
            drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop2pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop3pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop4pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop5pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop6pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop7pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            drop8pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            numbershow1.Text = ""; numbershow2.Text = ""; numbershow3.Text = ""; numbershow4.Text = "";
            numbershow5.Text = ""; numbershow6.Text = ""; numbershow7.Text = ""; numbershow8.Text = "";
        }
        private void propget()
        {
            Dictionary<int, int> chestthing = new Dictionary<int, int> { };chestthing.Clear();
            int allnumber = int.Parse(MainWindow.mychest_detail.sellnumber.Text);
            for (int i=1;i<=allnumber;++i)
            {
                int mark = readclass.read_many_int("data/warehouse_prop/" + pos.ToString() + "/drop_prop.txt");
                if (chestthing.ContainsKey(mark) == false)
                {
                    chestthing.Add(mark, 1);
                }
                else chestthing[mark]++;
                MainWindow.mymain_interface.prop_number[mark] +=  readclass.read_int("data/warehouse_prop/" + pos.ToString() + "/getnumber.txt");
                sql.sql_add_prop(mark);
            }
            int remark = 0;
            foreach (var item in chestthing)
            {
                remark++;
                if(remark == 1)
                {
                    drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow1.Text = item.Value.ToString();
                }
                if (remark == 2)
                {
                    drop2pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow2.Text = item.Value.ToString();
                }
                if (remark == 3)
                {
                    drop3pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow3.Text = item.Value.ToString();
                }
                if (remark == 4)
                {
                    drop4pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow4.Text = item.Value.ToString();
                }
                if (remark == 5)
                {
                    drop5pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow5.Text = item.Value.ToString();
                }
                if (remark == 6)
                {
                    drop6pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow6.Text = item.Value.ToString();
                }
                if (remark == 7)
                {
                    drop7pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow7.Text = item.Value.ToString();
                }
                if (remark == 8)
                {
                    drop8pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + item.Key.ToString() + ".png") as ImageSource;
                    numbershow8.Text = item.Value.ToString();
                }
            }

            MainWindow.myprop.updatemess();system.alldollarfresh();
        }
        private void plantget()
        {
            int mark = readclass.read_int("data/warehouse_prop/" + pos.ToString() + "/species.txt");
            MainWindow.mymain_interface.plantware[++MainWindow.mymain_interface.allnumber] = new myplant();
            int op = (new Random()).Next(readclass.read_int("data/plant_ill/" + mark.ToString() + "/mingrowth.txt"),
                readclass.read_int("data/plant_ill/" + mark.ToString() + "/maxgrowth.txt") + 1);
            int now_plantmark = sql.get_plat_mark();
            sql.sqlsolve("INSERT INTO PLANT VALUES(" + MainWindow.mymain_interface.id.ToString() + 
                ","+mark.ToString()+",1,0,1.0,0,0,0,0,"+op.ToString()+"," + (now_plantmark+ 1).ToString()  + ")");
            MainWindow.mymain_interface.plantware[MainWindow.mymain_interface.allnumber].update_mess(mark,1,0,1.0,0,0,0,0,op,now_plantmark + 1);
            sql.get_plat_mark_add(now_plantmark + 1);
            drop1pic.Source = new ImageSourceConverter().ConvertFromString("pic/plantpic/" + mark.ToString() + ".png") as ImageSource;
            MainWindow.mywarehouse.updatemess();
        }
        public void start_interface()
        {
            allhidden();
            if (readclass.read_int("data/warehouse_prop/" + pos.ToString() + "/species.txt") == 0)
                propget();
            else plantget();
        }
    }
}
