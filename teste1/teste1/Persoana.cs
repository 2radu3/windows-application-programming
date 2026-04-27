using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    [Serializable]
    internal class Persoana
    {
        string nume;
        string prenume;
        int varsta;

        public Persoana(string nume, string prenume, int varsta)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Varsta = varsta;
        }

        public string Nume { get => nume; set {
                if(value != null && value.Length > 2)
                {
                    nume = value;
                }
                else
                {
                    return;
                }
            } 
        }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Varsta { get => varsta; set => varsta = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
