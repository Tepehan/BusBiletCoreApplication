using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("v1/api/Firmas")]
    [ApiController]
    public class FirmasController : ControllerBase
    {
        FirmaManager fm = new FirmaManager(new EfFirmaRepository());
        // GET: api/<FirmasController>
        [HttpGet]
        public IEnumerable<Firma> Get()
        {
            return fm.firmaListele();
        }
        // GET api/Firmas/tepehan
        [HttpGet("name/{name}")]
        public IActionResult Get(string name)
        {
            Firma firma = fm.firmaGetirByName(name);
            if (firma == null)
            {
                return NotFound();
            }

            return Ok(firma);
        }

        // GET api/Firmas/5
        [HttpGet("{id}")]
        public IActionResult GetBy(int id)
        {
            Firma firma = fm.firmaGetirById(id);
            if (firma == null)
            {
                return NotFound();
            }

            return Ok(firma);
        }

        // POST api/<FirmasController>
        [HttpPost]
        public IActionResult Post([FromBody] Firma firma)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            fm.firmaEkle(firma);

            return CreatedAtRoute("DefaultApi", new { id = firma.firmaId }, firma);
        }

        // PUT api/<FirmasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Firma firma)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != firma.firmaId)
            {
                return BadRequest();
            }



            try
            {
                fm.firmaGuncelle(firma);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (fm.firmaGetirById(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        // DELETE api/<FirmasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Firma firma = fm.firmaGetirById(id);
            if (firma == null)
            {
                return NotFound();
            }

            fm.firmaSil(firma);

            return Ok(firma);
        }
    }
}
