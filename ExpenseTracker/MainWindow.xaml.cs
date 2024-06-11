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

namespace ExpenseTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MenuItems1 = new List<string> { "Item 1", "Item 2", "Item 3" };
            MenuItems2 = new List<string> { "Item 4", "Item 5", "Item 6" };
            DataContext = this;
        }

        public List<string> MenuItems1 { get; set; }
        public List<string> MenuItems2 { get; set; }

        private void OnExpensesClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnCategoryClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
