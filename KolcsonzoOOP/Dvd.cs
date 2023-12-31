﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Dvd : IKolcsonozheto, IComparable<Dvd>
	{
		private string cim;
		private int hossz;

		public Dvd(string cim, int hossz)
		{
			this.cim = cim;
			this.hossz = hossz;
		}
		
		public string MegjelenitendoNev()
		{
			return $"{this.cim} ({hossz} perc)";
		}
		public int MeddigKolcsonozheto()
		{
			return 7;
		}

		public int CompareTo(Dvd other)
		{
			return this.hossz.CompareTo(other.hossz);
		}

	}
}
