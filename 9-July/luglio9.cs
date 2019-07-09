using System;
using System.Linq;

namespace somma1 {

	class Numeri {
		string num = "123456789";
		private static int next;
		public char this[int index] => num[index];
		public char Next => num[next++ % 9];

	}

	class luglio9 {

		public static int max(params int[] numeri) {
			if (numeri.Length == 1)
				return numeri[0];
			return Math.Max(numeri[0], max(numeri.Skip(1).ToArray()));
		}


		public static void trama(string sequenza) {
			void calcola(string s, int l, string res) {
				if (l == 0)
					Console.WriteLine(res);
				else
					for (int j = 0; j < l; j++)
						calcola(s.Remove(j, 1), l - 1, res + s[j]);
			}
			calcola(sequenza, sequenza.Length, "");
		}




		public static void Main() {
			Console.WriteLine(luglio9.max(1, 2, 5, 64, 3, 45, 7, 5, 3, 345, 6, 54, 3));
			luglio9.trama("abcd");
		}


	}
}
