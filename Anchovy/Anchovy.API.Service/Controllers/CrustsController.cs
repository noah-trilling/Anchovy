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
    public class CrustsController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/Crusts
        public IQueryable<Crust> GetCrusts()
        {
            return db.Crusts;
        }

        // GET: api/Crusts/5
        [ResponseType(typeof(Crust))]
        public IHttpActionResult GetCrust(int id)
        {
            Crust crust = db.Crusts.Find(id);
            if (crust == null)
            {
                return NotFound();
            }

            return Ok(crust);
        }

        // PUT: api/Crusts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCrust(int id, Crust crust)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != crust.Id)
            {
                return BadRequest();
            }

            db.Entry(crust).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrustExists(id))
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

        // POST: api/Crusts
        [ResponseType(typeof(Crust))]
        public IHttpActionResult PostCrust(Crust crust)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Crusts.Add(crust);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = crust.Id }, crust);
        }

        // DELETE: api/Crusts/5
        [ResponseType(typeof(Crust))]
        public IHttpActionResult DeleteCrust(int id)
        {
            Crust crust = db.Crusts.Find(id);
            if (crust == null)
            {
                return NotFound();
            }

            db.Crusts.Remove(crust);
            db.SaveChanges();

            return Ok(crust);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CrustExists(int id)
        {
            return db.Crusts.Count(e => e.Id == id) > 0;
        }
    }
}