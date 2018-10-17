using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Threading;

namespace NSupport
{
    /// <summary>
    /// Lógica de interacción para CCasos.xaml
    /// </summary>
    public partial class CCasos : UserControl
    {
        public CCasos()
        {
            InitializeComponent();
            DispatcherTimer disp = new DispatcherTimer();
            disp.Interval = TimeSpan.FromMilliseconds(1000);
            disp.Tick += Fecha;
            disp.Start();

            TextFecha.Text = DateTime.Now.ToString();
            //TextFecha_final.Text = DateTime.Now.ToString();
        }

        public void Fecha(object sender, EventArgs e)
        {
            //DateTime thisDay = DateTime.Today;
            //Fecha_final.Text = DateTime.Today("d");
            Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            //DateTime dt1 = Convert.ToDateTime(Fecha_final.Text);
            //DateTime dt2 = DateTime.Now;
            //if (dt1 < dt2)
            //{
            //    MessageBox.Show("Seleccione una fecha mayor");
            //}

        }
        public string GenerateRandom()
        {
            System.Random randomGenerate = new System.Random();
            System.String GenRandom = "";
            GenRandom = System.Convert.ToString(randomGenerate.Next(00000001, 99999999));
            return GenRandom.Substring(GenRandom.Length - 8, 8);
        }

        private void Abrir_NuevoCaso(object sender, RoutedEventArgs e)
        {

            try
            {
                Coneccion con = new Coneccion();
                string Select = " MAX(COD_casos) AS Casos FROM SoCasos' ";
                SqlConnection myConnection = con.GetConecction();
                using (SqlCommand command = new SqlCommand(Select, myConnection))
                {
                    myConnection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Seleccione una fecha mayor");
                            //Menu_Soporte Menu = new Menu_Soporte();
                            //Menu.Show();
                            ////Close();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fecha mayor");
                        }
                        reader.Close();
                    }
                    myConnection.Close();
                }
                //SELECT MAX(Price) AS LargestPrice FROM Products
            }
            catch
            {

            }


            TextBoxCodigo.Text = GenerateRandom();

            // TextBoxCodigo.IsReadOnly = false;

            TextBoxNombre.Focus();
            TextBoxNombre.IsReadOnly = false;
            Fecha_final.IsEnabled = true;
            Textcontact.IsReadOnly = false;
            TextEmpre.IsReadOnly = false;
            TextAgente.IsReadOnly = false;
            Textcoderror.IsReadOnly = false;
            TextRealiza.IsReadOnly = false;


        }

        private void Abrir_Limpiar(object sender, RoutedEventArgs e)
        {
            TextBoxCodigo.Clear();
            TextBoxNombre.Clear();
            TextBoxID.Text = "";
            //TextFecha_final.Clear();
            Textcontact.Clear();
            TextEmpre.Clear();
            TextAgente.Clear();
            Textcoderror.Clear();
            TextNomError.Clear();
            Textsol.Clear();
            TextRealiza.Clear();
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

        }
        private void Abrir_Guardar(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(TextFecha.Text);
            DateTime dt2 = Convert.ToDateTime(Fecha_final.Text);
            if (dt1 > dt2)
            {
                MessageBox.Show("Seleccione una fecha mayor");
            }
            else
            {
                MessageBox.Show("Todo Bien");
            }

        }
    }
}
