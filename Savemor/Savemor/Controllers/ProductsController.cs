using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Savemor.Models;

namespace Savemor.Controllers
{
    public class ProductsController : Controller
    {
        private SavemorDBContext db = new SavemorDBContext();

        //
        // GET: /Product/

        public ActionResult Index(int CategoryID = 0)
        {
            // Get the top-level categories
            var Categories =
                from c in db.Category
                where c.ParentID == 0
                orderby c.SortOrder
                select c;

            // First, get a list of all products we are interested in
            var s = (
                from p in db.ProductInfo
                join c in db.Category on p.CategoryID equals c.ID
                where c.ParentID == CategoryID
                where p.Active == true
                select p);

            // This list contains duplicates because each product may be in multiple 
            // categories.  To remove the duplicates we have to remove CategoryID and CategoryName,
            // so we use the ShortProductInfo class to hold this data.
            // At the same time, we make this 'collection' distinct
            var ShortInfo = from p in s.AsEnumerable().Distinct() 
                    select new zzzShortProductInfo 
                    {
                        Active = p.Active, 
                        BrandName = p.BrandName, 
                        Description = p.Description, 
                        ID = p.ID,
                        Image = p.Image,
                        InStoreOnly = p.InStoreOnly,
                        Limit = p.Limit,
                        Measure = p.Measure,
                        Name = p.Name,
                        OppositionPrice = p.OppositionPrice,
                        Price = p.Price,
                        PrivateLabelUPI = p.PrivateLabelUPI,
                        Rank = p.Rank,
                        RecommendedPrice = p.RecommendedPrice,
                        ShelfTalker = p.ShelfTalker,
                        SpecialPrice = p.SpecialPrice,
                        SUSMP = p.SUSMP,
                        Thumbnail = p.Thumbnail,
                        Units = p.Units,
                        UPI = p.UPI 
                    };

            ProductsPageViewModel pvm = new ProductsPageViewModel();

            pvm.Category = Categories;
            pvm.ShortProductInfo = ShortInfo.ToList();

            return View(pvm);
        }

        //
        // GET: /Product/

        public ActionResult Product(int ProductID = 0)
        {

            // Get the product specified
            var Products =
                from p in db.Product
                where p.Active == true
                where p.ID == ProductID
                orderby p.Name
                select p;

            return View(Products);
        }

        public ActionResult Search(string SearchString = "")
        {
            // Get the products for the selected category
            var Products =
                from p in db.ProductSearch(SearchString)
                where p.Active == true
                select p;
            //from p in db.Products
            //where p.Active == true
            //orderby p.Name
            //select p;

            return View(Products.ToList());
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id = 0)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}