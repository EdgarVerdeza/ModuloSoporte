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
    /// Lógica de interacción para SeguimientoS.xaml
    /// </summary>
    public partial class SeguimientoS : UserControl
    {
        public SeguimientoS()
        {
            InitializeComponent();
        }
        private void Abrir_NuevoCaso(object sender, RoutedEventArgs e)
        {


        //    TextBoxCodigo.Text = GenerateRandom();
        //    // TextBoxCodigo.IsReadOnly = false;

        //    TextBoxNombre.Focus();
        //    TextBoxNombre.IsReadOnly = false;
        //    Fecha_final.IsEnabled = true;
        //    Textcontact.IsReadOnly = false;
        //    TextEmpre.IsReadOnly = false;
        //    TextAgente.IsReadOnly = false;
        //    Textcoderror.IsReadOnly = false;
        }

        private void Abrir_Limpiar(object sender, RoutedEventArgs e)
        {
        //    TextBoxCodigo.Clear();
        //    TextBoxNombre.Clear();
        //    TextBoxID.Text = "";
        //    //TextFecha_final.Clear();
        //    Textcontact.Clear();
        //    TextEmpre.Clear();
        //    TextAgente.Clear();
        //    Textcoderror.Clear();
        //    TextNomError.Clear();
        //    Textsol.Clear();
        }

        private void Abrir_Cancelar(object sender, RoutedEventArgs e)
        {
            Menu_Soporte Menu = new Menu_Soporte();
            Menu.Show();
            Window CCasos = (Window)((System.Windows.Controls.Grid)this.Parent).Parent;
            CCasos.Close();
            //Close();
        }

        private void Abrir_Buscar(object sender, RoutedEventArgs e)
        {
            BusquedaS bus = new BusquedaS();
            bus.Show();
        }
      private void Abrir_Guardar(object sender, RoutedEventArgs e)
        {
        //    DateTime dt1 = Convert.ToDateTime(TextFecha.Text);
        //    DateTime dt2 = Convert.ToDateTime(Fecha_final.Text);
        //    if (dt1 > dt2)
        //    {
        //        MessageBox.Show("Seleccione una fecha mayor");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Todo Bien");
      }

        private void Menu_btnVis_Click(object sender, RoutedEventArgs e)
        {
            if (Menu.Visibility == Visibility.Visible)
            {
                Menu.Visibility = Visibility.Collapsed;
            }
            else
            {
                Menu.Visibility = Visibility.Visible;
            }
        }
    }
}

