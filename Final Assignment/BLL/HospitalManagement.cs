using Final_Assignment.Model;
using System.Collections.Generic;

namespace Final_Assignment.BLL
{
    class HospitalManagement
    {
        Patient patient = new Patient();
        static List<Patient> obj = new List<Patient>();

        public void AddPatientDetails(Patient data)
        {
            obj.Add(data);
        }
       public  List<Patient> GetPatientList()
        {
            return obj;
        }
      
    }
}