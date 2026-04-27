using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_test_2
{
    internal class Firma
    {
        string numeFirma;
        List<Angajat> listaAngajati;

        public Firma(string numeFirma)
        {
            this.numeFirma = numeFirma;
        }

        public string NumeFirma { get => numeFirma; set => numeFirma = value; }
        internal List<Angajat> ListaAngajati { get => listaAngajati; set => listaAngajati = value; }

        public override string ToString()
        {
            string angajati = string.Join(", ", listaAngajati);
            return $"\nNume firma: {numeFirma} " + $"\nLista angajati: {listaAngajati} ";
        }

        public static Firma operator +(Firma f, Angajat a)
        {
            if(f != null && a != null)
            {
                f.listaAngajati.Add(a);
            }
            return f;
        }

        public Angajat this[int index]
        {
            get
            {
                if(index != null && index >=0 && index < listaAngajati.Count)
                {
                    return listaAngajati[index];
                } else
                {
                    return null;
                }
            }
           
        }

    }
}
