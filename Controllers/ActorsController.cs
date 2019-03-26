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

    public class ActorsController : ControllerBase
    {
        // GET actors/
        [HttpGet]

        //these will be 'async Tasks' most likely
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"actor1", "actor2"};
        }

        //GET actors/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> GetActor(int id)
        {

            
        }

        //POST actors

        //PUT actors/1

        //delete actors/1

        //GET actors/1/movies

        //patch actors/1/movies/add


        //patch actors/1/movies/remove
    }
}