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

namespace SistemaSucursal.Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, RoutedEventArgs e)
        {
            if ((txtusuario.Text != "") && (txtclave.Password != ""))
            {
                if ((txtusuario.Text == "admin") && (txtclave.Password == "123"))
                {

                    Administrador nuevaventana = new Administrador();
                    nuevaventana.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("error en usuario o contraseña");
                }
            }
            else
            {
                MessageBox.Show("error ingrese datos");
            }

            if ((txtusuario.Text != "") && (txtclave.Password != ""))
            {
                if ((txtusuario.Text == "vendedor") && (txtclave.Password == "123"))
                {

                    Menu nuevaventana = new Menu();
                    nuevaventana.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("error en usuario o contraseña");
                }
            }
            else
            {
                MessageBox.Show("error ingrese datos");
            }
        }
    }
}
