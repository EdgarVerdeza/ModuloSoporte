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

namespace NSupport
{
    /// <summary>
    /// Lógica de interacción para ContratoS.xaml
    /// </summary>
    public partial class ContratoS : UserControl
    {
        public ContratoS()
        {
            InitializeComponent();
        }

        private void Abrir_NuevaContrato(object sender, RoutedEventArgs e)
        {

        }

        private void Abrir_Limpiar(object sender, RoutedEventArgs e)
        {

        }

        private void Abrir_Cancelar(object sender, RoutedEventArgs e)
        {
            Menu_Soporte Menu = new Menu_Soporte();
            Menu.Show();
            Window ContratoS = (Window)((System.Windows.Controls.Grid)this.Parent).Parent;
            ContratoS.Close();
            //Close();
        }
        private void Abrir_Buscar(object sender, RoutedEventArgs e)
        {

        }
        private void Abrir_Guardar(object sender, RoutedEventArgs e)
        {

        }
    }
}
