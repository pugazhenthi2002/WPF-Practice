using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
using System.Windows.Threading;

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

        public int AnimatedTextBoxFontSize
        {
            get => (int)placeHolderLabel.FontSize;
            set
            {
                placeHolderLabel.FontSize = mainTextBox.FontSize = value;
            }
        }

        public Brush AnimatedTextBoxBorderColor
        {
            get => borderRectangle.Stroke;
            set
            {
                placeHolderLabel.Foreground = borderRectangle.Stroke = mainTextBox.Foreground = value;
            }
        }

        public Brush AnimatedTextBoxBackColor
        {
            get => Background;
            set
            {
                placeHolderLabel.Background = Background = value;
            }
        }

        public int BorderRadius
        {
            get => Convert.ToInt32(borderRectangle.RadiusX);
            set
            {
                borderRectangle.RadiusX = borderRectangle.RadiusY = value;
                mainTextBox.Margin = new Thickness(value, value * 2, value * 2, value);
            }
        }

        public string PlaceHolderText
        {
            get
            {
                return placeHolderText;
            }

            set
            {
                placeHolderText = value;
                placeHolderLabel.Content = value;
            }
        }

        private string placeHolderText;

        private void OnAnimatedTextBoxGotFocused(object sender, RoutedEventArgs e)
        {
            if (mainTextBox.Text == "")
            {
                placeHolderLabel.FontSize = 12;
                AnimatePlaceHolder();
            }
        }

        private void OnAnimatedTextBoxLostFocused(object sender, RoutedEventArgs e)
        {
            if (mainTextBox.Text == "")
            {
                AnimatePlaceHolder();
                placeHolderLabel.FontSize = 24;
            }
        }

        private async void AnimatePlaceHolder()
        {
            double centerTop = 0; // Center position minus margin
            double targetTop = -((ActualHeight - placeHolderLabel.ActualHeight) / 2) - 20; // Target top margin

            double currentTop = !mainTextBox.IsFocused ? targetTop : centerTop;
            double newTop = !mainTextBox.IsFocused ? centerTop : targetTop;

            var thicknessAnimation = new ThicknessAnimation
            {
                From = new Thickness(placeHolderLabel.Margin.Left, currentTop, 0, 0),
                To = new Thickness(placeHolderLabel.Margin.Left, newTop, 0, 0),
                Duration = new Duration(TimeSpan.FromMilliseconds(300))
            };

            await AnimateAsync(placeHolderLabel, thicknessAnimation);
        }

        private Task AnimateAsync(UIElement element, AnimationTimeline animation)
        {
            var tcs = new TaskCompletionSource<bool>();

            if (animation == null)
                tcs.SetException(new ArgumentNullException(nameof(animation)));

            animation.Completed += (s, e) => tcs.SetResult(true);

            element.BeginAnimation(FrameworkElement.MarginProperty, animation);

            return tcs.Task;
        }
    }
}
