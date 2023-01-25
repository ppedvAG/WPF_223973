using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templates
{
    //Bsp-Klasse
    public class PKW
    {
        public string Hersteller { get; set; }
        public int Baujahr { get; set; }

        public override string ToString()
        {
            return $"PKW: {Hersteller}";
        }
    }
}
