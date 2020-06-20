using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSucursal.Negocio
{
    class Empresa
    {
        public string rut_empresa { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }

        public Empresa()
        {
            rut_empresa = null;
            telefono = null;
            correo = null;
            direccion = null;
        }

        public bool agregar()
        {
            try
            {
                Dato.EMPRESA empresa = new Dato.EMPRESA()
                {
                    rut_empresa = rut_empresa,
                    telefono = telefono,
                    correo = correo,
                    direccion = direccion
                };

                Conexion.Grupo03Entities.EMPRESA.Add(empresa);
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
