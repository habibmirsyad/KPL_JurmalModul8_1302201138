using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302201138.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        
        private static List<Movie> movieList = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", /*{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler", "Marlon Brando, Al Pacino", "James Caan", "Diane Keaton", "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}*/ "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler, Marlon Brando, Al Pacino, James Caan, Diane Keaton, Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.")
            new Movie("")
        };
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return movieList;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return arrMovie[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
