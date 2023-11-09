using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NberekTablazat
{
	internal class Nber
	{
		private string nev;
		private int kor;

		public Nber(string nev, int kor)
		{
			this.nev = nev;
			this.kor = kor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Kor { get => kor; set => kor = value; }
	}
}
