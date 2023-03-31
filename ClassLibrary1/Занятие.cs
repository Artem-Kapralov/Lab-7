using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Занятие
    {
        public DateTime Date { get; }
        public Дисциплина Дисциплина { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public Вид Вид { get; }

        public Занятие(Дисциплина дисциплина, Аудитория аудитория, Группа группа, Пара пара, Вид вид, DateTime date)
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
