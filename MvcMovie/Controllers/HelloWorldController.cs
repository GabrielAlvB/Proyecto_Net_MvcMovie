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
        public string Index()
        {
            return "this is my <b> default <b/> action";
        }

        public string Welcome(string name, int ID=1) {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        
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