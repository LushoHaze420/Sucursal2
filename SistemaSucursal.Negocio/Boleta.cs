using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSucursal.Negocio
{
    class Boleta
    {
        public int id_boleta { get; set; }
        public Nullable<int> monto_venta { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public string rut_vendedor { get; set; }

        public Boleta()
        {
            id_boleta = 0;
            monto_venta = 0;
            fecha_venta = null;
            rut_vendedor = null;
        }

        public bool agregar()
        {
            try
            {
                Dato.BOLETA boleta = new Dato.BOLETA()
                {
                    id_boleta = id_boleta,
                    monto_venta = monto_venta,
                    fecha_venta = fecha_venta,
                    rut_vendedor = rut_vendedor
                };

                Conexion.Grupo03Entities.BOLETA.Add(boleta);
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
