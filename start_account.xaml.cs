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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace game_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class start_account : Window
    {
       
        public start_account()
        {
            InitializeComponent();
        }
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex re = new Regex("[^0-9]");

            e.Handled = re.IsMatch(e.Text);

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.Parse(account_show.Text);int.Parse(password_show.Password);
            if (sql.account_verification(account_show.Text, password_show.Password) != 0)
            {
                MainWindow a = new MainWindow();
                a.id = sql.account_verification(account_show.Text, password_show.Password);
                a.transmit_id();
                a.Show(); this.Close();
            }
            else MessageBox.Show("账号或者密码错误");
        }

        private void zhuce_Click(object sender, RoutedEventArgs e)
        {
            if (account_show.Text == "" || password_show.Password == "")
            {
                MessageBox.Show("不可为空"); return;
            }
            int.Parse(account_show.Text); int.Parse(password_show.Password);
            if(sql.account_exist(account_show.Text.ToString()) == 1)
            {
                MessageBox.Show("账号已存在"); return;
            }
            if(account_show.Text.Length < 6||account_show.Text.Length > 15)
            {
                MessageBox.Show("账号应当为6-15位纯数字");return;
            }
            if (password_show.Password.Length > 8)
            {
                MessageBox.Show("密码应当为8位内纯数字"); ; return;
            }
            sql.account_register(account_show.Text, password_show.Password);
            MessageBox.Show("恭喜您已注册成功");
        }
    }
}
