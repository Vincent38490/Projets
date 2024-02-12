using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partie3link
{
    internal class Personne
    {
        public string Nom{ get; set; }
        public string Prenom { get; set; }
        public bool Est_ingenieur { get; set; }
        public Personne(string nom, string prenom, bool ingenieur)
        {
            Nom = nom;
            Prenom = prenom;
            Est_ingenieur = ingenieur;
        }
    }
}
