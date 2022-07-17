using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Data
{
    public class Country
    {
        public string CountryId { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public List<Holiday> Holidays { get; set; }
    }
}
