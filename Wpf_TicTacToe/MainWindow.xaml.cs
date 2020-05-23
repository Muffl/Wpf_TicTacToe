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

namespace Wpf_TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmd1_1_Click(object sender, RoutedEventArgs e)
        {
            // Anzeige des 1ten Buttons invertieren 
            var jetzBackgr = cmd1_1.Background;
            cmd1_1.Background = cmd1_1.Foreground;
            cmd1_1.Foreground = jetzBackgr;
           
        }
    }
}
