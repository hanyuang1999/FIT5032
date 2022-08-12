using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FIT5032_FinalApplication.Models;

namespace FIT5032_FinalApplication.Controllers
{
    public class AP_DATAController : Controller
    {
        private AP_MODEL db = new AP_MODEL();

        // GET: AP_DATA
        public ActionResult Index()
        {
            return View(db.AP_DATA.ToList());
        }

        // GET: AP_DATA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AP_DATA aP_DATA = db.AP_DATA.Find(id);
            if (aP_DATA == null)
            {
                return HttpNotFound();
            }
            return View(aP_DATA);
        }

        // GET: AP_DATA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AP_DATA/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,first_name,last_name,email,gender,phone_number")] AP_DATA aP_DATA)
        {
            if (ModelState.IsValid)
            {
                db.AP_DATA.Add(aP_DATA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aP_DATA);
        }

        // GET: AP_DATA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AP_DATA aP_DATA = db.AP_DATA.Find(id);
            if (aP_DATA == null)
            {
                return HttpNotFound();
            }
            return View(aP_DATA);
        }

        // POST: AP_DATA/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性；有关
        // 更多详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,first_name,last_name,email,gender,phone_number")] AP_DATA aP_DATA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aP_DATA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aP_DATA);
        }

        // GET: AP_DATA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AP_DATA aP_DATA = db.AP_DATA.Find(id);
            if (aP_DATA == null)
            {
                return HttpNotFound();
            }
            return View(aP_DATA);
        }

        // POST: AP_DATA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AP_DATA aP_DATA = db.AP_DATA.Find(id);
            db.AP_DATA.Remove(aP_DATA);
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
