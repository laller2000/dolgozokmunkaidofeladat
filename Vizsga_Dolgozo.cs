using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgamunkaido
{
    class Vizsga_Dolgozo
    {
        private int id;
        private string vezeteknev;
        private string keresztnev;
        private string adoszam;
        private string anyjaneve;

        public int Id { get => id; set => id = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Adoszam { get => adoszam; set => adoszam = value; }
        public string Anyjaneve { get => anyjaneve; set => anyjaneve = value; }

        public Vizsga_Dolgozo(int id, string vezeteknev, string keresztnev, string adoszam, string anyjaneve)
        {
            Id = id;
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            Adoszam = adoszam;
            Anyjaneve = anyjaneve;
        }
    }
}
