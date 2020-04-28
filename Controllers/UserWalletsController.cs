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
using WalletAPI.Data;

namespace WalletAPI.Controllers
{
    public class UserWalletsController : ApiController
    {
        private ppiDbLiveEntities db = new ppiDbLiveEntities();

        // GET: api/UserWallets
        public IQueryable<UserWallet> GetUserWallet()
        {
            return db.UserWallet;
        }

        // GET: api/UserWallets/5
        [ResponseType(typeof(UserWallet))]
        public IHttpActionResult GetUserWallet(long id)
        {
            UserWallet userWallet = db.UserWallet.Find(id);
            if (userWallet == null)
            {
                return NotFound();
            }

            return Ok(userWallet);
        }

        // PUT: api/UserWallets/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserWallet(long id, UserWallet userWallet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userWallet.Id)
            {
                return BadRequest();
            }

            db.Entry(userWallet).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserWalletExists(id))
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

        // POST: api/UserWallets
        [ResponseType(typeof(UserWallet))]
        public IHttpActionResult PostUserWallet(UserWallet userWallet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserWallet.Add(userWallet);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = userWallet.Id }, userWallet);
        }

        // DELETE: api/UserWallets/5
        [ResponseType(typeof(UserWallet))]
        public IHttpActionResult DeleteUserWallet(long id)
        {
            UserWallet userWallet = db.UserWallet.Find(id);
            if (userWallet == null)
            {
                return NotFound();
            }

            db.UserWallet.Remove(userWallet);
            db.SaveChanges();

            return Ok(userWallet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserWalletExists(long id)
        {
            return db.UserWallet.Count(e => e.Id == id) > 0;
        }
    }
}