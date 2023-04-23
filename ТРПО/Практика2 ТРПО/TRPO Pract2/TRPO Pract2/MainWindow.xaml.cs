using System;
using System.Collections.Generic;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TRPO_Pract2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();       

        }
        private void Image_Down(object sender, MouseButtonEventArgs e)
        {
            Image image=e.Source as Image;
            DataObject data = new DataObject(typeof(ImageSource), image.Source);
            DragDrop.DoDragDrop(image, data, DragDropEffects.Copy);
        }


        private void holst_Drop(object sender, DragEventArgs e)
        {
            ImageSource image=e.Data.GetData(typeof(ImageSource)) as ImageSource;
            Image imageControl = new Image()
            {
                Width = 50,
                Height= 50,
                Source= image
            };
            Canvas.SetLeft(imageControl, e.GetPosition(this.holst_canvas).X);
            Canvas.SetTop(imageControl, e.GetPosition(this.holst_canvas).Y);
            this.holst_canvas.Children.Add(imageControl);
        }


        private void comboBoxSelectImage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            string path1 = null;
           
            switch (cBox.SelectedIndex)
            {
                case 0: path1 = "C:\\Users\\kamam\\Desktop\\ТРПО\\Практика2 ТРПО\\TRPO Pract2\\TRPO Pract2\\image\\Заготовительный цех.png"; break;
                case 1: path1 = "C:\\Users\\kamam\\Desktop\\ТРПО\\Практика2 ТРПО\\TRPO Pract2\\TRPO Pract2\\image\\Механический цех.png"; break;
                case 2: path1 = "C:\\Users\\kamam\\Desktop\\ТРПО\\Практика2 ТРПО\\TRPO Pract2\\TRPO Pract2\\image\\Покрасочный цех.png"; break;
                case 3: path1 = "C:\\Users\\kamam\\Desktop\\ТРПО\\Практика2 ТРПО\\TRPO Pract2\\TRPO Pract2\\image\\Сборочный цех.png"; break;
                case 4: path1 = "C:\\Users\\kamam\\Desktop\\ТРПО\\Практика2 ТРПО\\TRPO Pract2\\TRPO Pract2\\image\\Упаковочный цех.png"; break;
            }
            holst_canvas.Children.Clear();
            BitmapImage imageFille = new BitmapImage(new Uri(path1, UriKind.Absolute));
            Image ImageControl = new Image();
            ImageControl.Source = imageFille;
            holst_canvas.Children.Add(ImageControl);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveImage = new Microsoft.Win32.SaveFileDialog();
            Canvas canvas = new Canvas();
            saveImage.DefaultExt = ".PNG";
            saveImage.Filter = "Image (.PNG)|*.PNG";
            if (saveImage.ShowDialog() == true)
            {
                ToImageSource(holst_canvas, saveImage.FileName);
            }
        }

        public static void ToImageSource(Canvas canvas, string filename)
        {
            RenderTargetBitmap bmp = new RenderTargetBitmap((int)canvas.ActualWidth, (int)canvas.ActualHeight, 96d, 96d, PixelFormats.Pbgra32);
            canvas.Measure(new Size((int)canvas.ActualWidth, (int)canvas.ActualHeight));
            canvas.Arrange(new Rect(new Size((int)canvas.ActualWidth, (int)canvas.ActualHeight)));
            bmp.Render(canvas);
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            using (FileStream file = File.Create(filename))
            {
                encoder.Save(file);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            holst_canvas.Children.Clear();
        }
    }

}


