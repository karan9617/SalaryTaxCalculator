using System;
using JSONParser.Services.Services.Interface;

namespace JSONParser.Services.Services
{
    public class SalaryTaxCalculatorForRich: ISalaryDivisionCalculator
    {
        public SalaryTaxCalculatorForRich()
        {
        }

        public int MedianCalculator(int SalaryOfEmployee)
        {
            return (SalaryOfEmployee - ((SalaryOfEmployee / 100) * 13));
        }
    }
}
