using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partie3link
{
    internal class Ingenieur 
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Specialite { get; set; }
        public Ingenieur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        public Ingenieur(string nom, string prenom, string specialite)
        {
            Nom = nom;
            Prenom = prenom;
            Specialite = specialite;
        }
    }
}
