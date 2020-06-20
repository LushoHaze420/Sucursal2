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
    /// Lógica de interacción para MenuBoleta.xaml
    /// </summary>
    public partial class MenuBoleta : Window
    {
        public MenuBoleta()
        {
            InitializeComponent();
        }

        private void btnvolverboleta_Click(object sender, RoutedEventArgs e)
        {
            Menu nuevaventana = new Menu();
            nuevaventana.Show();
            this.Hide();
        }
    }
}
