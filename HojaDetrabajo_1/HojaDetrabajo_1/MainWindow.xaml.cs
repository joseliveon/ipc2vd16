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
            int valor1 = int.Parse(textBox.Text.ToString());
            int valor2 = int.Parse(txtdos.Text.ToString());
            double r = descuento(valor1, valor2);
            MessageBox.Show("El resultado del descuento es : " + r);
        }

        private void suma_Click(object sender, RoutedEventArgs e)
        {
            int valor1 = int.Parse(textBox.Text.ToString());
            int valor2 = int.Parse(txtdos.Text.ToString());
            int r = promedio(valor1, valor2);
            MessageBox.Show("El resultado del promedio es : " + r);
        }

        private void resta_Click(object sender, RoutedEventArgs e)
        {
            int valor1 = int.Parse(textBox.Text.ToString());
            int valor2 = int.Parse(txtdos.Text.ToString());
            double r = iva(valor1, valor2);
            MessageBox.Show("El resultado del iva es : " + r + " 201504231");
        }

        public int potencia(int x, int y) {
            int r;
            for (int i = 0; i < y-1; i++) {
                x = x * x;
            }
            
            return x;

        }
        public int promedio(int x, int y)
        {
            int r;
            r = (x + y) / 2;

            return r;

        }
        public double descuento(int x, int y)
        {
            int r = 0;
            int descuento = x * (y/100);
            r = x - descuento;
           

            return descuento;
        }
        public double iva(int x, int y)
        {
            int r = 0;
            int iva = x * (y / 100);
            r = x + iva;

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
