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
    public class MenuListingsController : ApiController
    {
        private AnchovyContext db = new AnchovyContext();

        // GET: api/MenuListings
        public IQueryable<MenuListing> GetMenuListings()
        {
            return db.MenuListings;
        }

        // GET: api/MenuListings/5
        [ResponseType(typeof(MenuListing))]
        public IHttpActionResult GetMenuListing(int id)
        {
            MenuListing menuListing = db.MenuListings.Find(id);
            if (menuListing == null)
            {
                return NotFound();
            }

            return Ok(menuListing);
        }

        // PUT: api/MenuListings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMenuListing(int id, MenuListing menuListing)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != menuListing.Id)
            {
                return BadRequest();
            }

            db.Entry(menuListing).State = EntityState.Modified;
            db.Entry(menuListing.Size).State = EntityState.Unchanged;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuListingExists(id))
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

        // POST: api/MenuListings
        [ResponseType(typeof(MenuListing))]
        public IHttpActionResult PostMenuListing(MenuListing menuListing)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MenuListings.Add(menuListing);
            db.Entry(menuListing.Size).State = EntityState.Unchanged;

            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = menuListing.Id }, menuListing);
        }

        // DELETE: api/MenuListings/5
        [ResponseType(typeof(MenuListing))]
        public IHttpActionResult DeleteMenuListing(int id)
        {
            MenuListing menuListing = db.MenuListings.Find(id);
            if (menuListing == null)
            {
                return NotFound();
            }

            db.MenuListings.Remove(menuListing);
            db.SaveChanges();

            return Ok(menuListing);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MenuListingExists(int id)
        {
            return db.MenuListings.Count(e => e.Id == id) > 0;
        }
    }
}