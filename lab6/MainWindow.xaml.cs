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

namespace Multimedia_Lab6
{
    public partial class MainWindow : Window
    {
        private readonly List<DoubleAnimation> _transparencyAnimation = new List<DoubleAnimation>();
        private readonly List<ColorAnimation> _colorAnimation = new List<ColorAnimation>();
        private readonly List<DoubleAnimation> _sizeAnimation = new List<DoubleAnimation>();
        private readonly List<DoubleAnimation> _rotateAnimation = new List<DoubleAnimation>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowAnimation_Button(object sender, RoutedEventArgs e)
        {
            DoubleAnimation tAnimation = null, sAnimation = null, rAnimation = null;
            ColorAnimation cAnimation = null;

            if (ComboBox1.SelectedIndex > -1 && ComboBox1.SelectedIndex < _transparencyAnimation.Count)
                tAnimation = _transparencyAnimation[ComboBox1.SelectedIndex];

            if (ComboBox2.SelectedIndex > -1 && ComboBox2.SelectedIndex < this._colorAnimation.Count)
                cAnimation = _colorAnimation[ComboBox2.SelectedIndex];

            if (ComboBox3.SelectedIndex > -1 && ComboBox3.SelectedIndex < this._sizeAnimation.Count)
                sAnimation = _sizeAnimation[ComboBox3.SelectedIndex];

            if (ComboBox4.SelectedIndex > -1 && ComboBox4.SelectedIndex < this._rotateAnimation.Count)
                rAnimation = _rotateAnimation[ComboBox4.SelectedIndex];

            var AnimatedMessage = new AnimatedMessage(tAnimation, cAnimation, rAnimation, sAnimation);
            AnimatedMessage.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da;
            da = new DoubleAnimation(0.1, 1, new Duration(TimeSpan.FromSeconds(1)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _transparencyAnimation.Add(da);
            da = new DoubleAnimation(0.1, 1, new Duration(TimeSpan.FromSeconds(2)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _transparencyAnimation.Add(da);
            da = new DoubleAnimation(0.5, 1, new Duration(TimeSpan.FromSeconds(1)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _transparencyAnimation.Add(da);
            da = new DoubleAnimation(0.5, 1, new Duration(TimeSpan.FromSeconds(2)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _transparencyAnimation.Add(da);

            da = new DoubleAnimation(0.5, 1, new Duration(TimeSpan.FromSeconds(2)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _transparencyAnimation.Add(da);

            ColorAnimation ca;
            ca = new ColorAnimation(Colors.White, Colors.Black, new Duration(TimeSpan.FromSeconds(10)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _colorAnimation.Add(ca);
            ca = new ColorAnimation(Colors.White, Colors.Chocolate, new Duration(TimeSpan.FromSeconds(5)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _colorAnimation.Add(ca);
            ca = new ColorAnimation(Colors.White, Colors.Olive, new Duration(TimeSpan.FromSeconds(5)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _colorAnimation.Add(ca);
            ca = new ColorAnimation(Colors.White, Colors.Red, new Duration(TimeSpan.FromSeconds(5)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _colorAnimation.Add(ca);
            ca = new ColorAnimation(Colors.Purple, Colors.Black, new Duration(TimeSpan.FromSeconds(10)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _colorAnimation.Add(ca);

            da = new DoubleAnimation(8, 22, new Duration(TimeSpan.FromSeconds(5)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _sizeAnimation.Add(da);
            da = new DoubleAnimation(8, 16, new Duration(TimeSpan.FromSeconds(3)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _sizeAnimation.Add(da);
            da = new DoubleAnimation(8, 18, new Duration(TimeSpan.FromSeconds(5)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _sizeAnimation.Add(da);
            da = new DoubleAnimation(8, 26, new Duration(TimeSpan.FromSeconds(3)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _sizeAnimation.Add(da);
            _sizeAnimation.Add(da);
            da = new DoubleAnimation(8, 20, new Duration(TimeSpan.FromSeconds(4)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            da = new DoubleAnimation(0, 80, new Duration(TimeSpan.FromSeconds(9)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _rotateAnimation.Add(da);
            da = new DoubleAnimation(0, 60, new Duration(TimeSpan.FromSeconds(6)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _rotateAnimation.Add(da);
            da = new DoubleAnimation(0, 360, new Duration(TimeSpan.FromSeconds(3)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _rotateAnimation.Add(da);
            da = new DoubleAnimation(0, 60, new Duration(TimeSpan.FromSeconds(9)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _rotateAnimation.Add(da);
            da = new DoubleAnimation(0, 180, new Duration(TimeSpan.FromSeconds(4)))
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            _rotateAnimation.Add(da);

            foreach (DoubleAnimation doubleAnimation in _transparencyAnimation)
            {
                var tb = new TextBox { Text = "Анімація прозорості", IsReadOnly = true };
                tb.BeginAnimation(OpacityProperty, doubleAnimation);
                ComboBox1.Items.Add(tb);
            }

            ComboBox1.Items.Add(new TextBox { Text = " Оберіть анімацію ", IsReadOnly = true });

            foreach (ColorAnimation colorAnimation in _colorAnimation)
            {
                var scb = new SolidColorBrush();
                var tb = new TextBox { Text = "Анімація кольору тексту", IsReadOnly = true, Foreground = scb };
                scb.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);
                ComboBox2.Items.Add(tb);
            }

            ComboBox2.Items.Add(new TextBox { Text = " Оберіть анімацію ", IsReadOnly = true });

            foreach (DoubleAnimation doubleAnimation in _sizeAnimation)
            {
                var tb = new TextBox { Text = "Анімація розміру тексту", IsReadOnly = true };
                tb.BeginAnimation(FontSizeProperty, doubleAnimation);
                ComboBox3.Items.Add(tb);
            }

            ComboBox3.Items.Add(new TextBox { Text = " Оберіть анімацію ", IsReadOnly = true });
            

            foreach (DoubleAnimation doubleAnimation in _rotateAnimation)
            {
                var rt = new RotateTransform();
                var tb = new TextBox { Text = "Анімація повороту тексту", IsReadOnly = true, RenderTransform = rt };
                rt.BeginAnimation(RotateTransform.AngleProperty, doubleAnimation);
                ComboBox4.Items.Add(tb);
            }

            ComboBox4.Items.Add(new TextBox { Text = " Оберіть анімацію ", IsReadOnly = true });
        }

        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            ComboBox1.Text = " ***** ";
            ComboBox2.Text = " ***** ";
            ComboBox3.Text = " ***** ";
            ComboBox4.Text = " ***** ";
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
