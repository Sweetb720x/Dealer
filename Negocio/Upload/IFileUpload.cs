﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Negocio.Upload
{
    public interface IFileUpload
    {
        string UploadImageAsync(IFormFile Foto);
    }
}
