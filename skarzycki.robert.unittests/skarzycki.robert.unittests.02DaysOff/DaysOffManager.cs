using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skarzycki.robert.unittests._02DaysOff
{
    public class DaysOffManager
    {
        public int GetAvailableDaysOff(Employee employee)
        {
            if(employee != null)
                throw new ArgumentNullException(nameof(employee));

            var availableDays = employee.HasExperience ? 26 : 20;

            if (employee.Hired.Year < DateTime.Today.Year)
            {
                return availableDays;
            }
            else
            {
                return (DateTime.Today.Month - employee.Hired.Month)/12*availableDays;
            }
        }
    }
}
