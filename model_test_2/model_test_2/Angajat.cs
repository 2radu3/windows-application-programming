using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_test_2
{
    public interface ITotalSalariu
    {
        void calculeazaTotalSalariu();
    }

    internal class Angajat
    {
        private string nume;
        int oreLucrate;
        float salariuOrar;
        const char membru = 'A';
        static int nrAngajati;
        string matricol;
        float salariuLunar;

        public Angajat(string nume, int oreLucrate, float salariuOrar)
        {
            this.nume = nume;
            this.oreLucrate = oreLucrate;
            this.salariuOrar = salariuOrar;
        }

        public string Nume { get => nume; set => nume = value; }
        public int OreLucrate { get => oreLucrate; set => oreLucrate = value; }
        public float SalariuOrar { get => salariuOrar; set => salariuOrar = value; }

        public override string ToString()
        {
            return $"\nNume: {Nume} " + $"\nOre Lucrate: {oreLucrate} " + $"\nSalariu Orar: {salariuOrar} " + $"\nSalariu Lunar: {salariuLunar} " + $"\nMatricol: {matricol} " + $"\nMembru: {membru} ";
        }

        public void calculeazaTotalSalariu()
        {
            this.salariuLunar = this.oreLucrate * this.salariuOrar;
        }

        public float SalariuLunar { get => salariuLunar; }
    }
}
