using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class PropietarioDatos
    {
        DBautosContext contexto = new DBautosContext();
        public void InsertarPropietario(Tpropietario propietario)
        {
            contexto.Tpropietarios.Add(propietario);
            contexto.SaveChanges();
        }
        public List<Tpropietario> Listar()
        {
            return contexto.Tpropietarios.ToList();
        }
    }
}
