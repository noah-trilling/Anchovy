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
    public class PizzaToppingsController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/PizzaToppings
        public IQueryable<PizzaTopping> GetPizzaToppings()
        {
            return db.PizzaToppings;
        }

        // GET: api/PizzaToppings/5
        [ResponseType(typeof(PizzaTopping))]
        public IHttpActionResult GetPizzaTopping(int id)
        {
            PizzaTopping pizzaTopping = db.PizzaToppings.Find(id);
            if (pizzaTopping == null)
            {
                return NotFound();
            }

            return Ok(pizzaTopping);
        }

        // PUT: api/PizzaToppings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPizzaTopping(int id, PizzaTopping pizzaTopping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pizzaTopping.Id)
            {
                return BadRequest();
            }

            db.Entry(pizzaTopping).State = EntityState.Modified;
            db.Entry(pizzaTopping.Pizza).State = EntityState.Unchanged;
            db.Entry(pizzaTopping.Topping).State = EntityState.Unchanged;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaToppingExists(id))
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

        // POST: api/PizzaToppings
        [ResponseType(typeof(PizzaTopping))]
        public IHttpActionResult PostPizzaTopping(PizzaTopping pizzaTopping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PizzaToppings.Add(pizzaTopping);
            db.Entry(pizzaTopping.Pizza).State = EntityState.Unchanged;
            db.Entry(pizzaTopping.Topping).State = EntityState.Unchanged;
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pizzaTopping.Id }, pizzaTopping);
        }

        // DELETE: api/PizzaToppings/5
        [ResponseType(typeof(PizzaTopping))]
        public IHttpActionResult DeletePizzaTopping(int id)
        {
            PizzaTopping pizzaTopping = db.PizzaToppings.Find(id);
            if (pizzaTopping == null)
            {
                return NotFound();
            }

            db.PizzaToppings.Remove(pizzaTopping);
            db.SaveChanges();

            return Ok(pizzaTopping);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PizzaToppingExists(int id)
        {
            return db.PizzaToppings.Count(e => e.Id == id) > 0;
        }
    }
}