using SchoolClassProject;

SchoolClass kilencA=new SchoolClass(9,"a",7000,30);
SchoolClass kilencB = new SchoolClass(9, "b", 6000,30);

if (kilencA.IsPayingMore(kilencB))
    Console.WriteLine($"{kilencA.evfolyam}.{kilencA.osztaly} osztály diákjai  havonta {kilencA.haviPenz - kilencB.haviPenz} forinttal többet fizetnek osztálypénzbe, mint {kilencB.evfolyam}.{kilencB.osztaly}  osztály tanulói.");
else if (kilencB.IsPayingMore(kilencA))
    Console.WriteLine($"{kilencB.evfolyam}.{kilencB.osztaly}  osztály diákjai  havonta {kilencB.haviPenz - kilencA.haviPenz} forinttal többet fizetnek osztálypénzbe, mint {kilencA.evfolyam}.{kilencA.osztaly} osztály tanulói.");
else
    Console.WriteLine($"{kilencA.evfolyam}.{kilencA.osztaly}  és {kilencB.evfolyam}.{kilencB.osztaly}  osztály tanulói ugyan annyit fizetnek osztálypénzbe! havonta.");

Console.WriteLine(kilencA.SumPayment());
Console.WriteLine(kilencB.SumPayment());