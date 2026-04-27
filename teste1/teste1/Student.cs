using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1
{
    [Serializable]
    internal class Student : Persoana
    {

        const string codMatricol = "0";
        static int nrStudenti;
        string matricol;
        double medie;
        List<string> materii;

        public Student(string nume, string prenume, int varsta, string matricol, double medie, List<string> materii) : base(nume, prenume, varsta)
        {
            this.matricol = matricol;
            this.medie = medie;
            this.materii = materii;
        }

        public string Matricol { get => matricol; }
        public double Medie { get => medie; }
        public List<string> Materii { get => materii; }

        public override string ToString()
        {
            string materiiText = string.Join(", ", Materii);

            return $"\nNume: {Nume} " +
                $"\nPrenume: {Prenume} " +
                $"\nVarsta: {Varsta} " +
                $"\nMatricol: {matricol} " +
                $"\nMedie: {medie} " +
                $"\nMaterii: {materiiText}";
        }

        public static Student operator +(Student s, string materieNoua)
        {
            if(s.materii == null)
            {
                s.materii = new List<string>();
            }

            if(!string.IsNullOrWhiteSpace(materieNoua))
            {
                s.materii.Add(materieNoua);
            }

            return s;
        }

        public string this[int index]
        {
            get
            {
                if(materii != null && index>=0 && index<materii.Count)
                {
                    return materii[index];
                } else
                {
                    return "Index invalid";
                }
            }

        }
           

    }
}
