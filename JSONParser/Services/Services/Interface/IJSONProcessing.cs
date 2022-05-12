using System;
using System.Collections.Generic;
using JSONParser.Models;
using Newtonsoft.Json.Linq;

namespace JSONParser.Services.Services
{
    public interface IJSONProcessing
    {
        public Dictionary<string, int> ComputeMonthlySalary(List<EmployeeModel> JSONObj);
    }
}
