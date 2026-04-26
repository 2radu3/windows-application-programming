using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string TitluAcademic { get; set; }
        //public string Departamentul { get; set; }

        public override string ToString() => $"{TitluAcademic} {Nume} {Prenume}";
    }
}
