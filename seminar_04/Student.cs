using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_04
{
    [Serializable]
    internal class Student
    {
        private string nume;
        private string facultate;
        private int[] note;
        private float medie;

        public Student(string nume, string facultate, int[] note) {
            this.nume = nume;
            this.facultate = facultate;
            this.note = note;
            
        }

        public string Nume { get => nume; set => nume = value; }
        public string Facultate { get => facultate; set => facultate = value; }
        public int[] Note { get => note; set => note = value; }
        public float Medie { get => medie; set => medie = value; }

        public void CalculeazaMedie() {
            foreach(int nota in note) {
                medie += nota;
            }
            medie /= note.Length;
        }

        public override string ToString() {
            return $"{Nume} | {Facultate} | {medie}"; //pt ca suntem in clasa, cand suntem in afara folosim Medie
        }
        
        
    }
}
