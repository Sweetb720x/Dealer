using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AutoNegocio
    {
        AutoDatos datos = new AutoDatos();
        public void InsertarAuto(Tauto auto)
        {
            datos.InsertarAuto(auto);
        }
        public List<Tauto> Listar(string marca)
        {
            return datos.Listar(marca);
        }
        //public List<Tauto> Filtrar(string marca)
        //{
        //    return datos.Filtrar(marca);
        //}
        public Tauto Buscar(int id)
        {
            return datos.Buscar(id);
        }
        public void Actualizar(Tauto auto)
        {
            datos.Actualizar(auto);
        }
        public void Borrar(int id)
        {
            datos.Borrar(id);
        }
    }
}
