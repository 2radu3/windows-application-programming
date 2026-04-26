using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Sala
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public int Capacitate { get; set; }
        public string Tip { get; set; }

        public override string ToString() => Denumire;
    }
}
