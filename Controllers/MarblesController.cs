using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarblesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarblesAPI.Controllers
{
    [Route("api/[controller]")]
    public class MarblesController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
        // GET api/marbles
        [HttpGet]
        public MarblesModel Get()
        {
            var marble = new MarblesModel();
            List<MarblesModel> marbles = marble.GetMarbles();
            Random rnd = new Random();
            marble = marbles[rnd.Next(0, marbles.Count())];
            return marble;
        }

        // POST api/marbles
        [HttpPost]
        public List<MarblesModel> Post([FromForm]int id,string color)
        {
            var marble = new MarblesModel();
            List<MarblesModel> marbles = marble.GetMarbles();
            var newMarble = new MarblesModel
            {
                ID = id++,
                Color = color
            };
            marbles.Add(newMarble);
            Console.WriteLine(newMarble);
            Console.WriteLine(marbles);
            return marbles;

        }
    }
}
