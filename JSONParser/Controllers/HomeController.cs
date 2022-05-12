using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JSONParser.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json;

using JSONParser.Services.Services;
using Newtonsoft.Json.Linq;

namespace JSONParser.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJSONProcessing iJSONProcessing;
        public HomeController(ILogger<HomeController> logger,IJSONProcessing iJSONProcessing)
        {
            _logger = logger;
            this.iJSONProcessing = iJSONProcessing;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile JsonFile)
        {
            var fileContent = "";
            using (var reader = new StreamReader(JsonFile.OpenReadStream()))
            {
                fileContent = reader.ReadToEnd();
            }
            var result = JsonConvert.DeserializeObject<dynamic>(fileContent);
            List<EmployeeModel> EmployeeDataset = CreateDataSet();



            return View(iJSONProcessing.ComputeMonthlySalary(EmployeeDataset));
        }
        public List<EmployeeModel> CreateDataSet()
        {
            EmployeeModel employeeModel1 = new EmployeeModel();
            employeeModel1.FirstName = "Jack"; employeeModel1.LastName = "Sparrow"; employeeModel1.salary = 12234; employeeModel1.Address = "regular";
            EmployeeModel employeeModel2 = new EmployeeModel();
            employeeModel2.FirstName = "Jack2"; employeeModel2.LastName = "Sparrow"; employeeModel2.salary = 2334; employeeModel2.Address = "International";
            EmployeeModel employeeModel3 = new EmployeeModel();
            employeeModel3.FirstName = "Jack3"; employeeModel3.LastName = "Sparrow"; employeeModel3.salary = 234; employeeModel3.Address = "regular";

            List<EmployeeModel> list = new List<EmployeeModel>();
            list.Add(employeeModel1);list.Add(employeeModel2);list.Add(employeeModel3);

            return list;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
