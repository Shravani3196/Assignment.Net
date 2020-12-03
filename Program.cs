using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m=new Manager("Shruti", 12, 15000, "manager");
            Console.WriteLine(m.NAME+" "+m.EMPNO+" "+m.DEPTNO+" " +m.BASIC+" "+m.DES);
            Console.WriteLine(m.clacNetsalary());
            Console.ReadLine();

            GeneralManager g = new GeneralManager("chaitali", 4, 45000, "mgr", "ab");
            Console.WriteLine(g.NAME+" "+g.EMPNO+" "+g.DEPTNO+" "+g.BASIC+" "+g.DES+" "+g.PERK);
            Console.WriteLine(m.clacNetsalary());
            Console.ReadLine();
            

            //  Ceo c=new 
            Console.WriteLine(g.NAME + " " + g.EMPNO + " " + g.DEPTNO + " " + g.BASIC + " " + g.DES + " " + g.PERK);
            Console.WriteLine(m.NAME + " " + m.EMPNO + " " + m.DEPTNO + " " + m.BASIC + " " + m.DES);
            Console.ReadLine();

        }
    }
    abstract class Employee
    {
        string name;
        // int empNo;
        short deptNo;

        protected decimal basic;
        protected static int lastempno = 0;

        public string NAME
        {
            set
            {
                if (value == " ")
                {
                    Console.WriteLine("invalid name");
                }
                else
                {
                    this.name = value;
                }
            }
            get
            {
                return name;
            }

        }

        public int EMPNO
        {
            get;

        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid deptno");
                }
            }
            get
            {
                return deptNo;

            }
        }
        public abstract decimal BASIC
        {
            get;
            set;
        }
        public abstract decimal clacNetsalary();
        public Employee(string name = "shravani", short deptno = 1, decimal basic = 10000)
        {
            lastempno++;
            this.NAME = name;
            this.DEPTNO = deptNo;
            this.BASIC = basic;
        }
    }
    class Manager : Employee
    {
        string des;

        public string DES
        {
            set
            {
                if (value == " ")
                {
                    Console.WriteLine("des is empty");
                }
                else
                {
                    this.des = value;
                }

            }
            get
            {
                return des;
            }
        }

        public override decimal BASIC
        {
            set
            {
                if (value > 10000 && value < 60000)
                {
                    Console.WriteLine("invalid salary");
                }
                else
                {
                    this.basic = value;
                }

            }
            get
            {
                return basic;
            }
        }
        public override decimal clacNetsalary()
        {
            decimal netsalary = basic + 100;
            return netsalary;
        }
        public Manager(string name = "abhi", short deptno = 2, decimal basic = 20000, string des = "managr") : base(name, deptno, basic)
        {
            this.DES = des;
        }
    }
            class GeneralManager : Manager
            {
                string perk;
                public string PERK
                {
                    set
                    {
                        this.perk = value;
                    }
                    get
                    {
                        return perk;
                    }
                }
                public GeneralManager(string name = "leena", short deptno = 3, decimal basic = 30000, string des = "empe", string perk = "ss") : base(name, deptno, basic, des)
                {
                    this.PERK = perk;
                }
                public override decimal BASIC
                {
                    set
                    {
                        if (value > 10000 && value < 60000)
                        {
                            Console.WriteLine("invalid salary");
                        }
                        else
                        {
                            this.basic = value;
                        }

                    }
                    get
                    {
                        return basic;
                    }
                }
                public override decimal clacNetsalary()
                {
                    decimal netsalary = basic + 100;
                    return netsalary;
                }

                class Ceo : Employee
                {
                    public override decimal BASIC
                    {
                        get
                        {
                            return basic;
                        }
                        set
                        {
                            if (value > 30000 && value < 50000)
                                this.basic = value;
                            else
                                Console.WriteLine("invalid salary fro CEO");
                        }
                    }

                    public sealed override decimal clacNetsalary()
                    {
                        decimal netSalary = basic + 5000;
                        return netSalary;
                    }

                    //public Ceo(string name = "henry", short deptNo = 10, decimal basic = 35000) : base(name, deptNo, basic)
                    //{

                    //}
                }
            }
        }
    


                
            