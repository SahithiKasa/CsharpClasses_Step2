using System;
using HrDepartment;
using FinanceDepartment;
using DevelopmentDepartment;
namespace MainProgram
{


    class MainProgram
    {
        public static void Main()
        {
            HrDepartment.Responsibility1 hr = new HrDepartment.Responsibility1();
            Console.WriteLine(hr.Responsibility);



            FinanceDepartment.Responsibility2 finance = new FinanceDepartment.Responsibility2();
            Console.WriteLine(finance.Responsibility);


            DevelopmentDepartment.Responsibility3 develop = new DevelopmentDepartment.Responsibility3();
            Console.WriteLine(develop.Responsibility);

        }
    }
}