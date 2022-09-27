using DongBoTruc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DongBoTruc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }        

        public List<Address> GetDatabase()
        {
            List<Address> addresses = new List<Address>
            { 
                new Address
                {
                    EdocId = "000.00.17.H36",
                    Name = "Test 1",
                },
                new Address
                {
                    EdocId = "000.00.23.H36",
                    Name = "Test 2",
                },
                new Address
                {
                    EdocId = "000.00.24.H36",
                    Name = "Test 3",
                },
                new Address
                {
                    EdocId = "000.00.28.G18",
                    Name = "Test 4",
                }
            };

            return addresses;
        }

        public JsonResult GetAll()
        {
            string filePath = @"D:\BKAV\ProjectBkav\DongBoTruc\data.xml";
            var result = DeserializeToObject<GetOrganizationsResponse>(filePath);
            var lstOrganization = result.Organizations.organizations;

            var lstAddress = GetDatabase();

            foreach (var organ in lstOrganization)
            {
                var address = lstAddress.FirstOrDefault(a => a.EdocId == organ.OrganId);
                if(address != null)
                {
                    organ.isChecked = true;
                }
            }
            return Json(lstOrganization, JsonRequestBehavior.AllowGet);
        }

        [System.Web.Http.HttpPost]
        public ActionResult SyncDatabase([FromBody] List<Organization> organizations)
        {

            var temp = organizations;

            return Json(new { message = "SUCCESS"}, JsonRequestBehavior.AllowGet);
        }

        public static T DeserializeToObject<T>(string filepath) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StreamReader sr = new StreamReader(filepath))
            {
                return (T)ser.Deserialize(sr);
            }
        }

       
    }

}