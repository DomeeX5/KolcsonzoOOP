using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Program 
	{
		static void Main(string[] args)
		{
			#region katalogus
			List<IKolcsonozheto> kolcsonozhetok = new List<IKolcsonozheto>();
			Konyv k1 = new Konyv("The Witcher","Andrzej Sapkowski","ABCDE12345");
			Konyv k2 = new Konyv("Harry Potter", "J. K. Rowling", "EDCBA54321");
			kolcsonozhetok.Add(k1);
			kolcsonozhetok.Add(k2);
			Dvd d1 = new Dvd("Bosszúállók", 143);
			Dvd d2 = new Dvd("Pókember", 121);
			kolcsonozhetok.Add(d1);
			kolcsonozhetok.Add(d2);
			Ujsag u1 = new Ujsag("Blikk", 2016, 26);
			Ujsag u2 = new Ujsag("Bors", 2019, 12);
			kolcsonozhetok.Add(u1);
			kolcsonozhetok.Add(u2);

			foreach (var item in kolcsonozhetok)
			{
                Console.WriteLine($"{item.MegjelenitendoNev()}, {item.MeddigKolcsonozheto()} napig kölcsönözhető.");
            }
            #endregion

            Console.WriteLine("-----------------------");

            #region dvdk
            Dvd d3 = new Dvd("Batman", 176);
			Dvd d4 = new Dvd("Sikoly VI.", 117);
			Dvd d5 = new Dvd("Vissza a jövőbe", 116);
			List<Dvd> dvds = new List<Dvd>
			{
				d1,
				d2,
				d3,
				d4,
				d5
			};
			dvds.Sort();
			foreach (var item in dvds)
			{
                Console.WriteLine($"{item.MegjelenitendoNev()}, {item.MeddigKolcsonozheto()} napig kölcsönözhető.");
            }
			#endregion
		}
	}
}
