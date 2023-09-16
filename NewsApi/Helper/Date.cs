using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.service
{
    public class Date
    {
        // تبدیل تاریخ شمسی به تاریخ میلادی و دریافت ان در
        // ApiHelper
        public DateTime ConvertSystemShamsiToGregorian()
        {
            try
            {
                // گرفتن تاریخ شمسی سیستم
                DateTime systemShamsiDate = DateTime.Now;
                string time =systemShamsiDate.ToString("dd/MM/yyyy");



                // تبدیل تاریخ شمسی سیستم به تاریخ میلادی
                PersianCalendar persianCalendar = new PersianCalendar();
                DateTime gregorianDate = persianCalendar.ToDateTime(systemShamsiDate.Year, systemShamsiDate.Month, systemShamsiDate.Day, 0, 0, 0, 0);
               


                

                return (gregorianDate);
            }
            finally { }
            
        }


    }
}
