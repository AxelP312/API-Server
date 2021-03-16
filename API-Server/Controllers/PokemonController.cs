using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API_Server.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {name = "Pikachu"}
        };



        [HttpGet]
        public ActionResult Get()
        {
            return Ok("hej");
        }
        
    }
}