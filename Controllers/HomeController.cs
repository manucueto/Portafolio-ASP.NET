using Portafolio.Servicios;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;
    public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
    {
        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
    }

    //estos son metodos llamados acciones, que se ejecutan en respuesta alas peticiones http de nuestros clientes
    public IActionResult Index() //al correr el programa se va a ejecutar el siguiente metodo, este va a abrir una vista en el navegador
    // , pero como sabe el cual vista abrir?, verificará el nombre del controlador, que en este caso se llama "Home" se dirigirá a 
    // la carpeta "Views" y luego entrará a la carpeta Home por el nombre del controlador, luego nuestra accion se llama Index(), por 
    // lo tanto abrirá la vista Index.cshtml
    {
        _logger.LogInformation("Este es un mensaje de log");
        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
        return View(modelo/*este es un parametro no obligatorio para decirle especificamente que vista tiene que abrir*/);
    }
    
    
   public IActionResult Proyectos(){
    var proyectos = repositorioProyectos.ObtenerProyectos();
    return View(proyectos);
   }
   public IActionResult Contacto(){
    return View();
   }

   [HttpPost]
   public IActionResult Contacto(ContactoViewModel contactoViewModel)
   {
    return RedirectToAction("Gracias");
   }
    public IActionResult Gracias(){
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
