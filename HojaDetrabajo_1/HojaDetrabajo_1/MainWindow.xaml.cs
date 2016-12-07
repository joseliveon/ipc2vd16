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

namespace HojaDetrabajo_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            int valor1 = int.Parse(textBox.Text.ToString());
            int valor2 = int.Parse(txtdos.Text.ToString());
            int r = potencia(valor1, valor2);
            MessageBox.Show("El resultado de la potencia es : " + potencia(valor1,valor2));

        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void suma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resta_Click(object sender, RoutedEventArgs e)
        {

        }

        public int potencia(int x, int y) {
            int r;
            for (int i = 0; i < y-1; i++) {
                x = x * x;
            }
            
            return x;

        }
        public double descuento(int x, int y)
        {
            int r = 0;
            int descuento = x * (y/100);
           

            return r;
        }
        //public int suma(int x, int y)
        //{
        //    int r;
        //    r = x+y;
        //    return r;

        //}
        //public int resta(int x, int y)
        //{
        //    int r;
        //    r = x-y;
        //    return r;

        //}
    }
}
