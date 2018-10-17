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
    /// Lógica de interacción para ProyectS.xaml
    /// </summary>
    public partial class ProyectS : UserControl
    {
        public ProyectS()
        {
            InitializeComponent();
        }
        private void Abrir_NuevoProyecto(object sender, RoutedEventArgs e)
        {

        }

        private void Abrir_Limpiar(object sender, RoutedEventArgs e)
        {
            TextBoxCodigo.Clear();
            TextBoxNombre.Clear();
            TextBoxID.Text = "";
            TextBoxEmpresa.Clear();
            TextCara.Clear();
            nEstado.Text = "";
            tModulo.Text = "";

        }

   
        private void Abrir_Cancelar(object sender, RoutedEventArgs e)
        {
            Menu_Soporte Menu = new Menu_Soporte();
            Menu.Show();
            Window ProyectS = (Window)((System.Windows.Controls.Grid)this.Parent).Parent;
            ProyectS.Close();
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
