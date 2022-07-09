using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{
public    enum Department { Production,Designing,Sales,IT, Accounts,HR };// labeled integers
    class Use_Optional_namedParameters
    {
        static void Main()
        {

            // named parameters  syntx can be used as follows 


            GetEmployeeDetails(firstname: "Amol",id: 2, lastname: "Kolhe");
           // call by values; sequence should be 
            GetEmployeeDetails(1, "Amol", "kolhe", 35000,Department.Designing);

            GetEmployeeDetails(id: 2, lastname: "Deshmukh", firstname: "Akash", dept: Department.HR);

            GetEmployeeDetails(id: 2, lastname: "Deshmukh", firstname: "Akash", sal:34000);
            GetEmployeeDetails(id: 2, lastname: "Deshmukh", firstname: "Akash");
        }
        // seting default value for last variable is compulsory if you want other  default paramters 
        public static void GetEmployeeDetails(int id,string firstname,string lastname,decimal sal=45000,Department dept=Department.Designing)
        {

            // string interpolation syntax
            Console.WriteLine($"Employee details :{id} Name: {firstname} {lastname} Salary ${sal}/only department :{dept}");

        }


    }
}
