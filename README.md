# console_shopping_app
Assignment for C# and .NET course (CA)


Užduotis:

Parduotuvės programa:

	- Tėvinė klasė prekė (kaina, barkodas, svoris)

Vaikinės prekės klasės:
	- Saldainiai (cukrus)
	- Mėsa (baltymai)
	- Daržovės (skaidulinės medžiagos)
	- Gėrimai (litrai)
	
	
Skirtingų tipų prekės yra saugomomos skirtinguose .csv failuose(saldainiai viename, mėsa kitame ir t.t.) (csv example: https://e.nodegoat.net/CMS/upload/guide-import_person_csv_notepad.png)
Pradėjus programai, jūsų sukurtas FileReaderService turi perskaityti visus failus ir pavertus eilutes į objektus sudėti į atitinkamas repozitorijas.
	Pvz.: Programai prasidėjus sukuriamos visos repozitorijos pradedant saldainių repozitorija, ji savyje išsikviečia failų skaitymo servisą, kuris perskaito atitinkamą failą(pvz.: candies.txt) ir repozitorijos
	klasė saldainius gautus iš failo susideda į savo sąrašą, kuris yra bendras tarp visų saldainių repozitorijos klasių***. Tą patį padaro ir Mėsos, Daržovių ir Gėrimų repozitorijos.
	
Programos veikimo metu yra operuojama su sąrašais repozitorijose, ne sąrašais failuose.

Veikimo principai:
Įsijungus programą nurodote kiek turi pinigų. 
Jeigu pinigų yra daugiau nei 0 tada vartotojas gali pirkti prekes, jei pinigų neturi tada gali jas tik peržiūrėti.
Programoje turi būti galima išspausdinti kiekvienos prekės repozitorijos sąrašą individualiai(pvz.: pamatyti visas mėsos prekes)
Pasirenkant kokias prekes norit pirkti, jos įdedamos į pirkinių krepšelį.
Pirkinių krepšelį taip pat turi būti galimybė peržiūrėti.(prekes su kainom ir galutinę viso krepšelio kainą)
Apsisprendus pirkti turi būti patikrinama ar užtenka pinigų.
Jeigu pinigų užtenka tada sudaromas kvitas, į kurį įeina krepšelio informacija, galutinė kaina ir laikas kada buvo nupirkta.
Kvitas išsiunčiamas nurodytu el. paštu.
