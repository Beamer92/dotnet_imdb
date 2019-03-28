using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReplaceJS.Models;

namespace ReplaceJS.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class actorsController : ControllerBase
    {
        private readonly ActorsContext _context;

        public actorsController(ActorsContext context)
        {   _context = context;
            // if (_context.actors.Count() == 0)             
            // {                 
            //     _context.actors.Add(new actor { name = "Nolan Hellyer",  });
            //     _context.SaveChanges();             
            // } 
            // Console.WriteLine(_context);
        } 

        // GET actors/
        [HttpGet] 
        public ActionResult<List<actor>> GetAll() 
        {     
            return _context.actors.ToList(); 
        } 

        //GET actors/1
        [HttpGet("{id}")]
        public ActionResult<actor> GetActor(int id)
        {
            var qur = _context.actors.Where(s => s.id == id).First();

            var query = from act in  _context.actors where act.id == id
                        select act;
            
            // return query;
            return qur;

            //Find out more about Action Results
        }
        //WHY ISN'T QUERYING THE DB ASYNCHRONOUS!?!?!?!

        //POST actors

        //PUT actors/1

        //delete actors/1

        //GET actors/1/movies

        //patch actors/1/movies/add


        //patch actors/1/movies/remove
    }
}