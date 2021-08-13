using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Lista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registred?: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Employee {i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the Employee id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchID);

            if (emp != null)
            {
                Console.WriteLine("Enter to the Porcentage: ");
                double porcetage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(porcetage); 
            }
            else
            {
                Console.WriteLine("This id not exists!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach (Employee obj in list )
            {
                Console.WriteLine(obj);
            }
        }
    }
}
