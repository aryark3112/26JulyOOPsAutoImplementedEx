using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Id");
            customer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer City");
            customer.City = Console.ReadLine();
            Console.WriteLine("Enter Customer Over Draft Limit");
            customer.ODLimit = double.Parse(Console.ReadLine());
            Console.WriteLine("Customer Details as follows!!");
            Console.WriteLine($"ID: {customer.Id} Name: {customer.Name} ");
            Console.WriteLine($"City: {customer.City} ODLimit: {customer.ODLimit}");
            Console.ReadKey();
        }
    }
}
