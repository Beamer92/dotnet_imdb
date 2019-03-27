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

        //I don't know what this is for.... why? /*
        // public actorsController(ActorsContext context)
        // {   context = _context;
        //     if (_context.actors.Count() == 0)             
        //     {                 
        //         _context.actors.Add(new actor { name = "Nolan Hellyer" });
        //         _context.SaveChanges();             
        //     } 
        // } */
        

        //GET actors/1
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Actor>> GetActor(int id)
        // {

            
        // }

        //POST actors

        //PUT actors/1

        //delete actors/1

        //GET actors/1/movies

        //patch actors/1/movies/add


        //patch actors/1/movies/remove
    }
}