using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp
{
    //Ключь с парным значением месяц год
    class KeyEntry
    {
        public int Month;
        public int Year;
        public KeyEntry()
        {
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
        }
        public KeyEntry(int month, int year)
        {
            Month = month;
            Year = year;
        }
        public void ChangeMonth(int value)
        {
            DateTime date = new DateTime(Year, Month, 1);
            date = date.AddMonths(value);
            Month = date.Month;
            Year = date.Year;
        }
        public override string ToString() => $"{new DateTimeFormatInfo().GetAbbreviatedMonthName(Month)} {Year.ToString()}";
    }

    //Определяем свой компарер для проверки по значению в дикшонари
    class KeyEntryEqualityComparer : IEqualityComparer<KeyEntry>
    {
        public bool Equals(KeyEntry x, KeyEntry y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Month == y.Month && x.Year == y.Year)
                return true;
            else
                return false;
        }

        public int GetHashCode(KeyEntry obj)
        {
            int hCode = obj.Month ^ obj.Year;
            return hCode.GetHashCode();
        }
    }
}
