using System;
using System.Collections.Generic;
using System.Text;

namespace Fileiodemo
{
    [Serializable]
    public class Employee
    {
        public  int eid;
        public string name;
        public int _eid
        {
            get
            {
                return eid;
            }
            set
            {
                eid = value;
            }
        }
        public string _ename
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
