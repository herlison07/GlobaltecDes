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
        private PeopleDataContext db = new PeopleDataContext();
        public IQueryable<Models.People> GetPeoples()
        {
            return db.People;
        }
        [Route("people/cpf/{cpf}")]
        public HttpResponseMessage GetPeopleByCpf(string cpf)
        {
            var result = db.People.Where(x => x.Cpf == cpf);
            return Request.CreateResponse(HttpStatusCode.OK, value: result);
        }
        [Route("people/uf/{uf}")]
        public HttpResponseMessage GetPeopleByUf(string uf)
        {
            var result = db.People.Where(x => x.Uf == uf);
            return Request.CreateResponse(HttpStatusCode.OK, value: result);
        }
        // POST: api/People
        [ResponseType(typeof(Models.People))]
        public IHttpActionResult PostPeople(Models.People people)
        {
            db.People.Add(new Models.People(people.Cod, people.Cpf, people.Nome, people.Uf, people.Nascimento.Day, people.Nascimento.Month, people.Nascimento.Year));
            db.SaveChanges();

            return Ok(people);

        }
        public IHttpActionResult PutPeople(Models.People people)
        {
            db.Entry<Models.People>(people).State = EntityState.Modified;
            db.SaveChanges();

            return Ok(people);

        }
        // DELETE: api/People/5
        [Route("people/{id}")]
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
