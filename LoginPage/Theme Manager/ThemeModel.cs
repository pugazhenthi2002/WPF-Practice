using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LoginPage.Theme_Manager
{
    public class ThemeModel
    {
        public ThemeModel()
        {
            ThemeCollection = new List<Theme>()
            {
                new Theme()
                {
                    PrimaryI = new SolidColorBrush(Colors.Red),
                    PrimaryII = new SolidColorBrush(Colors.Red),
                    SecondaryI = new SolidColorBrush(Colors.Red),
                    SecondaryII = new SolidColorBrush(Colors.Red)
                },
                new Theme()
                {
                    PrimaryI = new SolidColorBrush(Colors.Blue),
                    PrimaryII = new SolidColorBrush(Colors.Blue),
                    SecondaryI = new SolidColorBrush(Colors.Blue),
                    SecondaryII = new SolidColorBrush(Colors.Blue)
                }
            };

            CurrentTheme = ThemeCollection[0];
        }

        public List<Theme> ThemeCollection;
        public Theme CurrentTheme { get; set; }
    }
}
