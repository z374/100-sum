using System;
using System.Collections.Generic;
using System.Text;

namespace somma1 {
	class luglio14 {

		public static void rincorri(string disponibili, int output, string sequenza) {
			if (output == 100) {
				bool flag = true;
				foreach (char c in "123456789")
					if (!sequenza.Contains(c)) flag = false;
				if (flag)
					Console.WriteLine(sequenza + " = " + output);
			} else 
				for (int i = 0; i < disponibili.Length; i++) 
					for (int j = i + 1; j < disponibili.Length + 1; j++) {
						rincorri(disponibili.Substring(j, disponibili.Length - j), output + int.Parse(disponibili.Substring(i, j - i)), 
							sequenza + "+" + disponibili.Substring(i, j - i));
						rincorri(disponibili.Substring(j, disponibili.Length - j), output - int.Parse(disponibili.Substring(i, j - i)), 
							sequenza + "-" + disponibili.Substring(i, j - i));
					}
		}

		public static void Main() {
			Console.WriteLine("Here we go");
			luglio14.rincorri("123456789", 0, "");

		}
	}
}
