using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public int evfolyam;
        public string osztaly;
        public int haviPenz;
        public int osztalyLetszam;

        public SchoolClass()
        {
            evfolyam = 0;
            osztaly = string.Empty;
            haviPenz = 0;
            osztalyLetszam = 0;
        }

        public SchoolClass(int evfolyam, string osztaly, int haviPenz, int osztalyLetszam)
        {
            this.evfolyam = evfolyam;
            this.osztaly = osztaly;
            this.haviPenz = haviPenz;
            this.osztalyLetszam=osztalyLetszam;
        }

        public bool IsPayingMore(SchoolClass other)
        {
            return this.haviPenz>other.haviPenz; 
        }

        public string SumPayment()
        {
            int sum = this.haviPenz * 300;
            return $"{this.evfolyam}.{this.osztaly} 10 hónap alatt {sum} Ft-ot gyűjt össze.";
        }

        public override string ToString()
        {
            return $"{evfolyam}.{osztaly} ({haviPenz}Ft)x({osztalyLetszam} fő)";
        }
    }
}
