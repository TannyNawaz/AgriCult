using AgriCult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgriCult.Controllers
{
     public class AgriInputModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public int ID { get; set; }
        public string Key { get; set; }
    }
      
    public class AgriViewModel
    {
        public string ID { get; set; }
        public string Key { get; set; }
    }

    public class CustomerController : Controller
    {

        FarmRepository repository = null;
        public ActionResult Index()
        {
            FarmsDataContext db = new FarmsDataContext();
            //var cache = MvcApplication.dataCacheFactory.GetDefaultCache();
            //IEnumerable<Customer> farmsModel = null;
            //farmsModel = cache["farms"] as IEnumerable<Customer>;
            //ViewData["isCached"] = "Data is cached";
            //if (farmsModel == null)
            //{
            //    farmsModel = db.Customers.ToList();
            //    cache["farms"] = farmsModel;
            //    ViewData["isCached"] = "Data isn't cached";
            //}
            return View(db.Customers);
        }

        public ActionResult Save(AgriInputModel model)
        {
            repository = new FarmRepository();

            int id = 0;

            id = repository.Add(model.Name, model.Comment);

            AgriViewModel vm = new AgriViewModel();
            vm.ID = id.ToString();
            vm.Key = model.Key;

            return Json(vm);
        }
    }
}