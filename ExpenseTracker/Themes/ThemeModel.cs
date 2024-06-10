using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExpenseTracker.Themes
{
    public enum Theme
    {
        Dark,
        Light
    }

    class ThemeModel
    {
        public Theme CurrentTheme { get; set; }
        public void ChangeTheme()
        {
            CurrentTheme = CurrentTheme == Theme.Dark ? Theme.Light : Theme.Dark;

            App.Current.Resources.Clear();
            ResourceDictionary theme;

            if (CurrentTheme == Theme.Dark)
            {
                theme = new ResourceDictionary()
                {
                    Source = new Uri("Themes/Dark.xaml", UriKind.Relative)
                };
            }
            else
            {
                theme = new ResourceDictionary()
                {
                    Source = new Uri("Themes/Dark.xaml", UriKind.Relative)
                };
            }
            App.Current.Resources.MergedDictionaries.Add(theme);
        }
    }
}
