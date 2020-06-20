using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSucursal.Negocio
{
    public class Sucursal
    {
        public int id_sucursal { get; set; }
        public string nombre_sucursal { get; set; }
        public string ciudad_sucursal { get; set; }

        public Sucursal()
        {
            id_sucursal = 0;
            nombre_sucursal = null;
            ciudad_sucursal = null;
        }

        public bool agregar()
        {
            try
            {
                Dato.SUCURSAL sucursal = new Dato.SUCURSAL()
                {
                    id_sucursal = id_sucursal,
                    nombre_sucursal = nombre_sucursal,
                    ciudad_sucursal = ciudad_sucursal
                };

                Conexion.Grupo03Entities.SUCURSAL.Add(sucursal);
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
