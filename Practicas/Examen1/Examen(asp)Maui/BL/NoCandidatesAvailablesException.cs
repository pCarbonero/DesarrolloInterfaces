using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class NoCandidatesAvailablesException: Exception
    {
        public NoCandidatesAvailablesException() { }
        public NoCandidatesAvailablesException(string message) : base(message) { }
    }
}
