using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Brush = System.Windows.Media.Brush;
using MediaColor = System.Windows.Media.Color;
using DrawingColor = System.Drawing.Color;

namespace LoginPage
{
    /// <summary>
    /// Interaction logic for AnimatedTextBox.xaml
    /// </summary>
    public partial class AnimatedTextBox : UserControl
    {
        public AnimatedTextBox()
        {
            InitializeComponent();
        }

        public double AnimatedTextBoxBorderRadius
        {
            get => roundedRectangle.RadiusX;
            set => roundedRectangle.RadiusX = roundedRectangle.RadiusY = value;
        }
        
        public char AnimatedTextBoxPassChar
        {
            get => animatedPassChar;
            set
            {
                if(Convert.ToString(value) != "")
                {
                    animatedPassChar = value;
                }
            }
        }

        public object AnimatedTextBoxPlaceHolder
        {
            get => placeHolder.Content;
            set => placeHolder.Content = value;
        }

        public double AnimatedTextBoxFontSize
        {
            get => mainTextBox.FontSize;
            set
            {
                mainTextBox.FontSize = placeHolder.FontSize = viewPassLabel.FontSize = value;
            }
        }

        public Brush AnimatedTextBoxBackground
        {
            get => mainTextBox.Background;
            set => mainTextBox.Background = placeHolder.Background = value;
        }

        public Brush AnimatedTextBoxForeground
        {
            get => mainTextBox.Foreground;
            set
            {
                if (value != null)
                {
                    roundedRectangle.Stroke = mainTextBox.Foreground = placeHolder.Foreground = viewPassLabel.Foreground = value;
                }
            }
        }

        public bool IsPasswordType
        {
            get; set;
        }

        private char animatedPassChar = '●';
        private string password;

        private void MainTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (mainTextBox.Text == "")
            {
                double top = -(ActualHeight);
                ThicknessAnimation animation1 = new ThicknessAnimation
                {
                    From = placeHolder.Margin,
                    To = new Thickness(20, top, 0, 0),
                    Duration = new Duration(TimeSpan.FromMilliseconds(300))
                };

                DoubleAnimation animation2 = new DoubleAnimation
                {
                    From = placeHolder.FontSize,
                    To = 20,
                    Duration = new Duration(TimeSpan.FromMilliseconds(300))
                };

                placeHolder.BeginAnimation(MarginProperty, animation1);
                placeHolder.BeginAnimation(FontSizeProperty, animation2);
            }
        }

        private void MainTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mainTextBox.Text == "")
            {
                double top = (ActualHeight);
                ThicknessAnimation animation1 = new ThicknessAnimation
                {
                    From = placeHolder.Margin,
                    To = new Thickness(20, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromMilliseconds(300))
                };

                DoubleAnimation animation2 = new DoubleAnimation
                {
                    From = placeHolder.FontSize,
                    To = AnimatedTextBoxFontSize,
                    Duration = new Duration(TimeSpan.FromMilliseconds(300))
                };

                placeHolder.BeginAnimation(MarginProperty, animation1);
                placeHolder.BeginAnimation(FontSizeProperty, animation2);
            }
        }

        private void PlaceHolder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainTextBox.Focus();
        }

        private void PasswordTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (IsPasswordType)
            {
                password += e.Text;
                mainTextBox.Text += animatedPassChar;
                mainTextBox.CaretIndex = mainTextBox.Text.Length;
                e.Handled = true;
            }
        }

        private void PasswordTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsPasswordType && e.Key == Key.Back && mainTextBox.Text.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                mainTextBox.Text = mainTextBox.Text.Substring(0, mainTextBox.Text.Length - 1);
                mainTextBox.CaretIndex = mainTextBox.Text.Length;
                e.Handled = true;
            }
        }
    }
}
