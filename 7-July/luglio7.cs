using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace somma1 {
	class luglio7 {
		public static string GeneraBaseTre (string corrente) {
			if (corrente[corrente.Length - 1] == '2')
				return GeneraBaseTre(corrente.Substring(0, corrente.Length - 1)) + '0';
			else		
				return corrente.Substring(0, corrente.Length - 1) + (char)((int)corrente[corrente.Length-1] +1);
		}
		private static void TestGeneraBaseTre() {
			WriteLine(luglio7.GeneraBaseTre("000"));
			WriteLine(luglio7.GeneraBaseTre("001"));
			WriteLine(luglio7.GeneraBaseTre("002"));
			WriteLine(luglio7.GeneraBaseTre("010"));
			WriteLine(luglio7.GeneraBaseTre("011"));
			WriteLine(luglio7.GeneraBaseTre("012"));
			WriteLine(luglio7.GeneraBaseTre("020"));
			WriteLine(luglio7.GeneraBaseTre("021"));
			WriteLine(luglio7.GeneraBaseTre("022"));
			WriteLine(luglio7.GeneraBaseTre("100"));
		}

		public static string[] Spezzetta(string codice) {
			string[] numeri = { "2", "3", "4", "5", "6", "7", "8", "9" };
			string[] combinazione = new string[9];
			// string codice = "000000000";

			combinazione = new string[]{ "1", "0", "0", "0", "0", "0", "0", "0", "0" };
			int indexcomb = 0;
			for (int j = 0; j<8; j++) {
				switch (codice[j]){
					case '0':
						combinazione[indexcomb] = combinazione[indexcomb] + numeri[j];
						break;
					default:
						indexcomb++;
						combinazione[indexcomb] = numeri[j];
						break;
				}
			}
			foreach (string s in combinazione) {
			//	Write(s + " ");
			}
			return combinazione;

		}


		public static int CalcolaSomma(string []numeri, string codice) {
			codice = codice.Replace("0", "");//string.Empty);
			//WriteLine();
			int somma =int.Parse(numeri[0]);
			for (int i =0; i < codice.Length; i++) {
				switch (codice[i]) {
					case '1':
						somma +=  int.Parse(numeri[i + 1]);
						//WriteLine(somma);
						break;
					case '2':
						somma -= int.Parse(numeri[i + 1]);
						break;

				}
			}
			//WriteLine();

			return somma;
		}

		public static void Main() {

		  //Spezzetta("01001201");
			//Spezzetta("00111001");  // 123+4+5+ 67+8+9
			CalcolaSomma(Spezzetta("00111002"), "00111002");
			// 1 2 3 4 5 6 7 8 9
			//  0 0 1 1 1 0 0 1
			//123+4+5+678+9
			string codice = "00000000";
			int somma;
			for (int i = 0; i < 6500; i++) {
				somma = CalcolaSomma(Spezzetta(codice), codice);
				
				if (somma == 100) {
					Write("somma = " + somma + " \t " + "sequenza = " + codice + "  .... ");
					string [] sw = Spezzetta(codice);
					for(int k =0; k<8; k++) {
						if (sw[k] != "0") {
							string uff = codice.Replace("0", "");
							Write(sw[k] + "");
							if (k<uff.Length)
							switch (uff[k]) {
								case '1':
									Write(" + ");
									break;
								case '2':
									Write(" - ");
									break;
							}
						}
					}
					WriteLine();
				}
				codice = GeneraBaseTre(codice);
			}
		}
	}


}
