using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class ElementOrar
    {
        public int Id { get; set; }

        public Profesor ProfesorSarcina { get; set; }
        public Sala SalaSarcina { get; set; }
        public Disciplina DisciplinaSarcina { get; set; }

        public string Ziua { get; set; }
        public string IntervalOrar { get; set; }
        public string TipActivitate { get; set; }
    }
}
