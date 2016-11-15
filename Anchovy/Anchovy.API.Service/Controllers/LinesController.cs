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
    public class LinesController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/Lines
        public IQueryable<Line> GetLines()
        {
            var lines = db.Lines.Include(_=>_.MenuListing);
            lines = lines.Include(_ => _.Pizza);
            return lines;
        }

        // GET: api/Lines/5
        [ResponseType(typeof(Line))]
        public IHttpActionResult GetLine(int id)
        {
            var lines = db.Lines.Include(_ => _.MenuListing);
            lines = lines.Include(_ => _.Pizza);
            var line = lines.FirstOrDefault(_ => _.Id == id);
            if (line == null)
            {
                return NotFound();
            }

            return Ok(line);
        }

        // PUT: api/Lines/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLine(int id, Line line)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != line.Id)
            {
                return BadRequest();
            }

            db.Entry(line).State = EntityState.Modified;
            if (line.MenuListing != null)
            {
                db.Entry(line.MenuListing).State = EntityState.Unchanged;
            }
            if (line.Pizza != null)
            {
                db.Entry(line.Pizza).State = EntityState.Unchanged;
            }

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineExists(id))
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

        // POST: api/Lines
        [ResponseType(typeof(Line))]
        public IHttpActionResult PostLine(Line line)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Lines.Add(line);
            if (line.MenuListing != null)
            {
                db.Entry(line.MenuListing).State = EntityState.Unchanged;
            }
            if (line.Pizza != null)
            {
                db.Entry(line.Pizza).State = EntityState.Unchanged;
            }
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = line.Id }, line);
        }

        // DELETE: api/Lines/5
        [ResponseType(typeof(Line))]
        public IHttpActionResult DeleteLine(int id)
        {
            Line line = db.Lines.Find(id);
            if (line == null)
            {
                return NotFound();
            }

            db.Lines.Remove(line);
            db.SaveChanges();

            return Ok(line);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LineExists(int id)
        {
            return db.Lines.Count(e => e.Id == id) > 0;
        }
    }
}