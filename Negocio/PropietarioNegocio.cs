using Datos;
using Datos.Models;
using Entidades;

namespace Negocio
{
    public class PropietarioNegocio
    {
        PropietarioDatos datos = new PropietarioDatos();
        public void InsertarPropietario(Tpropietario propietario)
        {
            datos.InsertarPropietario(propietario);
        }
        public List<Tpropietario> Listar()
        {
            return datos.Listar();
        }
    }
}