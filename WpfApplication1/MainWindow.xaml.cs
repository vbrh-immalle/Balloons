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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rndGen = new Random();
        List<Balloon> balloons = new List<Balloon>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeBalloons();
        }

        private void InitializeBalloons()
        {
            canvas.Children.Clear();
            balloons.Clear();
            for(var i = 0; i<100; i++)
            {
                Balloon newBalloon = new Balloon(canvas, 
                        rndGen.Next(10, 50), 
                        rndGen.Next(300),
                        rndGen.Next(300)
                    );

                if(i % 3 == 0)
                {
                    newBalloon.Background = Brushes.Blue;
                }

                balloons.Add(newBalloon);
            }
        }

        private void initButton_Click(object sender, RoutedEventArgs e)
        {
            InitializeBalloons();
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(var b in balloons)
            {
                b.Grow();
            }
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var b in balloons)
            {
                b.Move();
            }
        }
    }
}
