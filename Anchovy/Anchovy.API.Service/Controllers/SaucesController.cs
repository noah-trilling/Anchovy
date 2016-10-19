using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Anchovy.API.Service.DAL;
using Anchovy.API.Service.Models;

namespace Anchovy.API.Service.Controllers
{
    public class SaucesController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/Sauces
        public IQueryable<Sauce> GetSauces()
        {
            return db.Sauces;
        }

        // GET: api/Sauces/5
        [ResponseType(typeof(Sauce))]
        public IHttpActionResult GetSauce(int id)
        {
            Sauce sauce = db.Sauces.Find(id);
            if (sauce == null)
            {
                return NotFound();
            }

            return Ok(sauce);
        }

        // PUT: api/Sauces/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSauce(int id, Sauce sauce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sauce.Id)
            {
                return BadRequest();
            }

            db.Entry(sauce).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SauceExists(id))
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

        // POST: api/Sauces
        [ResponseType(typeof(Sauce))]
        public IHttpActionResult PostSauce(Sauce sauce)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sauces.Add(sauce);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sauce.Id }, sauce);
        }

        // DELETE: api/Sauces/5
        [ResponseType(typeof(Sauce))]
        public IHttpActionResult DeleteSauce(int id)
        {
            Sauce sauce = db.Sauces.Find(id);
            if (sauce == null)
            {
                return NotFound();
            }

            db.Sauces.Remove(sauce);
            db.SaveChanges();

            return Ok(sauce);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SauceExists(int id)
        {
            return db.Sauces.Count(e => e.Id == id) > 0;
        }
    }
}