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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SistemaSucursal.Negocio;

namespace SistemaSucursal.Presentacion
{
    /// <summary>
    /// Lógica de interacción para Administrador.xaml
    /// </summary>
    public partial class Administrador : Window
    {
        static string constring = "Data Source = (localdb)\\servidor_duoc4 ; Initial Catalog = Grupo03 ; integrated security = true";
        SqlConnection conexion = new SqlConnection(constring);


        public Administrador()
        {
            InitializeComponent();
            FillDataGrid();
            combo();
        }
        private void combo()
        {
            conexion.Open();
            SqlCommand con = new SqlCommand("select id_sucursal,nombre_sucursal from SUCURSAL", conexion);
            SqlDataAdapter data = new SqlDataAdapter(con);
            DataSet ds = new DataSet();
            data.Fill(ds, "SUCURSAL");
            combosucu.ItemsSource = ds.Tables[0].DefaultView;
            combosucu.DisplayMemberPath = ds.Tables[0].Columns["nombre_sucursal"].ToString();
            combosucu.SelectedValuePath = ds.Tables[0].Columns["id_sucursal"].ToString();
            conexion.Close();

        }
        private void FillDataGrid()
        {
            conexion.Open();

            string con = "select * from VENDEDOR;";
            SqlCommand comando = new SqlCommand(con, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            listaview.ItemsSource = tabla.DefaultView;

            conexion.Close();

        }

        private void btnsalirvendedor_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaventana = new MainWindow();
            nuevaventana.Show();
            this.Hide();
        }

        private void btnsalirsucu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaventana = new MainWindow();
            nuevaventana.Show();
            this.Hide();
        }

        private void btnsaliradmin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaventana = new MainWindow();
            nuevaventana.Show();
            this.Hide();
        }

        private void btnsalirclave_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaventana = new MainWindow();
            nuevaventana.Show();
            this.Hide();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnagregravendedor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = 0;
                while (i == 0)
                {
                    Vendedor obj = new Vendedor()
                    {
                        rut_vendedor = txtrutvendedor.Text,
                        nombre_vendedor = txtnomvendedor.Text,
                        sexo_vendedor = txtsexovendedor.Text,
                        id_sucursal = Convert.ToInt32(combosucu.SelectedValue)

                    };

                    if (obj.agregar())
                    {
                        MessageBox.Show("Se agrego correctamente el vendedor");
                        txtrutvendedor.Text = "";
                        txtnomvendedor.Text = "";
                        txtsexovendedor.Text = "";
                        combosucu.SelectedValue = 0;


                        i++;

                    }
                    else
                    {
                        throw new ArgumentException("error en la conexion");

                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexion.Close();
        }

        private void btnactualizar1_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            try
            {
                //$=interpolar                
                string id_sucursal = combosucu.SelectedValue.ToString();
                string con = $"Update VENDEDOR set nombre_vendedor = '{txtnomvendedor.Text}',sexo_vendedor = '{txtsexovendedor.Text}',id_sucursal = '{id_sucursal}' where rut_vendedor = '{txtrutvendedor.Text}'";
                SqlCommand comando = new SqlCommand(con, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Actualizado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Actualizar");
            }



            conexion.Close();
        }

        private void btnrefrescarvendedor_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();

            string con = "select * from VENDEDOR;";
            SqlCommand comando = new SqlCommand(con, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            listaview.ItemsSource = tabla.DefaultView;

            conexion.Close();
        }

        private void btnagregaradmin_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Administrador obj2 = new Administrador()
            //    {
            //        rut_administrador = txtrutadmin.Text,
            //        nombre_administrador = txtnomadmin.Text,
            //        sexo_administrador = txtsexoadmin.Text,
            //        id_sucursal = Convert.ToInt32(combosucu.SelectedValue)

            //    };

            //    if (obj2.agregar())
            //    {
            //        MessageBox.Show("Se agrego correctamente el vendedor");
            //        txtrutadmin.Text = "";
            //        txtnomadmin.Text = "";
            //        txtsexoadmin.Text = "";
            //        combosucu.SelectedValue = 0;
            //    }
            //    else
            //    {
            //        throw new ArgumentException("no se pudo agregar administrador");

            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("error de conexion")
            //};
            //conexion.Close();
        }

        private void btnagregarsucu_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            try
            {
                Sucursal obj1 = new Sucursal()
                {
                    nombre_sucursal = txtsucursal.Text,
                    ciudad_sucursal = txtciudad.Text
                };

                if (obj1.agregar())

                {
                    MessageBox.Show("Se agrego correctamente la sucursal");
                    txtsucursal.Text = "";
                    txtciudad.Text = "";
                }
                else
                {
                    throw new ArgumentException("error en la conexion");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conexion.Close();
        }

        private void btnactualizarsucu_Click(object sender, RoutedEventArgs e)
        {

            conexion.Open();

            string con = "select * from SUCURSAL;";
            SqlCommand comando = new SqlCommand(con, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            listaview.ItemsSource = tabla.DefaultView;

            conexion.Close();
        }
    }
}
