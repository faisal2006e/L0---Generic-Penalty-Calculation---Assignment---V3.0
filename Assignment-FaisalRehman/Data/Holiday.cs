using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Data
{
    public class Holiday
    {
        public int HolidayId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string CountryId { get; set; }
    }
}
