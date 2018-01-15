using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ConocimCorp.Context;
using ConocimCorp.Models;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


namespace ConocimCorp.Controllers
{
    public class ProductsController : Controller
    {
        private DataStore db = new DataStore();
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            Product p = db.Products.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                
                if(p == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(p);
                }

                
            }
            
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product Products)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Products.Add(Products);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(Products);
            }
            catch
            {
                return View(Products);
            }
        }

       

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            Product p = db.Products.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {

                if (p == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(p);
                }


            }
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(p).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(p);
            }
            catch
            {
                return View(p);
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            Product p = db.Products.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                
                if (p == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(p);
                }


            }
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product p)
        {
            p = db.Products.Find(id);
            try
            {
                if (ModelState.IsValid)
                {
                    p = db.Products.Find(id);
                    if (p==null) {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Products.Remove(p);
                        db.SaveChanges();
                    }
                       return RedirectToAction("Index");
                }
                return View(p);
            }
            catch
            {
                return View(p);
            }
        }
    }
}
