using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Denumire { get; set; }

        public override string ToString() => Denumire;
    }
}
