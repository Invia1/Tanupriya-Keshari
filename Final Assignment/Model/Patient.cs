using System;

namespace Final_Assignment.Model
{
    class Patient
    {
        int registrationId;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhNo { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public long AdharNo { get; set; }

        string SpecialityToBeConsulted;

        public int RID
        {
            get
            {
                return registrationId;
            }
            set
            {
                registrationId = value;
                int i = registrationId;
            }

        }

        public string Specialist
        {
            get
            {
                return SpecialityToBeConsulted;
            }
            set
            { 
                SpecialityToBeConsulted = value;
                Console.WriteLine("Press 1 for GENERAL MEDICINE\n" + "Press 2 for ORTHOPEADICS\n" + "Press 3 for DENTAL\n");
                int i = int.Parse(Console.ReadLine());
                if(i<=3)
                    switch(i)
                    {
                        case 1:
                            Console.WriteLine("You will go in General Medicine department");
                            break;

                        case 2:
                            Console.WriteLine("You will go in Orthopaedics department");
                            break;

                        case 3:
                            Console.WriteLine("You will go in Dental department");
                            break;
                    }

            }
        }
    }
}
