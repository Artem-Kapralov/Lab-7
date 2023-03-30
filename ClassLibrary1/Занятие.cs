using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Занятие
    {
        public string Date { get; }
        public Дисциплина Дисциплина { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public Вид Вид { get; }

        public Занятие(string date, Дисциплина дисциплина, Аудитория аудитория, Группа группа, Пара пара, Вид вид)
        {
            this.Date = date;
            this.Дисциплина = дисциплина;
            this.Аудитория = аудитория;
            this.Группа = группа;
            this.Пара = пара;
            this.Вид = вид;

        }
    }
}
