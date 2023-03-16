using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Аудитория
    {
        private readonly string название;
        private readonly Сотрудник сотрудник;
        private readonly uint количество_посадочных_мест;
        private readonly uint количество_окон;
        private readonly List<Оборудование> оборудование;

        public Сотрудник Сотрудник { get => сотрудник; }
        public List<Оборудование> Оборудование { get => оборудование; }

        public Аудитория(string название, Сотрудник сотрудник, uint количество_посадочных_мест, uint количество_окон, List<Оборудование> оборудование)
        {
            this.название = название;
            this.сотрудник = сотрудник;
            this.количество_посадочных_мест = количество_посадочных_мест;
            this.количество_окон = количество_окон;
            this.оборудование = оборудование;
        }
    }
}
