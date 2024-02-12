using Microsoft.AspNetCore.Mvc;
using PracticeProject1.Data;
using PracticeProject1.Models;

namespace PracticeProject1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _db;
        public ProductController(ProductDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
          
            List<Product> products = _db.Laptops.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Laptops.Add(obj);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        
        }
        [HttpGet]   
        public IActionResult Edit(int? id)
        {
            if(id==0||id==null)
            {
                return NotFound();
            }
            Product? productNumber =_db.Laptops.FirstOrDefault(u=>u.LaptopId == id);
            if(productNumber==null)
            {
                return NotFound();
            }
            return View(productNumber);
        }
        [HttpPost]

        public IActionResult Edit(Product obj) {
        if (ModelState.IsValid)
            {
                _db.Laptops.Update(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id==0||id == null)
            {
                return NotFound();
            }
            Product? laptopNumber=_db.Laptops.SingleOrDefault(u=>u.LaptopId ==id);

            if (laptopNumber == null)
            {
                return NotFound();
            }
            return View(laptopNumber);

        }

        [HttpPost,ActionName("Delete")]  
        public IActionResult DeletePost(int? id) {

            Product? laptopNumber = _db.Laptops.SingleOrDefault(u=>u.LaptopId==id);
            if(laptopNumber == null)
            {
                return NotFound();
            }
                _db.Laptops.Remove(laptopNumber);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
            
        }
        
        

    }
}
