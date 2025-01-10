using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class clsRespuesta
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<clsPokemon> results { get;set; }
    }
}
