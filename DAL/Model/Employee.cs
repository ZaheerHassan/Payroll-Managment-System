using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public  enum EmployeeType
    {
OnShore,
OffShore,
DailyWages
    };
  
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public decimal Pay { get; set; }
        public Boolean Active { get; set; }

    }
}
