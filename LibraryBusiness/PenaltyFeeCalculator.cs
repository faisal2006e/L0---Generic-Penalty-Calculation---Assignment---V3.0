using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness
{
   
    public class PenaltyFeeCalculator
    {
        public NameValueCollection settingList { get; set; }
        private  decimal DailyPenaltyFee = 0;
        private  int PenaltyAppliesAfter = 0;

        public PenaltyFeeCalculator()
        {
           
        }

        public dynamic Calculate(int days)
        {
            foreach (string key in settingList.AllKeys)
            {
                if (key == "DailyPenaltyFee")
                {
                    DailyPenaltyFee = Convert.ToDecimal(settingList.Get(key));
                }

                if (key == "PenaltyAppliesAfter")
                {
                    PenaltyAppliesAfter = Convert.ToInt32(settingList.Get(key));
                }
            }

            var TotalPrice = days > PenaltyAppliesAfter ? (days - PenaltyAppliesAfter) * DailyPenaltyFee : 0;
            return new { TotalPrice = TotalPrice };
        }

       
    }
}
