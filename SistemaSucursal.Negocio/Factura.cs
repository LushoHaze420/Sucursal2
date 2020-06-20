using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSucursal.Negocio
{
    class Factura
    {
        public int id_factura { get; set; }
        public Nullable<int> monto_factura { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public string rut_empresa { get; set; }
        public string rut_vendedor { get; set; }

        public Factura()
        {
            id_factura = 0;
            monto_factura = 0;
            fecha_venta = null;
            rut_empresa = null;
            rut_vendedor = null;
        }

        public bool agregar()
        {
            try
            {
                Dato.FACTURA factura = new Dato.FACTURA()
                {
                    id_factura = id_factura,
                    monto_factura = monto_factura,
                    fecha_venta = fecha_venta,
                    rut_empresa = rut_empresa,
                    rut_vendedor = rut_vendedor
                };

                Conexion.Grupo03Entities.FACTURA.Add(factura);
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
