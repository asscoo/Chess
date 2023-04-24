using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Chess.Classes
{
    public class Figure
    {
        public Image image;
        int size;
        public Figure(string imagePath, int size)
        {
            this.size = size;
            image = new Image();
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            imageSource.EndInit();
            image.Width = size;
            image.Height = size;
            image.Stretch = Stretch.Fill;
            image.Source = imageSource;
        }
    }
}
