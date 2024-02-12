// See https://aka.ms/new-console-template for more information

using partie3link;


List<Personne> personnes = new List<Personne> {
 new Personne("Hallyday", "Johnny", false),
 new Personne("Vartan", "Sylvie", false),
 new Personne("Drucker", "Michel", false),
 new Personne("Antoine", "Antoine", true),
 new Personne("Philippe", "Edouard", false),
 new Personne("Demorand", "Patricia", true),
 new Personne("Ulysse", "Margareth", true),
 new Personne("Zenith", "Méryl", true),
 new Personne("Bobo", "Jojo", false)
 };

IEnumerable<Ingenieur> ingenieurs = from obj in personnes
                                    orderby obj.Nom
                                    orderby obj.Prenom
                                    where obj.Est_ingenieur
                                    select new Ingenieur(obj.Nom, obj.Prenom);



IEnumerable<Technicien> techniciens = from obj in personnes
                                      where !obj.Est_ingenieur
                               select new Technicien(obj.Nom, obj.Prenom);


Console.WriteLine("Lisres d'ingenieure trier :");
foreach (var ingen in ingenieurs)
{
    Console.WriteLine("Nom" + ingen.Nom);
}



Console.WriteLine("Lisres de Téchnicien :");
foreach (var ingen in techniciens)
{
    Console.WriteLine("Nom" + ingen.Nom);
}