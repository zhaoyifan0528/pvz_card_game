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
    public partial class loading : Page
    {
        public loading()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Hidden;
            nowis.Text = "正在加载中";
            nowstep.Text = "检验是否为新用户";
            if(!sql.mess_exist(MainWindow.mymain_interface.id))
            {
                nowstep.Text = "检验为新用户";
                nowstep.AppendText("开始创建基本信息");
                sql.mess_insert_kong(MainWindow.mymain_interface.id.ToString());
                nowstep.Text = "开始创建植物信息";
                int now_allmark = sql.get_plat_mark();
                sql.sqlsolve("INSERT INTO PLANT VALUES(" + MainWindow.mymain_interface.id.ToString() + ",1,1,0,1.0,0,0,0,0,3,"+(now_allmark + 1).ToString()+")");
                sql.sqlsolve("INSERT INTO PLANT VALUES(" + MainWindow.mymain_interface.id.ToString() + ",109,1,0,1.0,0,0,0,0,3," +( now_allmark+2).ToString() + ")");
                sql.sqlsolve("INSERT INTO PLANT VALUES(" + MainWindow.mymain_interface.id.ToString() + ",163,1,0,1.0,0,0,0,0,5," + (now_allmark + 3).ToString() + ")");
                sql.get_plat_mark_add(now_allmark + 3);
                nowstep.Text = "开始创建道具信息信息";
                sql.sqlsolve("INSERT INTO  PROP(MARK) VALUES(" + MainWindow.mymain_interface.id.ToString()+")");
                nowstep.Text = "账户信息创建完毕";
                MessageBox.Show("首次运行成功");
            }
            nowstep.Text = "开始读取基本信息";
            sql.get_mess();
            nowstep.Text = "开始读取仓库植物信息";
            sql.get_plant();
            nowstep.Text = "开始读取仓库道具信息";
            sql.get_prop();
            system.alldollarfresh();
            system.solve_peo_exp();
            MainWindow.mymain_interface.frame2.Visibility = Visibility.Hidden;
        }
    }
}