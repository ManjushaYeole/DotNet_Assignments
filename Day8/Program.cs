using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Lambda
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter employee salary");
            int sal = Convert.ToInt32(Console.ReadLine());
            Employee e = new Employee(sal);
            
            Func<Employee, int> o3 = x => x.BasicSal;
            Console.WriteLine(o3(e));

            Func<decimal, decimal, decimal, decimal> o1 = (p, n, r) => p * n * r / 100;
            Console.WriteLine(o1(2, 3, 12));

            Func<int, int, bool> o2 = (a, b) => a > b;
            Console.WriteLine(o2(5, 8));

            Predicate<int> o4 = a => a % 2 == 0;
            Console.WriteLine(o4(10));

            Predicate<Employee> o5 = emp => emp.BasicSal > 10000;
            Console.WriteLine(o5(e));

            Console.ReadLine();


           
        }
        static int getBasic(Employee e)
        {
            return e.BasicSal;
        }
    }
    public class Employee
    {
        private int basicSal;
        public int BasicSal
        {
            get;
            set;
        }
        public Employee(int basicSal)
        {
            this.BasicSal = basicSal;
        }
        static decimal SimpleInterest(decimal P,decimal N,decimal R)
        {
            return P * N * R / 100;
        }

       
        static bool IsGreater(int a,int b)
        {
            return a > b;
        }

        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        static bool ISGreaterThan10000(Employee e)
        {
            return e.BasicSal > 10000;
        }
        
    }
}
