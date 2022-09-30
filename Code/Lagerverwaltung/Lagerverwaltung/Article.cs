using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung
{
    public class Article
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Variante { get; set; }
        public int Anzahl { get; set; }
        public String Raum { get; set; }
        public int Regal { get; set; }
        public int Fach { get; set; }

    }
}
