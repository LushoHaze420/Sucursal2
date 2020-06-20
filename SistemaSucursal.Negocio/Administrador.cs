using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSucursal.Negocio
{
    public class Administrador
    {
        public string rut_administrador { get; set; }
        public string nombre_administrador { get; set; }
        public string sexo_administrador { get; set; }
        public Nullable<int> id_sucursal { get; set; }

        public Administrador()
        {
            rut_administrador = null;
            nombre_administrador = null;
            sexo_administrador = null;
            id_sucursal = 0;
        }

        public bool agregar()
        {
            try
            {
                Dato.ADMINISTRADOR administrador = new Dato.ADMINISTRADOR()
                {
                    rut_administrador = rut_administrador,
                    nombre_administrador = nombre_administrador,
                    sexo_administrador = sexo_administrador,
                    id_sucursal = id_sucursal
                };

                Conexion.Grupo03Entities.ADMINISTRADOR.Add(administrador);
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
