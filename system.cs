using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using System.Threading;
using System.Configuration;
using System.Data;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace game_2
{
    class system
    {
        public static void solve_peo_exp()
        {
            int exp = MainWindow.mymain_interface.peo_exp, lv = MainWindow.mymain_interface.peo_level;
            while(exp >= readclass.peoexp[lv])
            {
                exp -= readclass.peoexp[lv]; lv++;
            }
            MainWindow.mymain_interface.peo_exp = exp;
            MainWindow.mymain_interface.peo_level = lv;
            sql.update_exp();sql.update_lv();
            MainWindow.mymain_interface.lvshow.Text = "LV." + lv.ToString();
            MainWindow.mymain_interface.expshow.Text = exp.ToString()+"/"+readclass.peoexp[lv].ToString();
            system.picmove(0, 0, (int)((double)(exp /(double)readclass.peoexp[lv]) * 212), 0, MainWindow.mymain_interface.exppic,0);
        }
        public static void dong()
        {
            MainWindow.mymain_interface.dong.Source = new Uri(Environment.CurrentDirectory + "\\music/低沉咚.mp3");
            MainWindow.mymain_interface.dong.Volume = 100; MainWindow.mymain_interface.dong.Play();
        }
        public static void lingdang()
        {
            MainWindow.mymain_interface.lingdang.Source = new Uri(Environment.CurrentDirectory + "\\music/清脆铃铛.mp3");
            MainWindow.mymain_interface.lingdang.Volume = 100; MainWindow.mymain_interface.lingdang.Play();
        }
        public static void jiangli()
        {
            MainWindow.mymain_interface.jiangli.Source = new Uri(Environment.CurrentDirectory + "\\music/奖励音效.mp3");
            MainWindow.mymain_interface.jiangli.Volume = 100; MainWindow.mymain_interface.jiangli.Play();
        }
        public static void muban()
        {
            MainWindow.mymain_interface.muban.Source = new Uri(Environment.CurrentDirectory + "\\music/砰击木板音效.mp3");
            MainWindow.mymain_interface.muban.Volume = 100; MainWindow.mymain_interface.muban.Play();
        }
        public static void jiangshi()
        {
            MainWindow.mymain_interface.jiangshi.Source = new Uri(Environment.CurrentDirectory + "\\music/僵尸叫.mp3");
            MainWindow.mymain_interface.jiangshi.Volume = 100; MainWindow.mymain_interface.jiangshi.Play();
        }
        public static void daji()
        {
            MainWindow.mymain_interface.daji.Source = new Uri(Environment.CurrentDirectory + "\\music/8打击音效.mp3");
            MainWindow.mymain_interface.daji.Volume = 100; MainWindow.mymain_interface.daji.Play();
        }
        public static void getsun()
        {
            MainWindow.mymain_interface.getsun.Source = new Uri(Environment.CurrentDirectory + "\\music/points.mp3");
            MainWindow.mymain_interface.getsun.Volume = 100; MainWindow.mymain_interface.getsun.Play();
        }
        public static void putback()
        {
            MainWindow.mymain_interface.putback.Source = new Uri(Environment.CurrentDirectory + "\\music/plant_back.mp3");
            MainWindow.mymain_interface.putback.Volume = 100; MainWindow.mymain_interface.putback.Play();
        }
        public static void putplant()
        {
            MainWindow.mymain_interface.putplant.Source = new Uri(Environment.CurrentDirectory + "\\music/plant.mp3");
            MainWindow.mymain_interface.putplant.Volume = 100; MainWindow.mymain_interface.putplant.Play();
        }
        public static void shovel()
        {
            MainWindow.mymain_interface.shovel.Source = new Uri(Environment.CurrentDirectory + "\\music/shovel.mp3");
            MainWindow.mymain_interface.shovel.Volume = 100; MainWindow.mymain_interface.shovel.Play();
        }
        public static void getplant()
        {
            MainWindow.mymain_interface.getplant.Source = new Uri(Environment.CurrentDirectory + "\\music/拿起植物音效.mp3");
            MainWindow.mymain_interface.getplant.Volume = 100; MainWindow.mymain_interface.getplant.Play();
        }
        public static void readyput()
        {
            MainWindow.mymain_interface.readyput.Source = new Uri(Environment.CurrentDirectory + "\\music/readysetplant.mp3");
            MainWindow.mymain_interface.readyput.Volume = 100; MainWindow.mymain_interface.readyput.Play();
        }
        public static void gomain()
        {
            MainWindow.mymain_interface.gomain.Source = new Uri(Environment.CurrentDirectory + "\\music/gravebutton.mp3");
            MainWindow.mymain_interface.gomain.Volume = 100; MainWindow.mymain_interface.gomain.Play();
        }
        public static void zombiecom()
        {
            MainWindow.mymain_interface.zombiecom.Source = new Uri(Environment.CurrentDirectory + "\\music/awooga.mp3");
            MainWindow.mymain_interface.zombiecom.Volume = 100; MainWindow.mymain_interface.zombiecom.Play();
        }
        public static void shoop()
        {
            MainWindow.mymain_interface.shoop.Source = new Uri(Environment.CurrentDirectory + "\\music/shoop.mp3");
            MainWindow.mymain_interface.shoop.Volume = 100; MainWindow.mymain_interface.shoop.Play();
        }
        public static void splat1()
        {
            MainWindow.mymain_interface.splat1.Source = new Uri(Environment.CurrentDirectory + "\\music/splat1.mp3");
            MainWindow.mymain_interface.splat1.Volume = 100; MainWindow.mymain_interface.splat1.Play();
        }
        public static void splat2()
        {
            MainWindow.mymain_interface.splat2.Source = new Uri(Environment.CurrentDirectory + "\\music/splat2.mp3");
            MainWindow.mymain_interface.splat2.Volume = 100; MainWindow.mymain_interface.splat2.Play();
        }
        public static void splat3()
        {
            MainWindow.mymain_interface.splat3.Source = new Uri(Environment.CurrentDirectory + "\\music/splat3.mp3");
            MainWindow.mymain_interface.splat3.Volume = 100; MainWindow.mymain_interface.splat3.Play();
        }
        public static void pause()
        {
            MainWindow.mymain_interface.pause.Source = new Uri(Environment.CurrentDirectory + "\\music/pause.mp3");
            MainWindow.mymain_interface.pause.Volume = 100; MainWindow.mymain_interface.pause.Play();
        }
        public static void winmusic()
        {
            MainWindow.mymain_interface.lastmusic.Source = new Uri(Environment.CurrentDirectory + "\\music/winmusic.mp3");
            MainWindow.mymain_interface.lastmusic.Volume = 100; MainWindow.mymain_interface.lastmusic.Play();
        }
        public static void losemusic()
        {
            MainWindow.mymain_interface.lastmusic.Source = new Uri(Environment.CurrentDirectory + "\\music/losemusic.mp3");
            MainWindow.mymain_interface.lastmusic.Volume = 100; MainWindow.mymain_interface.lastmusic.Play();
        }
        public static void buzzer()
        {
            MainWindow.mymain_interface.buzzer.Source = new Uri(Environment.CurrentDirectory + "\\music/buzzer.mp3");
            MainWindow.mymain_interface.buzzer.Volume = 100; MainWindow.mymain_interface.buzzer.Play();
        }
        public static void back_game()
        {
            MainWindow.mymain_interface.back_game.Source = new Uri(Environment.CurrentDirectory + "\\music/back_game.mp3");
            MainWindow.mymain_interface.back_game.Volume = 100; MainWindow.mymain_interface.back_game.Play();
        }
        public static void pvzmusic()
        {
            MainWindow.mymain_interface.pvzmusic.Source = new Uri(Environment.CurrentDirectory + "\\music/back_music.mp3");
            MainWindow.mymain_interface.pvzmusic.Volume = 100;
            MainWindow.mymain_interface.pvzmusic.MediaEnded += (sender, e) =>
            {//播放结束后 又重新播放
                MainWindow.mymain_interface.pvzmusic.Position = new TimeSpan(0);

            };
            MainWindow.mymain_interface.pvzmusic.Play();
        }
        
        public static void money()
        {
            MainWindow.mymain_interface.money.Source = new Uri(Environment.CurrentDirectory + "\\music/钱币音效.mp3");
            MainWindow.mymain_interface.money.Volume = 100; MainWindow.mymain_interface.money.Play();
        }
        public static void getgif(MediaElement sm,string road)
        {
            sm.Source = new Uri(Environment.CurrentDirectory + "\\"+road);
            sm.Volume = 100;sm.Play();
        }
        public static void alldollarfresh()
        {
            MainWindow.mynormalshop.moneyshow.Content = MainWindow.mymain_interface.peo_dollar.ToString();
            MainWindow.mysupershop.moneyshow.Content = MainWindow.mymain_interface.prop_number[123].ToString();
            MainWindow.mymain_interface.moneyshow.Text = MainWindow.mymain_interface.peo_dollar.ToString();
            MainWindow.mymain_interface.quanshow.Text = MainWindow.mymain_interface.prop_number[123].ToString();
            MainWindow.myzombie1.moneyshow.Text = MainWindow.mymain_interface.peo_dollar.ToString();
            MainWindow.myzombie1.quanshow.Text = MainWindow.mymain_interface.prop_number[123].ToString();
        }
        public static string qualityword(double a)
        {
            if (a < 1.01) return "劣质";
            else if (a < 1.06) return "普通";
            else if (a < 1.11) return "优秀";
            else if (a < 1.16) return "精良";
            else if (a < 1.21) return "极品";
            else if (a < 1.26) return "史诗";
            else if (a < 1.31) return "传说";
            else if (a < 1.36) return "神器";
            else if (a < 1.41) return "魔王";
            else if (a < 1.46) return "战神";
            else if (a < 1.51) return "至尊";
            else if (a < 1.56) return "魔神";
            else if (a < 1.61) return "耀世";
            else if (a < 1.66) return "不朽";
            else if (a < 1.71) return "永恒";
            else if (a < 1.76) return "太上";
            else if (a < 1.81) return "混沌";
             return "无极";
        }
        public static double qualitynumber(string a)
        {
            if (a == "劣质") return 1.0;
            else if (a == "普通") return 1.05;
            else if (a == "优秀") return 1.1;
            else if (a == "精良") return 1.15;
            else if (a == "极品") return 1.2;
            else if (a == "史诗") return 1.25;
            else if (a == "传说") return 1.3;
            else if (a == "神器") return 1.35;
            else if (a == "魔王") return 1.4;
            else if (a == "战神") return 1.45;
            else if (a == "至尊") return 1.5;
            else if (a == "魔神") return 1.55;
            else if (a == "耀世") return 1.6;
            else if (a == "不朽") return 1.65;
            else if (a == "永恒") return 1.7;
            else if (a == "太上") return 1.75;
            else if (a == "混沌") return 1.8;
            return 1.85;
        }                 
        public static void picmove(int stxpos, int stypos, int movex, int movey, Image img, double time)
        {                 
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.Duration = new Duration
                (TimeSpan.FromSeconds(time));

            TranslateTransform transform = new TranslateTransform();
            img.RenderTransform = transform;
            transform.X = stxpos;

            doubleAnimation.To = movex;
            transform.Y = stypos;


            transform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
            doubleAnimation.To = movey;
            transform.BeginAnimation(TranslateTransform.YProperty, doubleAnimation);
        }
        public void picmove2(int stxpos, int stypos, int movex, int movey, Image img, double time)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.Duration = new Duration
                (TimeSpan.FromSeconds(time));

            TranslateTransform transform = new TranslateTransform();
            img.RenderTransform = transform;
            transform.X = stxpos;

            doubleAnimation.To = movex;
            transform.Y = stypos;


            transform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
            doubleAnimation.To = movey;
            transform.BeginAnimation(TranslateTransform.YProperty, doubleAnimation);
        }
        public partial class App : Application
        {
            private static DispatcherOperationCallback exitFrameCallback = new DispatcherOperationCallback(ExitFrame);
            public static void DoEvents()
            {
                DispatcherFrame nestedFrame = new DispatcherFrame();
                DispatcherOperation exitOperation = Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background, exitFrameCallback, nestedFrame);
                Dispatcher.PushFrame(nestedFrame);
                if (exitOperation.Status !=
                DispatcherOperationStatus.Completed)
                {
                    exitOperation.Abort();
                }
            }
            public static void Delay(int mm)
            {
                DateTime current = DateTime.Now;
                while (current.AddMilliseconds(mm) > DateTime.Now)
                {
                    DoEvents();
                }
                return;
            }

            private static Object ExitFrame(Object state)
            {
                DispatcherFrame frame = state as
                DispatcherFrame;
                frame.Continue = false;
                return null;
            }
            

        }
    }
}
