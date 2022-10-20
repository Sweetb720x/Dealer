using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Upload
{
    public class LocalUpload : IFileUpload
    {
        //private readonly IHostingEnvironment env;
        //public LocalUpload(IHostingEnvironment env)
        //{
        //    this.env = env;
        //}
        public string UploadImageAsync(IFormFile Foto)
        {
            //var path = Path.Combine(@"../Presentacion/wwwroot/Images", Foto.FileName);
            var path = Path.Join(@"../Presentacion/wwwroot/Images", Foto.FileName);
            using var fileStream = new FileStream(path, FileMode.Create);
            Foto.CopyTo(fileStream);
            return path;
        }
    }
}
