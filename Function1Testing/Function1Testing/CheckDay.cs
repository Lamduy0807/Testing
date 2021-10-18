using System;

namespace Function1Testing
{
    public class CheckDay
    {
        public int CheckDayinMonth(int month, int year)
        {
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1: return 31;
                    case 3: return 31;
                    case 5: return 31;
                    case 7: return 31;
                    case 8: return 31;
                    case 10: return 31;
                    case 12: return 31;
                    case 4: return 30;
                    case 6: return 30;
                    case 9: return 30;
                    case 11: return 30;

                    case 2:
                        {
                            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))    // nam nhuan
                                return 29;
                            else
                                return 28;
                        }
                }
            }
            return 0;
        }
        public bool IsValidDate(int day, int month, int year)
        {
            if (month >= 1 && month <= 12)
            {
                if (day >= 1) {
                    if (day <= CheckDayinMonth(month, year))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
           
        }
    }
}
