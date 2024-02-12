// See https://aka.ms/new-console-template for more information

using projetLinkpartie2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


List<Dog> dogs = new List<Dog> {
 new Dog("Berger Australien", "Banzaï", 1, 28),
 new Dog("Berger Australien", "Letto", 3, 30),
 new Dog("Berger Australien", "Princesse", 8, 32),
 new Dog("Berger Allemand", "Floyd", 10, 32),
 new Dog("Caniche", "Igor", 13, 9),
 new Dog("Labrador", "Swing", 15, 25),
 new Dog("Teckel", "Wonki", 2, 5),
 new Dog("Terre Neuve", "Albator", 1, 50),
 new Dog("Carlin", "Pataud", 13, 10),
 new Dog("Boxer", "Frank", 6, 25),
 new Dog("Lévrier Afghan", "Précieuse", 9, 26),
 new Dog("Yorkshire", "Kakou", 3, 6)
 };

var Queryexo11 = from obj in dogs //Data Source
                 where obj.Race == "Berger Australien"  //Condition
                 select obj; //Selection
                             //Step3: Execution
Console.WriteLine("Les Bergers Australiens :");
foreach (var item in Queryexo11)
{
    Console.Write(item.Name + " ");
}


Console.WriteLine("\nLes Bergers Australiens :trier par nom");
var Queryexo12 = from obj in dogs //Data Source
                 orderby obj.Name
                 where obj.Race == "Berger Australien" //Condition
                 select obj; //Selection
                             //Step3: Execution

foreach (var item in Queryexo12)
{
    Console.Write(item.Name + " ");
}

Console.WriteLine("\nRécupérer tous les chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 \r\nlettres");
var Queryexo13 = from obj in dogs //Data Source
                 
                 where obj.Age > 5 && obj.Name.Length > 5  //Condition
                 select obj; //Selection
                             //Step3: Execution

foreach (var item in Queryexo13)
{
    Console.Write(item.Name + " ");
}


Console.WriteLine("\nRécupérer tous les chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 \r\nlettres puis les trier les chiens par leur poids");
var Queryexo14 = from obj in dogs //Data Source

                 where obj.Age > 5 && obj.Name.Length > 5
                 orderby obj.Weight//Condition
                 select obj; //Selection
                             //Step3: Execution

foreach (var item in Queryexo14)
{
    Console.Write(item.Name + " ");
}


Console.WriteLine("\nTrier les chiens par leur âge (tri décroissant) puis leur poids (tri croissant).");
var Queryexo15 = from obj in dogs //Data Source

                 orderby obj.Weight 
                 orderby obj.Age descending
                 select obj; //Selection
                             //Step3: Execution

foreach (var item in Queryexo15)
{
    Console.Write(item.Name + " ");
}


Console.WriteLine("\nRécupérer les noms de chien répondant aux critères suivants :\r\n- Leur nom de race tient en un seul mot\r\n- Leur poids doit être supérieur à 15 kilos\r\n- Leur nom doit contenir un \"i\"\r\n- Trier les chiens par la longueur de leur prénom");
var Queryexo16 = from obj in dogs //Data Source
                 where !obj.Race.Contains(" ") && obj.Weight > 15 && obj.Name.Contains("i")
                 orderby obj.Name.Length
                 select obj; //Selection
                             //Step3: Execution

foreach (var item in Queryexo16)
{
    Console.Write(item.Name + " ");
}
