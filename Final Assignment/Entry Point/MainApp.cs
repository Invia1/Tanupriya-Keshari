using System;
using System.Collections.Generic;
using Final_Assignment.BLL;
using Final_Assignment.Model;

namespace Final_Assignment.Entry_Point
{
    class MainApp
    {
        public static void Main()
        {
            HospitalManagement hm = new HospitalManagement();
            int n;

            Console.WriteLine("\n\t\t\t\t\t|---------------------------------------|");
            Console.WriteLine("\t\t\t\t\t|--------WELCOME TO RIM HOSPITAL--------|");
            Console.WriteLine("\t\t\t\t\t|---------------------------------------|");

            do
            {
            Label:
                Console.WriteLine("\nEnter 1 to Add Patient details  \n" +
                                  "Enter 2 to show all the Patient details you have entered \n" +
                                  "Enter 0 to exit");
                n = int.Parse(Console.ReadLine());
                if (n >= 0 && n <= 2)
                {
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Patients Details will be filled here");
                            Console.WriteLine("How many Patient Details you would like to add");
                            int np = int.Parse(Console.ReadLine());

                            for (int i = 0; i < np; i++)
                            {
                                var objp = new Patient();
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("\nPls Enter your registration Id here");
                                objp.RID = int.Parse(Console.ReadLine());

                                if (IsDuplicatePatient(objp))
                                {
                                    Console.WriteLine("A patient with the same Aadhar card already exists.");
                                    return;
                                }
                                Console.WriteLine("Pls Enter your First Name");
                                objp.FirstName = Console.ReadLine();

                                Console.WriteLine("Pls Enter your Last Name");
                                objp.LastName = Console.ReadLine();

                                Console.WriteLine("Pls Enter your Phone Number");
                                objp.PhNo = long.Parse(Console.ReadLine());

                                Console.WriteLine("Pls Enter your Gender");
                                objp.Gender = Console.ReadLine();

                                Console.WriteLine("Pls Enter your Age");
                                objp.Age = int.Parse(Console.ReadLine());

                                Console.WriteLine("Pls Enter your Address");
                                objp.Address = Console.ReadLine();

                                Console.WriteLine("Pls Enter your Adhar No");
                                objp.AdharNo = long.Parse(Console.ReadLine());

                                Console.WriteLine("Press Enter to select the department");
                                objp.Specialist = Console.ReadLine();

                                hm.AddPatientDetails(objp);
                                Console.WriteLine("\n");

                                bool IsDuplicatePatient(Patient obj)
                                {
                                    foreach (var patient in objp)
                                    {
                                        if (patient.AadharNo == objp.AdharNo)
                                        {
                                            return true;
                                        }
                                    }
                                    return false;
                                }
                            }
                             
                            break;
                        case 2:
                            List<Patient> objl = hm.GetPatientList();

                            if (objl.Count > 0)
                            {
                                Console.WriteLine("\t\t\tThank You For Your Patience\n\t\t\tPateint Details Will be Shown Here\n------------------------------------------------------------");
                                foreach (var item in objl)
                                {
                                    Console.WriteLine($"Registration id: {item.RID}\nFirst name: {item.FirstName}\nLast name: {item.LastName}\nPhone Number: {item.PhNo}\nGender is: {item.Gender}Age: {item.Age}\nAddress: {item.Address}\nAdhar Number: {item.AdharNo}\nSpeciality To Be Consulted is: {item.Specialist}");

                                }

                            }
                            else
                            { Console.WriteLine("OOps!!Your data list is empty"); }


                            break;
                        case 0:
                            Console.WriteLine("THANK YOU FOR VISITING RIM HOSPITAL");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("please enter valid number:");
                    goto Label;
                }
            }
                while (true);

        }
    }
}
