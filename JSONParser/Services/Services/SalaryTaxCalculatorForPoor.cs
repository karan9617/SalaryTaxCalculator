using System;
using JSONParser.Services.Services.Interface;

namespace JSONParser.Services.Services
{
    public class SalaryTaxCalculatorForPoor: ISalaryDivisionCalculator
    {
        public SalaryTaxCalculatorForPoor()
        {
        }

        public int MedianCalculator(int SalaryOfEmployee)
        {
            return (SalaryOfEmployee - ((SalaryOfEmployee / 100) * 10));
        }
    }
}
