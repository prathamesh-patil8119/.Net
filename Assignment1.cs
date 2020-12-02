using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine("The emp1 net Salary : " + o1.getNetSalary());
            Console.WriteLine("The emp2 net Salary : " + o2.getNetSalary());
            Console.WriteLine("The emp3 net Salary : " + o3.getNetSalary());
            Console.WriteLine("The emp4 net Salary : " + o4.getNetSalary());

            Console.WriteLine(o1.empNo);
            Console.WriteLine(o2.empNo);
            Console.WriteLine(o3.empNo);
            Console.WriteLine(o4.empNo);
            Console.WriteLine(o4.empNo);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        private string empName;
        private decimal basicSal;
        private short empDeptNo;
        private decimal netSal;
        public int empNo;
        private static int count = 0;

        public Employee(string empName, decimal basicSal, short empDeptNo)
        {
            this.empName = empName;
            empNo = ++count;
            this.basicSal = basicSal;
            this.empDeptNo = empDeptNo;
        }

        public Employee(string empName, decimal basicSal)
        {
            this.empName = empName;
            empNo = ++count;
            this.basicSal = basicSal;
            empDeptNo = 10;
        }

        public Employee(string empName)
        {
            this.empName = empName;
            empNo = ++count;
            basicSal = 10000;
            empDeptNo = 10;
        }

        public Employee()
        {
            empName = "Amol";
            basicSal = 10000;
            empDeptNo = 10;
            empNo = ++count;
        }

        private short p1;
        public short P1
        {
            set
            {
                if (value < 0)
                    p1 = value;
                else
                    Console.WriteLine("Invalid Department Number : ");
            }
            get
            {
                return p1;
            }
        }

        public decimal getNetSalary()
        {
            netSal = basicSal + (basicSal / 4);
            return netSal;
        }
    }
}
