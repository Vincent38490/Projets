using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partie3link
{
    internal class Technicien
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Technicien(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
    }

}
