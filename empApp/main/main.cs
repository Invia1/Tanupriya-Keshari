using SmallEmployeeApp.Models;
using System;
using SmallEmployeeApp.Services;

namespace SmallEmployeeApp.UI
{
    class MainApp
    {
        public static void Main(string[] args)
        {

            EmployeeOperation ES = new EmployeeOperation();

            int num;
        Label:

            do
            {

                Console.WriteLine("press 1 for add data:");
                Console.WriteLine("press 2 for remove data:");
                Console.WriteLine("press 3 for update data:");
                Console.WriteLine("press 4 for search data:");
                Console.WriteLine("press 5 to get employee list:");
                Console.WriteLine("press 0 to exit:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0 && num <= 5)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("please Enter the details of a Employee:");
                            var Emp = new Employee();

                            Console.WriteLine("enter employee Id");
                            Emp.EId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("enter employee name");
                            Emp.EName = Console.ReadLine();

                            Console.WriteLine("enter employee Age");
                            Emp.EAge = Convert.ToInt32(Console.ReadLine());


                            ES.CreateEmployee(Emp);
                            break;


                        case 2:
                            Console.WriteLine("please enter the employee id of which employee you want to remove:");
                            int EmployeeId = Convert.ToInt32(Console.ReadLine());
                            ES.RemoveEmoloyee(EmployeeId);

                            break;
                        case 3:
                            Console.WriteLine("please enter the employee id of which employee you want to update:");
                            EmployeeId = Convert.ToInt32(Console.ReadLine());
                            ES.UpdateEmoloyee(EmployeeId);

                            break;

                        case 4:

                            Console.WriteLine("please enter the employee id of which employee you want to search:");
                            EmployeeId = Convert.ToInt32(Console.ReadLine());
                            ES.SearchEmployee(EmployeeId);


                            break;
                        case 5:
                            List<Employee> objl = ES.GetEmployeeList();

                            if (objl.Count > 0)
                            {
                                Console.WriteLine("------------data in your list---------");
                                Console.WriteLine("Employee name   Employee id   Employee age");
                                foreach (var item in objl)
                                {
                                    Console.WriteLine($"{item.EName}                {item.EId}             {item.EAge}");
                                }

                            }
                            else
                            { Console.WriteLine("as of now your data list is empty"); }



                            break;


                        case 0:
                            Console.WriteLine("thank you");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("please enter valid number:");
                    goto Label;
                }



            } while (num != 0);



        }
    }
}