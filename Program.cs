using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee o1 = new Employee("Abhishek", 40000, 10);
            Console.WriteLine(o1.P1 + " " + o1.P2 + " " + o1.P3 + " " + o1.P4);
            Console.WriteLine(o1.GetNetsalary());
            Console.ReadLine();

            Employee o2 = new Employee("leena", 20000);
            Console.WriteLine(o2.P1 + " " + o2.P2 + " " + o2.P3);
            Console.WriteLine(o2.GetNetsalary());
            Console.ReadLine();




            Employee o3 = new Employee("Lalita");
            Console.WriteLine(o3.P1 + " " + o3.P2 + " " + o3.P3 + " " + o3.P4);
            Console.ReadLine();
            Console.WriteLine(o3.GetNetsalary());


            Employee o4 = new Employee();
            Console.WriteLine(o4.GetNetsalary());
            Console.WriteLine(o4.P1 + " " + o4.P2 + " " + o4.P3 + " " + o4.P4);

            Console.WriteLine(o4.P1 + " " + o4.P2 + " " + o4.P3 + " " + o4.P4);

            Console.WriteLine(o3.P1 + " " + o3.P2 + " " + o3.P3 + " " + o3.P4);

            Console.WriteLine(o2.P1 + " " + o2.P2 + " " + o2.P3);

            Console.WriteLine(o1.P1 + " " + o1.P2 + " " + o1.P3 + " " + o1.P4);

            Console.ReadLine();
        }


    }

    class Employee
    {
        string name;
        static int empno;
        decimal basic;
        short deptno;

        public decimal GetNetsalary()
        {
            decimal netsal;
            netsal = basic + 900;

            return netsal;
        }

        public string P1
        {

            set
            {



                if (value == "")
                {
                    Console.WriteLine("null values");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }

        public int P2
        {
            get;

        }

        public decimal P3
        {
            set
            {
                if (value <= 50000 && value >= 10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("salary is invalid");
                }
            }
            get
            {
                return basic;
            }
        }

        public short P4
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            get
            {
                return deptno;
            }
        }

        public Employee(string name, decimal basic, short deptno)
        {

            this.P1 = name;
            empno++;
            this.P2 += empno;
            this.P3 = basic;
            this.P4 = deptno;
        }
        public Employee(string name, decimal basic)
        {
            this.P1 = name;
            empno++;
            this.P2 += empno;
            this.P3 = basic;
        }

        public Employee(string name)
        {
            this.P1 = name;
            empno++;
            this.P2 += empno;

        }

        public Employee()
        {
            empno++;
            this.P2 += empno;
        }
    }
}