using System;
using System.Net;
using System.Web.Mvc;
using _1221WebApplication2.Models.DTOs;
using _1221WebApplication2.Models.EFModels;
using _1221WebApplication2.Models.EFModels.Services;
using WebApplication1.Models.Services;

namespace _1221WebApplication2.Controllers
{
    public class RegistersController : Controller
    {
        // private AppDbContext01 db = new AppDbContext01();

        // GET: Registers
        private IRegisterRepository repository;
        public RegistersController()
        {
            repository = new RegisterRepository();
        }
        //Get Registers
        public ActionResult Index()
        {
            var data = repository.GetAll();
            return View(data);
        }

        // GET: Registers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            try
            {
               Register reqister = new RegistersService(repository).Find(id.Value);
                return View(reqister);
            }
            catch(Exception ex)
            {
                return HttpNotFound();
            }
            
        }

        // GET: Registers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registers/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email")] Register register)
        {
            try
            {
                new RegistersService(repository).Create(register.EntetyToDTO());
            }
            catch(Exception ex) {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(register);
        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
