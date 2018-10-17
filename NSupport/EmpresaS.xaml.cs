using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
    /// Lógica de interacción para EmpresaS.xaml
    /// </summary>
    public partial class EmpresaS : UserControl
    {
        public EmpresaS()
        {
            InitializeComponent();
        }

        private void Abrir_NuevaEmpresa(object sender, RoutedEventArgs e)
        {

        }

        private void Abrir_Limpiar(object sender, RoutedEventArgs e)
        {
            TextBoxCodigo.Clear();
            TextBoxNombre.Clear();
            TextBoxID.Text = "";
            TextContrato.Clear();
            TextTelefono.Clear();
            TextEmail.Clear();
            TextEmpre.Clear(); 
            TextAgente.Clear();
           

        }

        private void Abrir_Cancelar(object sender, RoutedEventArgs e)
        {
            Menu_Soporte Menu = new Menu_Soporte();
            Menu.Show();
            Window EmpresaS = (Window)((System.Windows.Controls.Grid)this.Parent).Parent;
            EmpresaS.Close();
        }
        private void Abrir_Buscar(object sender, RoutedEventArgs e)
        {

        }
        private void Abrir_Guardar(object sender, RoutedEventArgs e)
        {

        }
    }
}

