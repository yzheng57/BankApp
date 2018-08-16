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
    public class TermDepositsController : Controller
    {
        private ManageDbContext db = new ManageDbContext();

        // GET: TermDeposits
        public ActionResult Index()
        {

            var account = (int)Session["Id"];
            var acco = new List<TermDeposit>();

            if (account != null)
            {
                acco = db.TermDeposits
                    .Where(m => m.CustomerId == (account))
                    .ToList<TermDeposit>();

                if (acco == null)
                {
                    acco = new List<TermDeposit>();
                }
            }
            return View(acco);

            //return View(db.TermDeposits.ToList());
        }

        // GET: TermDeposits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermDeposit termDeposit = db.TermDeposits.Find(id);
            if (termDeposit == null)
            {
                return HttpNotFound();
            }
            return View(termDeposit);
        }

        // GET: TermDeposits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TermDeposits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DepositId,CustomerId,Amount,Months,Rate,Interest,total_amt")] TermDeposit termDeposit)
        {
            if (ModelState.IsValid)
            {
                termDeposit.Interest = Math.Pow(1 + termDeposit.Rate, termDeposit.Months) - 1;
                termDeposit.total_amt = termDeposit.Amount * termDeposit.Interest;

                return RedirectToAction("Index");
            }

            return View(termDeposit);
        }

        // GET: TermDeposits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermDeposit termDeposit = db.TermDeposits.Find(id);
            if (termDeposit == null)
            {
                return HttpNotFound();
            }
            return View(termDeposit);
        }

        // POST: TermDeposits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DepositId,CustomerId,Amount,Months,Rate,Interest,total_amt")] TermDeposit termDeposit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(termDeposit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(termDeposit);
        }

        // GET: TermDeposits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TermDeposit termDeposit = db.TermDeposits.Find(id);
            if (termDeposit == null)
            {
                return HttpNotFound();
            }
            return View(termDeposit);
        }

        // POST: TermDeposits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TermDeposit termDeposit = db.TermDeposits.Find(id);
            db.TermDeposits.Remove(termDeposit);
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
