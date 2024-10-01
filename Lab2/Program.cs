using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            LoadEmployees();
            Console.ReadLine();
        }

        
        public static List<Employee> LoadEmployees()
        {
            string path = "..\\..\\res\\employees.txt";
            List<Employee> employeeList = new List<Employee>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] fields = line.Split(':');
                switch (fields[0].Substring(0, 1))
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        Salaried salaried = new Salaried(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]), fields[5], fields[6], Convert.ToDouble(fields[7]));
                        employeeList.Add(salaried);
                        break;
                    case "5":
                    case "6":
                    case "7":
                        Wages wages = new Wages(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]), fields[5], fields[6], Convert.ToDouble(fields[7]), Convert.ToDouble(fields[8]));
                        employeeList.Add(wages);
                        break;
                    case "8":
                    case "9":                       
                        PartTime partTime = new PartTime(fields[0], fields[1], fields[2], fields[3], Convert.ToInt64(fields[4]), fields[5], fields[6], Convert.ToDouble(fields[7]), Convert.ToDouble(fields[8]));
                        employeeList.Add(partTime);
                        break;
                }
            }
            return employeeList;
        }
    }
}
