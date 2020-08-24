using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp
{
    class Diary
    {
        Dictionary<KeyEntry, Dictionary<int, string>> diaryEntries;
        public KeyEntry CurrentMonth;
        public int[] ActiveButtons()
        {
            if (!diaryEntries.ContainsKey(CurrentMonth))
                return new int[1] {0};

            return
                diaryEntries[CurrentMonth].Keys.ToArray();
        }
        public void RemoveEntry(int day)
        {
            if (!diaryEntries.ContainsKey(CurrentMonth))
                return;
            diaryEntries[CurrentMonth].Remove(day);
        }
        public string GetEntry(int day)
        {
            string text = "";
            if (!diaryEntries.ContainsKey(CurrentMonth))
                return text;
            Dictionary<int, string> monthDiary = diaryEntries[CurrentMonth];
            if (!monthDiary.ContainsKey(day))
                return text;
            else
                return monthDiary[day];
        }

        public Diary()
        {
            diaryEntries = new Dictionary<KeyEntry, Dictionary<int, string>>(new KeyEntryEqualityComparer());
            CurrentMonth = new KeyEntry();
        }

        public void AddEntry(int day, string entry)
        {
            if (!diaryEntries.ContainsKey(CurrentMonth))
                diaryEntries.Add(CurrentMonth, new Dictionary<int, string>());

            Dictionary<int, string> monthDiary = diaryEntries[CurrentMonth];

            if (!monthDiary.ContainsKey(day))
                monthDiary.Add(day, entry);
            else
                monthDiary[day] = entry;
        }
    }
}
