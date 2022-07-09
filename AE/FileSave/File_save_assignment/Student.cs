using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Exercise_10
{
    class Student
    {
        int roll;
        string name;
        double marks;

        public Student()
        {
            roll = 0;
            name = null;
            marks = 0;
        }

        public Student(int roll,string name,double marks)
        {
            this.roll = roll;
            this.name = name;
            this.marks = marks;
        }

        public int RollNo
        {
            get
            {
                return this.roll;
            }
            set
            {
                this.roll = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        }

        public double Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public string Display()
        {
            return "Roll No : "+ RollNo +" \nName : " + Name + "\nMarks : " + Marks +"\n";
        }
    }
}
