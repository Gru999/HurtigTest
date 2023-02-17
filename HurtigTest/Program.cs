
using HurtigTest;
using System.Security.Cryptography.X509Certificates;


//Opgave 1
Cykel c1 = new Cykel(12345, "Everton", 2013);
Cykel c2 = new Cykel(67890, "Mountain bike", 2010);
Cykel c3 = new Cykel(11111, "Racer cykel", 2023);
Cykel c4 = new Cykel(10001, "Everton", 2021);

//Opgave 2
List<Cykel> cykelList = new List<Cykel>();
cykelList.Add(c1);
cykelList.Add(c2);
cykelList.Add(c3);
cykelList.Add(c4);

//Opgave 3
Console.WriteLine("\nOpgave 3");
foreach (Cykel c in cykelList) {
    if (c.År > 2020) {
        Console.WriteLine(c.ToString());
    }
}


//Opgave 4
Console.WriteLine("\nOpgave 4");

Cykel lowestNr = cykelList.OrderBy(x => x.StelNr).First();
Console.WriteLine(lowestNr.ToString());  


//Opgave 5
Console.WriteLine("\nOpgave 5");
List<Cykel> cykelSorter = cykelList.OrderByDescending(x => x.StelNr).ToList();
cykelSorter.ForEach(x => Console.WriteLine(x.ToString()));


//Opgave 6
Console.WriteLine("\nOpgave 6");

List<Cykel> everton = cykelList.FindAll(x => x.Model.Equals("Everton"));

everton.ForEach(x => Console.WriteLine(x.ToString()));

 