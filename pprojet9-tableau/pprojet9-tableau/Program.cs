/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-15
 * Time: 3:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace pprojet9_tableau
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] tab = {12, 23, 54, 67, 78, 10, 98};
			Console.WriteLine(" Affichage de mon Tableau avec for ");
			for (int i = 0; i < 7; i++) {
				Console.WriteLine(" Tab["+ i + "] = " + tab[i]);
			}
			
			Console.WriteLine("");
			Console.WriteLine(" Affichage de mon Tableau avec foreach ");
			foreach (int a in tab) {
				Console.WriteLine(" " + a);
			}
			
			Console.WriteLine("");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}