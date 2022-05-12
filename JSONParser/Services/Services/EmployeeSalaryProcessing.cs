using System;
using System.Collections.Generic;
using System.Reflection;
using JSONParser.Models;
using JSONParser.Services.Services.Interface;
using Newtonsoft.Json.Linq;

namespace JSONParser.Services.Services
{
    public class EmployeeSalaryProcessing: IJSONProcessing
    {
        ISalaryDivisionCalculator salaryDivisionCalculator;
       
        public Dictionary<string, int> ComputeMonthlySalary(List<EmployeeModel> ListOfEmployee)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (EmployeeModel e in ListOfEmployee)
            {
                int TaxedSalary = 0;
                 if(e.salary > 1000)
                {
                    salaryDivisionCalculator = new SalaryTaxCalculatorForRich();
                    TaxedSalary = salaryDivisionCalculator.MedianCalculator(e.salary);
                }
                else
                {
                    salaryDivisionCalculator = new SalaryTaxCalculatorForRich();
                    TaxedSalary = salaryDivisionCalculator.MedianCalculator(e.salary);
                }
                dict.Add(e.FirstName, TaxedSalary);

            } 

            return dict;
        }
    }
}
