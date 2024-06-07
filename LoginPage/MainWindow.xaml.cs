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

namespace LoginPage
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

        private void OnDontHaveAccountClicked(object sender, MouseButtonEventArgs e)
        {
            Thickness destinationMargin = new Thickness(ActualWidth, 0, 0, 0);
            ThicknessAnimation animation1 = new ThicknessAnimation()
            {
                From = signInTemplateImage.Margin,
                To = destinationMargin,
                Duration = TimeSpan.FromMilliseconds(3000)
            };

            DoubleAnimation animation2 = new DoubleAnimation()
            {
                From = 500,
                To = ActualWidth,
                Duration = new Duration(TimeSpan.FromSeconds(2))
            };
            MainGrid.ColumnDefinitions[1].Width = new GridLength(0);
            //MainGrid.ColumnDefinitions[0].Width = new GridLength(ActualWidth);
            //signInTemplateImage.BeginAnimation(MarginProperty, animation1);
            //signInTemplateImage.BeginAnimation(OpacityProperty, animation2);
            G1.BeginAnimation(MarginProperty, animation1);
        }

        private void OnAlreadyHaveAccountClicked(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
