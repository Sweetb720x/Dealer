using Microsoft.AspNetCore.Mvc;
using Entidades;
using Negocio;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System;
using System.IO;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Negocio.Upload;

namespace Presentacion.Controllers
{
    //[Authorize(Roles = "1")]
    [Authorize(Roles = "f0575d1f3f2f677de975c88e100b1c3b1803bb92b030cb7e0434e21e2f460581")]
    public class AdminController : Controller
    {
        public string ruta;
        private readonly IFileUpload fotoUpload;

        public AdminController(IFileUpload fotoUpload)
        {
            this.fotoUpload = fotoUpload;
        }
        AutoNegocio auto = new AutoNegocio();
        public ActionResult IndexAdmin()
        {
            var model = auto.Listar();
            return View(model);
        }
        public ActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Formulario(IFormFile Foto, Tauto auto)
        {
            OnPost(Foto);
            auto.Foto = ruta;
            this.auto.InsertarAuto(auto);
            return RedirectToAction("IndexAdmin");
        }
        public ActionResult Editar(int id)
        {
            var model = auto.Buscar(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(IFormFile Foto, Tauto auto)
        {
            OnPost(Foto);
            auto.Foto = ruta;
            this.auto.Actualizar(auto);
            return RedirectToAction("IndexAdmin");
        }
        public ActionResult Detalles(int id)
        {
            var model = this.auto.Buscar(id);
            return View(model);
        }
        public ActionResult Borrar(IFormFile Foto, int id)
        {
            var model = auto.Buscar(id);
            return View(model);            
        }
        [HttpPost, ActionName("Borrar")]
        public ActionResult Borrar2(int id)
        {
            auto.Borrar(id);
            return RedirectToAction("IndexAdmin");
        }
        public async Task<ActionResult> Salir()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Home");
        }

        public void OnPost(IFormFile Foto)
        {
            if (Foto != null)
            {
                ruta = fotoUpload.UploadImageAsync(Foto);
                ruta.ToString();
            }
        }
        public ActionResult FiltrarAdmin(string marca)
        {
            var model = auto.Filtrar(marca);
            return View(model);
        }
    }
}
