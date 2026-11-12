
/*En vare koster 149,90 kr. Kunden kjøper 3 varer. Beregn totalprisen og legg til 50 kr i frakt.

double price = 149.90;

int antall = 3;


double totalprisen = price * antall;
double finalpris = totalprisen + 50;

Console.WriteLine($"Totalpris: {totalprisen}");
Console.WriteLine($"finalprisen: {finalpris}");*/


//En person må være minst 15 år for å se en film. Sjekk om personen får adgang.

/*int age = 17;

bool canEnter = age >= 15;

Console.WriteLine(canEnter);*/

/*Kunden får rabatt hvis kunden enten har studentkort eller rabattkode.

bool hasstudentkort = true;
bool hasRabatt = false;

bool fårRabatt = hasRabatt || hasstudentkort;

Console.WriteLine(fårRabatt);*/

//En student må få minst 50 poeng og ha levert eksamen for å bestå.

/*int poeng = 70;
bool levert = true;

bool harBestått = poeng >= 50 && levert;

Console.WriteLine(harBestått);*/

//Kunden kan bestille en vare hvis varen er tilgjengelig og kunden har nok penger.

/*bool tilgjengelig = true;
double pris = 1500;
double balance = 2000;

bool harNokPenger = balance >= pris;

bool kanBestille = tilgjengelig && harNokPenger;

Console.WriteLine(harNokPenger);
Console.WriteLine(kanBestille);*/

//bruker skal være registetert, er verifisert og er ikke blokkert

bool isregistetert = true;
bool isverifisert = true;
bool blokkert = true;

bool canAccess = isregistetert && isverifisert && !blokkert;

Console.WriteLine(canAccess);
