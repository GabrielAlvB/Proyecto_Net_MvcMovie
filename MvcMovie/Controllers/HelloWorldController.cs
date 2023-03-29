/*using System;
using System.Collections.Generic;
using System.Linq;
*/

using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
            //return "this is my <b> default <b/> action";
            //cambiando el index metod (srtind for actionresult) 
        }

        public ActionResult Welcome(string name, int numTimes =1) {
            ViewBag.Message = "Hello " + name;
            ViewBag.Numtimes = numTimes;
            //usando ViewBag para pasar ldatos del controlador 
            // a una vista. 
            // todo esto es un tipo de M para el modelo, pero no el tipo de bases
            // de datos
            return View();
        }

        /*
        public string Welcome(string name, int numTimes = 1 ) {
            return HttpUtility.HtmlEncode("Hello " + name + ", Numtimes is: "+ numTimes);
            //https://localhost:44398/HelloWorld/welcome?name=Scott&numtimes=4
            //el signo ?, en la direcion de URL es un separador y siguen las cadenas de consulta
            //nota de seguridad: el codigo anterior usa httpUtility.HtmlEncode para proteger el codigo de entradas
            //mal intencionadas (es decir JS)
        }*/
    }
}