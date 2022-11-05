using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Entidades;
namespace Datos
{
    public class AutoDatos
    {
        DBautosContext contexto = new DBautosContext();
        public void InsertarAuto(Tauto auto)
        {
            contexto.Tautos.Add(auto);
            contexto.SaveChanges();
        }
        public List<Tauto> Listar(string marca)
        {
            if (marca == null)
            {
                return contexto.Tautos.ToList();
            }
            else
            {
                return contexto.Tautos.Where(x => x.Marca == marca || x.Modelo == marca).ToList();
            }
        }
        //public List<Tauto> Filtrar(string marca)
        //{
        //    return contexto.Tautos.Where(x=>x.Marca == marca || x.Modelo == marca).ToList();
        //}
        public Tauto Buscar(int id)
        {
            return contexto.Tautos.FirstOrDefault(x=>x.Id==id);
        }
        public void Actualizar(Tauto auto)
        {
            var model = contexto.Tautos.FirstOrDefault(x=>x.Id==auto.Id);
            model.Descripcion = auto.Descripcion;
            model.Foto = auto.Foto;
            model.Costo = auto.Costo;
            model.Tipo = auto.Tipo;
            model.Año = auto.Año;
            model.Color = auto.Color;
            model.Id = auto.Id;
            model.Marca = auto.Marca;
            model.Transmicion = auto.Transmicion;
            model.Modelo = auto.Modelo;
            contexto.SaveChanges();
        }
        public void Borrar(int id)
        {
            var delete = contexto.Tautos.FirstOrDefault(x=>x.Id==id);
            contexto.Tautos.Remove(delete);
            contexto.SaveChanges();
        }
    }
}
