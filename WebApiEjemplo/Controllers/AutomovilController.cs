using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiEjemplo.Autos;
namespace WebApiEjemplo.Controllers
{
    [ApiController]
    [Route("api/Automovil")]
    public class AutomovilController
    {
        public List<Automovil> Automoviles = new List<Automovil> { new Automovil() { id = 1, Marca = "Ferrari", Precio = 339.420 }
        ,new Automovil() { id = 2, Marca = "BMW", Precio = 125.900000 }
    };
      
           
        [HttpGet]
        public ActionResult<List<Automovil>>Get()
        {

            return Automoviles;
        }
        [HttpPost]
        public ActionResult<List<Automovil>> post()
        {

            return Automoviles;
        }

        [HttpDelete]
    [Route("{id}")]
    public Automovil Delete(int id)
        {
            var automovil = Automoviles.Find(Automovil => Automovil.id == 1);
            Automoviles.Remove(automovil);

            return automovil;
        }


    }
}
