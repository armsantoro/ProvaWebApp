using Microsoft.AspNetCore.Mvc;
using ProvaWebApp.Models;
using ProvaWebApp.Service;

namespace ProvaWebApp.Controllers
{
    public class ClientiController : Controller
    {
        
        
        public IActionResult ListaClienti()
        {
            ServiceClienti serviceClienti = new ServiceClienti();
                       
            return View(serviceClienti.GetClienti());
        }
    }
}
