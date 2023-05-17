using SmallEmployeeApp.Models;
using System;
using System.Collections.Generic;

namespace SmallEmployeeApp.Services
{
    class EmployeeOperation
    {
        Employee employee = new Employee();
        List<Employee> objlist = new List<Employee>();
        public int CreateEmployee(Employee emp)
        {
            objlist.Add(emp);
            return 1;
        }

        public void RemoveEmoloyee(int id)
        {
            for (int i = 0; i < objlist.Count; i++)
            {
                if (id == objlist[i].EId)
                {
                    objlist.RemoveAt(i);

                }

            }



        }

        public void SearchEmployee(int id)
        {
            int i;
            for (i = 0; i < objlist.Count; i++)
            {
                if (id == objlist[i].EId)
                {
                    Console.WriteLine($" id--{objlist[i].EId}");
                    Console.WriteLine($"name---{objlist[i].EName}");
                    Console.WriteLine($"age----{objlist[i].EAge}");
                    break;
                }

            }

            if (i == objlist.Count)
            {
                Console.WriteLine($" employee with id --{id} is not in your data");
            }
        }
        public void UpdateEmoloyee(int id)
        {
            Employee employee = new Employee();

            for (int i = 0; i < objlist.Count; i++)
            {
                if (id == objlist[i].EId)
                {
                    objlist.RemoveAt(i);

                    Console.WriteLine("enter new name");
                    employee.EName = Console.ReadLine();

                    Console.WriteLine("enter new id");
                    employee.EId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter new age");
                    employee.EAge = Convert.ToInt32(Console.ReadLine());

                    objlist.Add(employee);

                }

            }



        }

        public List<Employee> GetEmployeeList()
        {

            return objlist;

        }
    }
}
