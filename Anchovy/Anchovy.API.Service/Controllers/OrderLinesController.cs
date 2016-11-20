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
    public class OrderLinesController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/OrderLines
        public IQueryable<OrderLine> GetOrderLines()
        {
            return db.OrderLines.Include("Line");
        }

        // GET: api/OrderLines/5
        [ResponseType(typeof(OrderLine))]
        public IHttpActionResult GetOrderLine(int id)
        {
            OrderLine orderLine = db.OrderLines.Include("Line").FirstOrDefault(_ => _.Id == id);
            if (orderLine == null)
            {
                return NotFound();
            }

            return Ok(orderLine);
        }

        // PUT: api/OrderLines/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrderLine(int id, OrderLine orderLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderLine.Id)
            {
                return BadRequest();
            }

            db.Entry(orderLine).State = EntityState.Modified;
            if (orderLine.Line != null) db.Entry(orderLine.Line).State = EntityState.Unchanged;
            if (orderLine.Order != null) db.Entry(orderLine.Order).State = EntityState.Unchanged;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderLineExists(id))
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

        // POST: api/OrderLines
        [ResponseType(typeof(OrderLine))]
        public IHttpActionResult PostOrderLine(OrderLine orderLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OrderLines.Add(orderLine);
            if(orderLine.Line != null) db.Entry(orderLine.Line).State = EntityState.Unchanged;
            if (orderLine.Order != null) db.Entry(orderLine.Order).State = EntityState.Unchanged;
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = orderLine.Id }, orderLine);
        }

        // DELETE: api/OrderLines/5
        [ResponseType(typeof(OrderLine))]
        public IHttpActionResult DeleteOrderLine(int id)
        {
            OrderLine orderLine = db.OrderLines.Find(id);
            if (orderLine == null)
            {
                return NotFound();
            }

            db.OrderLines.Remove(orderLine);
            db.SaveChanges();

            return Ok(orderLine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderLineExists(int id)
        {
            return db.OrderLines.Count(e => e.Id == id) > 0;
        }
    }
}