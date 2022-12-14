using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo1_Route.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Math/Carre/{id}")]
        [Route("Math/{id}/auCarre")]
        public int Carre(int id)
        {
            return id * id;
        }

        [Route("Math/Table/{id}")]
        [Route("Math/Multiple/{id}")]
        public string Multiple(int id)
        {
            string result = $"Table de multiplication de {id}\n";
            for (int i = 1; i <= 10 ; i++)
            {
                result += $"{i} x {id} = {i * id}\n";
            }
            return result; 
        }

        [Route("Math/{nb1}/divisePar/{nb2}")]
        [Route("Math/Division/{nb1?}/{nb2?}")]
        public string Division(int nb1, int nb2)
        {
            if (nb2 == 0)
            {
                return "Attention, la division par 0 est impossible !";
            }
            return (nb1 / (double)nb2).ToString();
            //return $"{nb1} / {nb2} = {nb1 / (double)nb2}";
        }

        public IActionResult TableauCroise()
        {
            return View();
        }

    }
}
