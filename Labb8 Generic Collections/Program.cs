using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(001, "Milena Damnjanovic", "Female", 41000);
            Employee employee2 = new Employee(002, "Emilia Tarchol", "Female", 55000);
            Employee employee3 = new Employee(003, "Viktor Uppman", "Male", 45000);
            Employee employee4 = new Employee(004, "Mats Andersson", "Male", 70000);
            Employee employee5 = new Employee(005, "Emil Broberg", "Male", 43000);
            
            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (Employee employee in employeeStack)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                employee.PrintInfo();
                Console.ForegroundColor = ConsoleColor.White;                
                Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            }

            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------");

            
            
            employee5.PrintInfo();
            employeeStack.Pop();
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            employee4.PrintInfo();
            employeeStack.Pop();
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            employee4.PrintInfo();
            employeeStack.Pop();
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            employee2.PrintInfo();
            employeeStack.Pop();
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            employee1.PrintInfo();
            employeeStack.Pop();
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
           
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("-----------------------------------------------");

            var name = employeeStack.Peek();
            var name2 = employeeStack.Peek();
            Console.WriteLine(name.Name);
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            Console.WriteLine(name2.Name);
            Console.WriteLine($"There are {employeeStack.Count} employees left in the stack.");
            bool boolieroonie = employeeStack.Contains(employee3);

            if (boolieroonie == true)
            {
                Console.WriteLine($"{employee3.Name} is in the stack");
            }

            List <Employee> employeeList = new List<Employee> ();
            
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            boolieroonie = employeeList.Contains(employee3);

            if (boolieroonie == true)
            {
                Console.WriteLine($"{employee3.Name} is in the list");
            }

            Console.WriteLine();

            Console.WriteLine(employeeList.Find(employee => employee.Gender == "Male" ).Name + " is male.");

            List <Employee> maleEmployees = employeeList.FindAll(employee => employee.Gender == "Male");

            foreach (Employee employee in maleEmployees)
            {
                employee.PrintInfo();
            }

            Console.ReadKey();
        }
    }
}
