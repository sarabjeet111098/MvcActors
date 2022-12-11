using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ActorsApp.Models;
using ActorsApp.Services;

namespace ActorsApp.Controllers
{
    [Route("[controller]")]
    public class ActorsController : Controller
    {
       InMemomryActorsService _service ;
       public ActorsController(){
        _service = new InMemomryActorsService();
       }

       public IActionResult Index(){
        List<Actor> actors = _service.GetAllActors();
        return View(actors);
       }
    }
}