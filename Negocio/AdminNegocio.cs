using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdminNegocio
    {
        AdminDatos datos = new AdminDatos();
        public Tadmin Buscar(string u, string c)
        {
            try
            {
                return datos.Buscar(u, c);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
