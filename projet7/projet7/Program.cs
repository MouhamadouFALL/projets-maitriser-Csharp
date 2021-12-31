/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-15
 * Time: 1:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet7
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int x, i, cpt=0, s=0;
			do {
				Console.Write("Entrer une valeur entiére :   ");
				x=int.Parse(Console.ReadLine());
				
			} while (x <= 0);
			
			for (i = 1; i < 13; i++) {
				Console.WriteLine(x + " x "+ i + " = "+ (x * i));
			}
			
			Console.WriteLine();
			
			for (i = 1; i <= x ; i++) {
				if (x % i == 0) {
					cpt++;
					s+=i;
				}
			}
			
			if (cpt == 2)
				Console.WriteLine(x + " est premier");
			else
				Console.WriteLine(x + " n'est pas premier");
			
			if (s == (2*x))
				Console.WriteLine(x + " est parfait");
			else
				Console.WriteLine(x + " n'est pas parfait");
			
			Console.WriteLine();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}