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
    public class PizzasController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/Pizzas
        public IQueryable<Pizza> GetPizzas()
        {
            return db.Pizzas.Include("Size").Include("Sauce").Include("Crust");
        }

        // GET: api/Pizzas/5
        [ResponseType(typeof(Pizza))]
        public IHttpActionResult GetPizza(int id)
        {
            Pizza pizza = db.Pizzas.Include("Size").Include("Crust").Include("Sauce").FirstOrDefault(_ => _.Id == id);
            if (pizza == null)
            {
                return NotFound();
            }
            //pizza = db.Pizzas.Include(_ => _.Toppings).Single(_ => _.Id == pizza.Id);
            return Ok(pizza);
        }

        // PUT: api/Pizzas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPizza(int id, Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pizza.Id)
            {
                return BadRequest();
            }

            db.Entry(pizza).State = EntityState.Modified;
            db.Entry(pizza.Size).State = EntityState.Unchanged;
            db.Entry(pizza.Crust).State = EntityState.Unchanged;
            db.Entry(pizza.Sauce).State = EntityState.Unchanged;
            
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaExists(id))
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

        // POST: api/Pizzas
        [ResponseType(typeof(Pizza))]
        public IHttpActionResult PostPizza(Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pizzas.Add(pizza);
            db.Entry(pizza.Size).State = EntityState.Unchanged;
            db.Entry(pizza.Crust).State = EntityState.Unchanged;
            db.Entry(pizza.Sauce).State = EntityState.Unchanged;
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pizza.Id }, pizza);
        }

        // DELETE: api/Pizzas/5
        [ResponseType(typeof(Pizza))]
        public IHttpActionResult DeletePizza(int id)
        {
            Pizza pizza = db.Pizzas.Find(id);
            if (pizza == null)
            {
                return NotFound();
            }

            db.Pizzas.Remove(pizza);
            db.SaveChanges();

            return Ok(pizza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PizzaExists(int id)
        {
            return db.Pizzas.Count(e => e.Id == id) > 0;
        }
    }
}