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

namespace SistemaSucursal.Presentacion
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnboleta_Click(object sender, RoutedEventArgs e)
        {
            MenuBoleta nuevaventana = new MenuBoleta();
            nuevaventana.Show();
            this.Hide();
        }

        private void btnfactura_Click(object sender, RoutedEventArgs e)
        {
            MenuFactura nuevaventana = new MenuFactura();
            nuevaventana.Show();
            this.Hide();
        }

        private void btnsalirmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaventana = new MainWindow();
            nuevaventana.Show();
            this.Hide();
        }
    }
}
