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
    /// Interaction logic for SideBarMenu.xaml
    /// </summary>
    public partial class SideBarMenu : UserControl
    {
        public SideBarMenu()
        {
            InitializeComponent();
           // menuBarImage.Visibility = Visibility.Collapsed;
        }

        //Dependency Properties
        #region

        public static readonly DependencyProperty HeaderImageSourcePropertyProperty =
            DependencyProperty.Register("MenuBarImageSource", typeof(ImageSource), typeof(SideBarMenu), new PropertyMetadata(null));

        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(SideBarMenu), new PropertyMetadata("Header"));

        public static readonly DependencyProperty ChildItemsProperty =
            DependencyProperty.Register("ChildItems", typeof(List<string>), typeof(SideBarMenu), new PropertyMetadata(new List<string>()));

        public static readonly DependencyProperty HeaderFontFamilyProperty =
            DependencyProperty.Register("HeaderFontFamily", typeof(FontFamily), typeof(SideBarMenu), new PropertyMetadata(new FontFamily("Ebrima")));

        public static readonly DependencyProperty HeaderFontSizeProperty =
            DependencyProperty.Register("HeaderFontSize", typeof(double), typeof(SideBarMenu), new PropertyMetadata());

        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.Register("HeaderBackground", typeof(Brush), typeof(SideBarMenu), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0, 0, 0))));

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.Register("HeaderForeground", typeof(Brush), typeof(SideBarMenu), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0, 0, 0))));

        public static readonly DependencyProperty ChildForegroundProperty =
            DependencyProperty.Register("ChildForeground", typeof(Brush), typeof(SideBarMenu), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(4, 4, 4))));

        public static readonly DependencyProperty ChildFontFamilyProperty =
            DependencyProperty.Register("ChildFontFamily", typeof(FontFamily), typeof(SideBarMenu), new PropertyMetadata(new FontFamily("Ebrima")));

        public static readonly DependencyProperty ChildFontSizeProperty =
            DependencyProperty.Register("ChildFontSize", typeof(double), typeof(SideBarMenu), new PropertyMetadata());

        public static readonly DependencyProperty ChildBackgroundProperty =
            DependencyProperty.Register("ChildBackground", typeof(Brush), typeof(SideBarMenu), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0, 0, 0))));

        #endregion

        //Properties
        #region
        public ImageSource MenuBarImageSource
        {
            get
            {
                //return menuBarImage.Source;
                return (ImageSource)GetValue(HeaderImageSourcePropertyProperty);
            }
            set
            {
                if (value != null)
                {
                    menuBarImage.Visibility = Visibility.Visible;
                    //menuBarImage.Source = value;
                    SetValue(HeaderImageSourcePropertyProperty, value);
                }
                else
                {
                    menuBarImage.Visibility = Visibility.Collapsed;
                }
            }
        }

        public FontFamily HeaderFontFamily
        {
            get { return (FontFamily)GetValue(HeaderFontFamilyProperty); }
            set { SetValue(HeaderFontFamilyProperty, value); }
        }

        public double HeaderFontSize
        {
            get { return (double)GetValue(HeaderFontSizeProperty); }
            set { SetValue(HeaderFontSizeProperty, value); }
        }

        public Brush HeaderForeground
        {
            get { return (Brush)GetValue(HeaderForegroundProperty); }
            set { SetValue(HeaderForegroundProperty, value); }
        }

        public Brush HeaderBackground
        {
            get { return (Brush)GetValue(HeaderBackgroundProperty); }
            set { SetValue(HeaderForegroundProperty, value); }
        }

        public FontFamily ChildFontFamily
        {
            get { return (FontFamily)GetValue(ChildFontFamilyProperty); }
            set { SetValue(ChildFontFamilyProperty, value); }
        }

        public double ChildFontSize
        {
            get { return (double)GetValue(ChildFontSizeProperty); }
            set { SetValue(ChildFontSizeProperty, value); }
        }

        public Brush ChildForeground
        {
            get { return (Brush)GetValue(ChildForegroundProperty); }
            set { SetValue(ChildForegroundProperty, value); }
        }

        public Brush ChildBackground
        {
            get { return (Brush)GetValue(ChildBackgroundProperty); }
            set { SetValue(ChildItemsProperty, value); }
        }

        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        public List<string> ChildItems
        {
            get { return (List<string>)GetValue(ChildItemsProperty); }
            set { SetValue(ChildItemsProperty, value); }
        }

        #endregion
        
        private void OnSliderMenuClicked(object sender, RoutedEventArgs e)
        {
            if (itemsControl.Visibility == Visibility.Collapsed)
            {
                itemsControl.Visibility = Visibility.Visible;
            }
            else
            {
                itemsControl.Visibility = Visibility.Collapsed;
            }
        }
    }
}
