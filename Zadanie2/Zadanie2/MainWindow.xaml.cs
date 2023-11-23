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

namespace Zadanie2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Box1.Text, out double L))
            { MessageBox.Show("Поле только для чисел"); }
            double p = 3.14, R, S;
            R = L / p * 2;
            S = p * Math.Pow(R, 2);
            Block1.Text += "Радиус равен = " + R + "\n";
            Block1.Text += "Площадь круга  равна = " + S ;

        }
    }
}
