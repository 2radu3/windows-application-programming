using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_06
{
    class Student {
        public int matricol;
        public string nume;
        public float medie;

        public Student (int matricol, string nume, float medie) {
            this.matricol = matricol;
            this.nume = nume;
            this.medie = medie;
        }

        public override string ToString() {
            return "Studentul " + nume + " are matricolul " + matricol + " si media " + medie;
        }
    }
}
