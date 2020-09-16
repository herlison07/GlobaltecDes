using People.Autentication.DataContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace People.Autentication.Controllers
{
    public class PeopleController : ApiController
    {
        // POST: api/People1
        [ResponseType(typeof(Models.People))]
        public IHttpActionResult PostPeople(Models.People people)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.People.Add(people);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = people.Cod }, people);
        }
        private PeopleDataContext db = new PeopleDataContext();
        //[Authorize()]
        public IQueryable<Models.People> GetPeoples()
        {
            return db.People;
        }
        [ResponseType(typeof(Models.People))]
        [Authorize()]
        [Route("cpf/{cpf}")]
        public IHttpActionResult GetPeopleByCpf(string uf)
        {
            Models.People people = db.People.Find(uf); 
            if (people == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(people);
            }
        }
        [Authorize()]
        [Route("codigo/{cod}")]
        public IHttpActionResult GetPeopleByCod(int cod)
        {
            Models.People people = db.People.Find(cod);
            if (people == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(people);
            }
        }
        [Authorize()]
        public IHttpActionResult PutPeople(int id, Models.People people)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != people.Cod)
            {
                return BadRequest();
            }

            db.Entry(people).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeopleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        // DELETE: api/People/5
        [Authorize()]
        [ResponseType(typeof(Models.People))]
        public IHttpActionResult DeletePeople(int id)
        {
            Models.People people = db.People.Find(id);
            if (people == null)
            {
                return NotFound();
            }

            db.People.Remove(people);
            db.SaveChanges();

            return Ok(people);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeopleExists(int id)
        {
            return db.People.Count(e => e.Cod == id) > 0;
        }
    }
}
