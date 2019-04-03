using System;
using System.Collections.Generic;
using System.IO;
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
            return qur;
        }
        /* **** THIS IS THE SAME THING ******* */
        // public IQueryable<actor> GetActor(int id)
        // {
        //     var query = from act in  _context.actors where act.id == id
        //                 select act;
        //     return query;
        // }


        //POST actors
        [HttpPost]

        // public async Task<ActionResult<actor>> NewActor(actor newact)
        // {
        //     _context.actors.Add(newact);
        //     await _context.SaveChangesAsync();
        //     return CreatedAtAction(nameof(GetActor), new { id = newact.id }, newact);
        // }

        public ActionResult<actor> NewActor(actor newact)
        {
             using (var reader = new StreamReader(this.Request.Body))
            {
                var body = reader.ReadToEnd();
                Console.WriteLine(body);
               
            }
            _context.actors.Add(newact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetActor), new { id = newact.id }, newact);
        }
        /*Sync and ASYNC both work, so I'm definitely getting ASYNC somewhere else... */
        //Updated At doesn't update yet, handle in PUT


        //PUT actors/1
        // [HttpPut("{id}")]
        // public ActionResult<actor> UpdateActor(int id)
        // {
        //     //find the way to grab the request data here
        //     using (var reader = new StreamReader(Request.Body))
        //     {
        //         var body = reader.ReadToEnd();
        //         Console.WriteLine(body);
        //         // Do something
        //     }
        // }

        //delete actors/1

        //GET actors/1/movies

        //patch actors/1/movies/add


        //patch actors/1/movies/remove
    }
}