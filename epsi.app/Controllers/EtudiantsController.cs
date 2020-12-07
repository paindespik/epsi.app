using epsi.appDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epsi.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtudiantsController : ControllerBase
    {
        [HttpGet]
        public List<EtudiantDto> getEtudiants()
        {
            var Etudiants = new List<EtudiantDto> {
                new EtudiantDto{ Id = 1, Nom = "DRIARD", Prenom = "Sean" },
                new EtudiantDto{ Id = 2, Nom = "beuleu", Prenom = "beuleu" }
            };

            return Etudiants;
        }
    }
}
