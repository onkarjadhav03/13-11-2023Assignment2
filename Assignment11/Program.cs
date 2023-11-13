using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            string choose;
            Console.WriteLine("choose type hr\n admin\n software developer");
            choose = Console.ReadLine();


         
            int projectHandles,extras, workingHours, numberOfWorkingDays;

            if (choose == "hr")
            {

                Console.WriteLine("Enter working hours:");
                workingHours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of working days:");
                numberOfWorkingDays = int.Parse(Console.ReadLine());
                obj.Add(workingHours,numberOfWorkingDays);
            }
            else if (choose == "admin")
            {
                Console.WriteLine("Enter working hours:");
                workingHours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of working days:");
                numberOfWorkingDays = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of project handles by admin:");
                projectHandles = int.Parse(Console.ReadLine());
                obj.Add(workingHours,numberOfWorkingDays,projectHandles);
            }
            else if(choose=="software developer")
            {
                Console.WriteLine("Enter working hours:");
                workingHours = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of working days:");
                numberOfWorkingDays = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of project handles for Software Developer:");
                projectHandles = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of extras for Admin/Software Developer:");
                extras = int.Parse(Console.ReadLine());
                obj.Add(workingHours,numberOfWorkingDays,projectHandles,extras);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
        }
    }
}
