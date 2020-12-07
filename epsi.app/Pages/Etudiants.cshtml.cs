using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using epsi.appDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace epsi.app.Pages
{
    public class EtudiantsModel : PageModel
    {
        public List<EtudiantDto> Etudiants { get; set; }

        public void OnGet()
        {
            Etudiants = new List<EtudiantDto> { 
                new EtudiantDto{ Id = 1, Nom = "DRIARD", Prenom = "Sean" },
                new EtudiantDto{ Id = 2, Nom = "beuleu", Prenom = "beuleu" }
            };
        }
    }
}
