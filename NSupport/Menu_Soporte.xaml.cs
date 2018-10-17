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
using System.Windows.Shapes;

namespace NSupport
{
    /// <summary>
    /// Lógica de interacción para Menu_Soporte.xaml
    /// </summary>
    public partial class Menu_Soporte : Window
    {
        public Menu_Soporte()
        {
            InitializeComponent();
        }

        private void Abrir_Casos(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new CCasos());
        }

        private void Abrir_Empresas(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new EmpresaS());
        }

        private void Abrir_Errores(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new ErrorS());
        }

        private void Abrir_Proyects(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new ProyectS());
        }

        private void Abrir_Contrato(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new ContratoS());
        }

        private void Abrir_Seguimiento(object sender, RoutedEventArgs e)
        {
            ContentGrid.Children.Clear();
            ContentGrid.Children.Add(new SeguimientoS());
        }

        private void Abrir_Mercadeo(object sender, RoutedEventArgs e)
        {

        }
    }
}
