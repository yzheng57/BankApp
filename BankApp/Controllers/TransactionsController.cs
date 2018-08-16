using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BankApp.Models;

namespace BankApp.Controllers
{
    public class TransactionsController : Controller
    {
        private ManageDbContext db = new ManageDbContext();

        // GET: Transactions
        public ActionResult Index()
        {

            var transaction = (int)Session["Id"];
            var trans = new List<Transaction>();

            if (transaction != null)
            {
                trans = db.Transactions
                    .Where(m => m.CustomerId == (transaction))
                    .ToList<Transaction>();

                if (trans == null)
                {
                    trans = new List<Transaction>();
                }
            }
            return View(trans);

            //return View(db.Transactions.ToList());
        }


        // GET: Transaction/Deposit
        public ActionResult Deposit(int CustomerId)
        {

            return View();
        }

        // Post: Transaction/Deposit
        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {


            // Chec for valid data
            if (ModelState.IsValid)
            {
                //Deposit onto customer Table
                //var customer = _context.Customers.Find(transaction.customerId);
                var customer = db.Customers.SingleOrDefault(c => c.CustomerId == transaction.CustomerId);

                if (customer == null)
                {
                    return View();
                }

                // Add time withdrawn to transactions CreatedOn Column
                DateTime today = DateTime.Now;
                transaction.CreatedOn = new DateTime(today.Year, today.Month, today.Day, today.Hour, today.Minute, today.Second);

                customer.Balance += Math.Abs(transaction.Amount);


                // Add Deposit to Transactions Table Log
                db.Transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }




        // GET: Transaction/Withdraw
        public ActionResult Withdraw(int CustomerId)
        {
            return View();
        }

        // POST: Transaction/Withdraw
        [HttpPost]
        public ActionResult Withdraw(Transaction transaction)
        {

            if (ModelState.IsValid)
            {
                var customer = db.Customers.SingleOrDefault(c => c.CustomerId == transaction.CustomerId);
                transaction.Amount = -Math.Abs(transaction.Amount);
                customer.Balance += transaction.Amount;

                // Add time withdrawn to transactions CreatedOn Column
                DateTime today = DateTime.Now;
                transaction.CreatedOn = new DateTime(today.Year, today.Month, today.Day, today.Hour, today.Minute, today.Second);

                db.Transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    

    // GET: Transactions/Details/5
    public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = db.Transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // GET: Transactions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TransactionId,CustomerId,TransTypeId,Amount,CreatedOn")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                db.Transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = db.Transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TransactionId,CustomerId,TransTypeId,Amount,CreatedOn")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaction transaction = db.Transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transaction transaction = db.Transactions.Find(id);
            db.Transactions.Remove(transaction);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
