using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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

        public ActionResult<actor> NewActor([FromBody]actor newact)
        {
            _context.actors.Add(newact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetActor), new { id = newact.id }, newact);
        }
        /*Sync and ASYNC both work, so I'm definitely getting ASYNC somewhere else... */
        //Updated At doesn't update yet, handle in PUT


        // PUT actors/1
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(actor), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //StatusCodes comes from using Microsoft.AspNetCore.Http;
        public ActionResult<actor> UpdateActor(int id, [FromBody]actor upact)
        {
                var oldact = _context.actors.FirstOrDefault(c => c.id == id);

                if(oldact == null)
                {
                    return new NotFoundResult();
                }
                oldact.name = upact.name ?? oldact.name;
                oldact.biography = upact.biography ?? oldact.biography;
                oldact.profile_url = upact.profile_url ?? oldact.profile_url;
                oldact.birth_date = upact.birth_date == new DateTime() ? oldact.birth_date : upact.birth_date;
                oldact.updated_at = upact.updated_at;
                _context.SaveChanges();
                return oldact;
        }

        //delete actors/1
        [HttpDelete("{id}")]
        public ActionResult DeleteActor(int id)
        {
            var oldact = _context.actors.FirstOrDefault(c => c.id == id);
            
            if(oldact == null)
            {
                return new NotFoundResult();
            }

            _context.actors.Remove(oldact);
            _context.SaveChanges();
            System.Diagnostics.Debug.WriteLine("HELLO NOOB");
            return StatusCode(200, "Actor Successfully Deleted");

        }
        //GET actors/1/movies

        //patch actors/1/movies/add


        //patch actors/1/movies/remove
    }
}