using System;
using static System.Console;
using System.Threading;
namespace somma1 {
	class Program {
		int[] numeri = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		static int combinazione = (int)Math.Pow(3,9);

		public static void stampaSoluzioni() {
			 int[] generaNumeri(string seq) {
				int[] numeri = new int[9];
				int index = 0;
				string parz = "";
				for(int i = 0; i<9; i++) {
					if (seq[i] != 0) {
						if (parz != "") {
							numeri[index] = Int32.Parse(parz);
							index++;
						}
						numeri[index] = i;
						index++;
						parz = "";
					}
					else {
						parz = seq[i] + parz;
					}
				}
				return numeri;
				
			}

			for (int i = combinazione; i>0; i--) {
				int codice = cambiaBase(i);
				Write(i + " ");
				int [] what = generaNumeri(codice.ToString());
				foreach(int u in what){
					Write(u + " ");
				}
				WriteLine();
				Thread.Sleep(1000);

				
			}

		}
		private static int cambiaBase(int num, int newbase=3) {
			int part;
			int p = 0;
			int result = 0;
			while (num > 0) { 
				part = num % newbase;
				num = num / newbase;
				result += part * (int)Math.Pow(10, p);
				p++;
			}
			return result;
		}


		static void Main(string[] args) {
			Program.stampaSoluzioni();
			
		}
	}
}
