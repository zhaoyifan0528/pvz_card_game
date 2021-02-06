using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class syn3 : Page
    {
        public syn3()
        {
            InitializeComponent();
           
            for (int i = 0;i<=10;++i)
            {
                lib[i] = 125 + i;if (i != 0) neednum[i] = 2;
                target[i] = i + 125 + 1;
            }
            neednum[0] = 15;surehid();
            updatemess();
        }
        public int libnumber = 11,select = 0;
        int[] lib = new int[11]; int[] neednum = new int[11]; int[] target = new int[11];
        private void close_MouseEnter(object sender, MouseEventArgs e)
        {
            closepic.Source = new ImageSourceConverter().ConvertFromString("pic/closebutton.png") as ImageSource;
        }
        private void close_MouseLeave(object sender, MouseEventArgs e)
        {
            closepic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
        }
        private void close_Mouseclick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
        }
        private void gotosyn1(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(new syn());
        }
        private void gotosyn2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(new syn2());
        }
        private void gotosyn3(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(new syn3());
        }
        private void gotosyn3page2(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(new syn3page2());
        }
        private int nowpage = 1;
        private void goforward(object sender, MouseButtonEventArgs e)
        {
            system.dong(); forwardbigpic.Visibility = Visibility.Hidden;
            if (nowpage == 1) return;
            nowpage--; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void gobackward(object sender, MouseButtonEventArgs e)
        {
            system.dong(); backwordbigpic.Visibility = Visibility.Hidden;
            nowpage++; updatemess(); pageshow.Text = nowpage.ToString();
        }

        private void forwardbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Visible;
        }

        private void forwardbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Hidden;
        }

        private void forwardbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            forwardbigpic.Visibility = Visibility.Visible;
        }

        private void backwardbutton_MouseEnter(object sender, MouseEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Visible;
        }

        private void backwardbutton_MouseLeave(object sender, MouseEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Hidden;
        }


        private void backwardbutton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            backwordbigpic.Visibility = Visibility.Visible;
        }
        
        private void emptypage()
        {
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos31pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos32pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos33pic.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            pos11lvshow.Text = ""; pos12lvshow.Text = ""; pos13lvshow.Text = ""; pos21lvshow.Text = "";
            pos22lvshow.Text = "";neednumbershow.Text = "";
            pos23lvshow.Text = ""; pos31lvshow.Text = ""; pos32lvshow.Text = ""; pos33lvshow.Text = "";
        }
        public void updatemess()
        {
            emptypage();allhidden();
            int nowpos = (nowpage - 1) * 9 + 1; int realtime;
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos11pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos11lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos12pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos12lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos13pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos13lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos21pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos21lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos22pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos22lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos23pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos23lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos31pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos31lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos32pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos32lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";
            if (find_mark_plant(nowpos) == -1) return;
            realtime = find_mark_plant(nowpos); nowpos++;
            pos33pic.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + realtime + ".png") as ImageSource;
            pos33lvshow.Text = MainWindow.mymain_interface.prop_number[realtime].ToString() + "个";

        }
        private int find_mark_plant(int findnumber)
        {
            int marknumber = 0, rem_answer = -1;
            for (int i = 0; i < libnumber; ++i)
            {
                //   if (readclass.read_int("data/warehouse_prop/" + lib[i].ToString() + "/number.txt") <= 0) continue;
                if (MainWindow.mymain_interface.prop_number[lib[i]] <= 0) continue;
                marknumber++;
                if (marknumber == findnumber) rem_answer = lib[i];
            }
            return rem_answer;
        }
        private int find_mark_plant2(int findnumber)
        {
            int marknumber = 0, rem_answer = -1;
            for (int i = 0; i < libnumber; ++i)
            {
                if (MainWindow.mymain_interface.prop_number[lib[i]] <= 0) continue;
                marknumber++;
                if (marknumber == findnumber) rem_answer = i;
            }
            return rem_answer;
        }
        public int duiflag = 0;
        private void picshow(int renum)
        {
            select = find_mark_plant2((nowpage - 1) * 9 + renum);
            if (select == -1) return;
            neednumbershow.Text = neednum[select].ToString();
            comematerial.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + lib[select].ToString() + ".png") as ImageSource;
            tomaterial.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + target[select].ToString() + ".png") as ImageSource;
            int nownumber = MainWindow.mymain_interface.prop_number[lib[select]];
            if(nownumber >= neednum[select])
            {
                dui1.Source = new ImageSourceConverter().ConvertFromString("pic/兑换.png") as ImageSource;
                duiflag = 0;
            }
            else
            {
                dui1.Source = new ImageSourceConverter().ConvertFromString("pic/syn3道具不足.png") as ImageSource;
                duiflag = 1;
            }
        }
        private void pos11pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();picshow(1);
        }
        private void pos12pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(2);
        }
        private void pos13pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(3);
        }
        private void pos21pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(4);
        }
        private void pos22pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(5);
        }
        private void pos23pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(6);
        }
        private void pos31pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(7);
        }
        private void pos32pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(8);
        }

       

      

        private void pos33pic_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); picshow(9);
        }

        private void gopage2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong(); MainWindow.mymain_interface.frame2.Navigate(new syn3page2());
        }

        private void dui1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (duiflag == 1) return;
            dui1.Source = new ImageSourceConverter().ConvertFromString("pic/兑换亮.png") as ImageSource;
        }

        private void dui1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (duiflag == 1) return;
            dui1.Source = new ImageSourceConverter().ConvertFromString("pic/兑换.png") as ImageSource;
        }

        private void dui1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (duiflag == 1) return;
            dui1.Source = new ImageSourceConverter().ConvertFromString("pic/兑换按.png") as ImageSource;
            system.dong();
        }
        private void surehid()
        {
            sureback.Visibility = Visibility.Hidden;buttonleft.Visibility = Visibility.Hidden;
            buttonright.Visibility = Visibility.Hidden;duinumbershow.Visibility = Visibility.Hidden;
            sure.Visibility = Visibility.Hidden; gun.Visibility = Visibility.Hidden;
            tomateragashow.Visibility = Visibility.Hidden;instructions.Visibility = Visibility.Hidden;
        }
        private void allhidden()
        {
            select = 0;neednumbershow.Text = "";
            comematerial.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
            tomaterial.Source = new ImageSourceConverter().ConvertFromString("pic/4949TOU.png") as ImageSource;
        }
        private void sureshow()
        {
            sureback.Visibility = Visibility.Visible; buttonleft.Visibility = Visibility.Visible;
            buttonright.Visibility = Visibility.Visible; duinumbershow.Visibility = Visibility.Visible;
            sure.Visibility = Visibility.Visible; gun.Visibility = Visibility.Visible;
            tomateragashow.Visibility = Visibility.Visible;duinumbershow.Text = "1";
            instructions.Visibility = Visibility.Visible;
            if(select != 0)
            {
                instructions.Text = "你确定要兑换" + readclass.read_string("data/warehouse_prop/" + target[select].ToString() + "/name.txt");
                tomateragashow.Source = new ImageSourceConverter().ConvertFromString("pic/prop/" + target[select].ToString() + ".png") as ImageSource;
            }
        }
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex re = new Regex("[^0-9]");

            e.Handled = re.IsMatch(e.Text);

        }

        private void buttonleft_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1亮3.png") as ImageSource;
        }

        private void buttonleft_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1.png") as ImageSource;
        }

        private void buttonleft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            buttonleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1按3.png") as ImageSource;
            system.dong();
            if (duinumbershow.Text == "1") return;
            duinumbershow.Text = (int.Parse(duinumbershow.Text) - 1).ToString();
        }

        private void buttonleft_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            buttonleft.Source = new ImageSourceConverter().ConvertFromString("pic/button1亮3.png") as ImageSource;
        }

        private void buttonright_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonright.Source = new ImageSourceConverter().ConvertFromString("pic/button2亮3.png") as ImageSource;
        }

        private void buttonright_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonright.Source = new ImageSourceConverter().ConvertFromString("pic/button2.png") as ImageSource;
        }

        private void buttonright_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            buttonright.Source = new ImageSourceConverter().ConvertFromString("pic/button2按3.png") as ImageSource;
            system.dong();
            if (int.Parse(duinumbershow.Text) == (int)(MainWindow.mymain_interface.prop_number[select])
                /(int)neednum[select]) return;
            duinumbershow.Text = (int.Parse(duinumbershow.Text) + 1).ToString();
        }

        private void buttonright_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            buttonright.Source = new ImageSourceConverter().ConvertFromString("pic/button2亮3.png") as ImageSource;
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
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定3按.png") as ImageSource;
        }

        private void sure_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            sure.Source = new ImageSourceConverter().ConvertFromString("pic/确定3亮.png") as ImageSource;
            if (int.Parse(duinumbershow.Text) > (int)(MainWindow.mymain_interface.prop_number[select])
                / (int)neednum[select]) return;
            int lessnum = int.Parse(duinumbershow.Text);
            string road1 = "data/warehouse_prop/" + lib[select].ToString() + "/number.txt";
            string road2 = "data/warehouse_prop/" + target[select].ToString() + "/number.txt";
            MainWindow.mymain_interface.prop_number[lib[select]] -= neednum[select] * lessnum;
            MainWindow.mymain_interface.prop_number[target[select]] += lessnum;
            sql.sql_add_prop(lib[select]); sql.sql_add_prop(target[select]);
            system.jiangli();
            surehid();updatemess();
        }

        private void gun_MouseEnter(object sender, MouseEventArgs e)
        {
            gun.Source = new ImageSourceConverter().ConvertFromString("pic/取消4亮.png") as ImageSource;
        }

        private void gun_MouseLeave(object sender, MouseEventArgs e)
        {
            gun.Source = new ImageSourceConverter().ConvertFromString("pic/取消4.png") as ImageSource;
        }

        private void gun_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gun.Source = new ImageSourceConverter().ConvertFromString("pic/取消4按.png") as ImageSource;
        }

        private void gun_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            gun.Source = new ImageSourceConverter().ConvertFromString("pic/取消4亮.png") as ImageSource;
            system.dong();surehid();
        }

        private void comematerial_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            system.dong();allhidden();
        }

        private void comematerial_MouseEnter(object sender, MouseEventArgs e)
        {
            if (select == 0) return;
            prop_smdetail a = new prop_smdetail(); a.pos = lib[select]; a.updatemess();
            prop1detail.Visibility = Visibility.Visible; prop1detail.Navigate(a);
        }

        private void comematerial_MouseLeave(object sender, MouseEventArgs e)
        {
            prop1detail.Visibility = Visibility.Hidden;
        }

        private void tomaterial_MouseEnter(object sender, MouseEventArgs e)
        {
            if (select == 0) return;
            prop_smdetail a = new prop_smdetail(); a.pos = target[select]; a.updatemess();
            prop2detail.Visibility = Visibility.Visible; prop2detail.Navigate(a);
        }

        private void tomaterial_MouseLeave(object sender, MouseEventArgs e)
        {
            prop2detail.Visibility = Visibility.Hidden;
        }

        private void dui1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (duiflag == 1) return;
            dui1.Source = new ImageSourceConverter().ConvertFromString("pic/兑换亮.png") as ImageSource;
            if(select != 0) sureshow();
        }
    }
}
