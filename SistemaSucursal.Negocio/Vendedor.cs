using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSucursal.Negocio
{
    public class Vendedor
    {
        public string rut_vendedor { get; set; }
        public string nombre_vendedor { get; set; }
        public string sexo_vendedor { get; set; }
        public Nullable<int> total_venta { get; set; }
        public Nullable<int> id_sucursal { get; set; }

        public Vendedor()
        {
            rut_vendedor = null;
            nombre_vendedor = null;
            sexo_vendedor = null;
            total_venta = 0;
            id_sucursal = 0;
        }

        public bool agregar()
        {
            try
            {
                Dato.VENDEDOR vendedor = new Dato.VENDEDOR()
                {
                    rut_vendedor = rut_vendedor,
                    nombre_vendedor = nombre_vendedor,
                    sexo_vendedor = sexo_vendedor,
                    id_sucursal = id_sucursal
                };

                Conexion.Grupo03Entities.VENDEDOR.Add(vendedor);
                Conexion.Grupo03Entities.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        
    }
}
