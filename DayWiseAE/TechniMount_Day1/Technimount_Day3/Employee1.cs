using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{
  public  partial class Employee
    {
        public int Id { get; set; }    // auto implemented property
        public string Name { get; set; }

        public Employee()
        {
            Id = 1;
            Name = "SSSS";
        }
    }
}
