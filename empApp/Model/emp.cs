using System;
using System.Text.RegularExpressions;


namespace SmallEmployeeApp.Models
{
    class Employee
    {
        // public int EId { get; set; }
        private int _eId;
        public int EId
        {
            get
            {
                return _eId;
            }
            set
            {
                _eId = value;

            }
        }

        public string EName { get; set; }
        public int EAge { get; set; }
    }
}
