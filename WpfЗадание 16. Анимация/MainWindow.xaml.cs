using System;
using System.IO;
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

namespace WpfЗадание_16.Анимация
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

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    DoubleAnimation doubleAnimation = new DoubleAnimation();
        //    //doubleAnimation.From = 150;
        //    doubleAnimation.To = 300;
        //    //doubleAnimation.By = 10;
        //    doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(3));
        //    //doubleAnimation.RepeatBehavior = new RepeatBehavior(2);
        //    //doubleAnimation.AccelerationRatio = 0.8;
        //    //doubleAnimation.SpeedRatio = 0.5;
        //    doubleAnimation.AutoReverse = true;
        //    Btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
        //    Btn.BeginAnimation(Button.HeightProperty, doubleAnimation);
            
        //    ColorAnimation colorAnimation = new ColorAnimation();
        //    colorAnimation.From = Colors.Yellow;
        //    colorAnimation.To = Colors.DeepSkyBlue;
        //    colorAnimation.Duration = TimeSpan.FromSeconds(3);
        //    Btn.Background = new SolidColorBrush(Colors.PapayaWhip);
        //    Btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);


        //}

        //private void Ellipse_MouseUp(object sender, MouseButtonEventArgs e)
        //{

        //}
    }
}
