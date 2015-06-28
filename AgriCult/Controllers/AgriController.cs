using AgriCult.AgriService;
using AgriCult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace AgriCult.Controllers
{
     public class FarmInputModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public int ID { get; set; }
        public string Key { get; set; }
    }
      
    public class FarmViewModel
    {
        public string ID { get; set; }
        public string Key { get; set; }
    }

    public class AgriController : Controller
    {
        FarmServiceClient agriService = null;
        public ActionResult Index()
        {
            IEnumerable<Farm> model = null;
            IList<FarmInputModel> viewModel = null;
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
            try
            {
                agriService = new FarmServiceClient();
                model = agriService.GetFarms().ToList<Farm>();
            }
            catch (FaultException<AgriCultSvcData> e)
            {
                //The below info can be logged and acted upon
                //e.Message, e.Reason, e.Detail;
                agriService.Abort();
            }
            finally
            {
                agriService.Close();
            }

            viewModel = new List<FarmInputModel>();

            foreach (Farm farm in model)
            {
                viewModel.Add(new FarmInputModel
                {
                    Name = farm.FarmName,
                    Comment = farm.Comment
                });
            }

            return View(viewModel);
        }

        public ActionResult Save(FarmInputModel model)
        {

            Farm farm = new Farm
            {
                FarmName = model.Name,
                Comment = model.Comment
            };

            int id = 0;
            try
            {
                agriService = new FarmServiceClient();
                agriService.Add(farm);
            }
            catch (FaultException<AgriCultSvcData> e)
            {
                //The below info can be logged and acted upon
                //e.Message, e.Reason, e.Detail;
                agriService.Abort();
            }
            finally
            {
                agriService.Close();
            }
            FarmViewModel vm = new FarmViewModel();
            vm.ID = id.ToString();
            vm.Key = model.Key;

            return Json(vm);
        }
    }
}