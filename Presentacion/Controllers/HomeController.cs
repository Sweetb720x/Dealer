using Microsoft.AspNetCore.Mvc;
using Presentacion.Models;
using System.Diagnostics;
using Entidades;
using Negocio;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Presentacion.Controllers
{
    public class HomeController : Controller
    {

        PropietarioNegocio propietarios = new PropietarioNegocio();
        AutoNegocio autos = new AutoNegocio();
        AdminNegocio admin = new AdminNegocio();
      
        public ActionResult Index(string marca)
        {
            var model = autos.Listar(marca);
            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(Tadmin admin)
        {
            try
            {
                var user = this.admin.Buscar(admin.Usuario, admin.Clave);
                //Session["usuario"] = admin;
                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Usuario),
                        //new Claim(ClaimTypes.Role, user.Id.ToString())*/
                        new Claim(ClaimTypes.Role, user.Clave)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToAction("IndexAdmin","Admin");
                }
                ViewData["Mensaje"] = "No existe el usuario";
            }
            catch
            {
                ViewData["Mensaje"] = "Error al loguear";
            }
            return View();
        }

        public ActionResult VerAuto(int id)
        {
            var model = autos.Buscar(id);
            return View(model);
        }
        //[HttpPost]
        //public ActionResult Filtrar(string marca)
        //{
        //    var model = autos.Filtrar(marca);
        //    return View(model);
        //}
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}