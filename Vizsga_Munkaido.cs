using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgamunkaido
{
    class Vizsga_Munkaido
    {
        private int id;
        private int dolgozID;
        private DateTime mettol;
        private DateTime meddig;
        private int tulora;

        public int Id { get => id; set => id = value; }
        public int DolgozID { get => dolgozID; set => dolgozID = value; }
        public DateTime Mettol { get => mettol; set => mettol = value; }
        public DateTime Meddig { get => meddig; set => meddig = value; }
        public int Tulora { get => tulora; set => tulora = value; }

        public Vizsga_Munkaido(int id, int dolgozID, DateTime mettol, DateTime meddig, int tulora)
        {
            Id = id;
            DolgozID = dolgozID;
            Mettol = mettol;
            Meddig = meddig;
            Tulora = tulora;
        }
    }
}
