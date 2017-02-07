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
        Balloon b1;
        Balloon b2;
        Balloon b3;

        public MainWindow()
        {
            InitializeComponent();

            b1 = new Balloon(canvas);
            b2 = new Balloon(canvas);
            b3 = new Balloon(canvas);
        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            b1.Grow();
            b2.Grow();
            b3.Grow();
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            b1.Move();
            b2.Move();
            b3.Move();
        }
    }
}
