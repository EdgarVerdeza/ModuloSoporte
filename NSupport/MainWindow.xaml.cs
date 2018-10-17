using System;
using System.Collections.Generic;
using System.Data;
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

namespace NSupport
{
 
    public partial class MainWindow : Window
    {
       public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Coneccion con = new Coneccion();
                string Select = "select * from SoUsuario where UserName='" + Usuario.Text + "' AND Password='" + Clave.Password + "' ";
                SqlConnection myConnection = con.GetConecction();

                using (SqlCommand command = new SqlCommand(Select, myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Menu_Soporte Menu = new Menu_Soporte();
                            Menu.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña no validos");
                        }
                        reader.Close();
                    }
                    myConnection.Close();
                }


            }
            catch (Exception w)
            {
                MessageBox.Show("error al consultar:"+w);
            }
            
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }                
}
