using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    public partial class prop_smdetail: Page
    {



        public int pos = 0;
        public prop_smdetail()
        {
            InitializeComponent();updatemess();
        }
        public void updatemess()
        {
            if (pos == 0) return;
            drop.Text = readclass.read_string("data/warehouse_prop/" + pos.ToString() + "/instructions.txt");
        }
    }
}
