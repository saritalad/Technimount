using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{
    public partial class Employee
    {
        public Employee(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return "Id " + Id + "Name : " + Name;
        }

    }
}
