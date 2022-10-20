using Datos.Models;
using Entidades;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AdminDatos
    {
        DBautosContext contexto = new DBautosContext();
        public Tadmin Buscar(string usuario, string clave)
        {
            string uclave = ConvertirSha256(clave);
                                    
            try
            {
                if (contexto.Tadmins.FirstOrDefault(c => c.Usuario == usuario && c.Clave == uclave) == null)
                {
                    return null;
                }              

                //if (!id.Id.Equals(null))
                //{
                //    return contexto.Tadmins.FirstOrDefault(c => c.Usuario == usuario && c.Clave == uclave);
                //}
                else
                {
                    return contexto.Tadmins.FirstOrDefault(c => c.Usuario == usuario && c.Clave == uclave);
                }
            }
            catch(Exception e)
            {
                return null;
            }
        }
        public static string ConvertirSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));
                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
