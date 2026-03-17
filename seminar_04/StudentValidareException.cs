using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_04
{
    internal class StudentValidareException:Exception {
        public StudentValidareException(string message) : base (message) { }
    }
}
