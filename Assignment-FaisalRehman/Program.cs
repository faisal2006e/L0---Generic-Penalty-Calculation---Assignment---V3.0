using LibraryApplication.Data;
using LibraryBusiness;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    class Program
    {
        public static List<Country> CountryList = new List<Country>();
        public static List<Holiday> HolidayList = new List<Holiday>();

        static void Main(string[] args)
        {
            NameValueCollection settingList = ConfigurationManager.AppSettings;
            PenaltyFeeCalculator penaltyFeeCalculator = new PenaltyFeeCalculator();
            penaltyFeeCalculator.settingList = settingList;


            if (args.Length == 0)
            {
                Console.WriteLine("Invalid args");
                return;
            }

         
            DateTime dateStart;
            if (!DateTime.TryParse(args[0], out dateStart))
            {
                Console.WriteLine("Invalid date start");
                return;
            }

            DateTime dateEnd;
            if (!DateTime.TryParse(args[1], out dateEnd))
            {
                Console.WriteLine("Invalid date end");
                return;
            }

            string country = string.Empty;
            if (string.IsNullOrEmpty(args[2]))
            {
                Console.WriteLine("Invalid country");
                return;
            }

            if (!Enum.IsDefined(typeof(CountryEnum), args[2]))
            {
                Console.WriteLine("Invalid country end");
                return;
            }
            country = args[2];

            int days = GetBusinessDays(dateStart, dateEnd, country);
            penaltyFeeCalculator.Calculate(days);
        }

        public static void PrepareData()
        {
            CountryList.Add(new Country { CountryId = "TR", Name = "Turkey", Currency = "TR" });
            CountryList.Add(new Country { CountryId = "AE", Name = "United Arab Emirates", Currency = "AE" });

            HolidayList.Add(new Holiday { HolidayId = 1, Name = "Eid", Date = new DateTime(2020, 8, 1), CountryId = "TR" });
            HolidayList.Add(new Holiday { HolidayId = 2, Name = "Eid", Date = new DateTime(2020, 8, 2), CountryId = "TR" });
            HolidayList.Add(new Holiday { HolidayId = 3, Name = "Eid", Date = new DateTime(2020, 8, 3), CountryId = "TR" });
            HolidayList.Add(new Holiday { HolidayId = 4, Name = "30 Ağustos Zafer Bayramı", Date = new DateTime(2020, 8, 30), CountryId = "TR" });

        }


        public static int GetBusinessDays(DateTime startDate, DateTime endDate, string Country)
        {
            PrepareData();

            List<Holiday> l_HolidayList = new List<Holiday>();

            foreach (Holiday row in HolidayList)
            {
                if (row.CountryId == Country)
                {
                    l_HolidayList.Add(row);
                }
            }

            int TotalBusinessDays = 0;

            var holidays = l_HolidayList.Select(s => s.Date);

            var dayDifference = (int)endDate.Subtract(startDate).TotalDays;

            for (var date = startDate ; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Friday
                    && date.DayOfWeek != DayOfWeek.Saturday
                    && !holidays.Contains(date))
                    TotalBusinessDays++;
            }

            return TotalBusinessDays;
        }

      
    }
}
