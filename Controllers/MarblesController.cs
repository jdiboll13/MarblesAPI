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

        // Get api/marbles/all
        [Route("/api/marbles/all")]
        public List<MarblesModel> GetAll()
        {
            var marble = new MarblesModel();
            List<MarblesModel> marbles = marble.GetMarbles();
            return marbles;
        }

        // POST api/marbles
        [HttpPost]
        public IActionResult Add([FromForm]string color)
        {
            var marble = new MarblesModel();
            List<MarblesModel> marbles = marble.GetMarbles();
            var newMarble = new MarblesModel
            {
                ID = marbles.Count()+1,
                Color = color
            };
            marbles.Add(newMarble);
            foreach (var item in marbles)
            {
                Console.WriteLine(item);
            }
            return RedirectToAction("GetAll");

        }
    }
}
