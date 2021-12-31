/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-15
 * Time: 2:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet8_triangle_premier
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int n, i, j, cpt, nbPrem=0;
			
			do {
				Console.Write("Entrer un nombre :   ");
				n=int.Parse(Console.ReadLine());
			}while(n <= 0);
			
			Console.WriteLine();
			Console.WriteLine("Triangle Rectangle de "+n+" étoiles");
			for (i = 1; i <= n; i++) {
				for (j=1; j<=i; j++)
					Console.Write(" * ");
				Console.WriteLine("");
			}
			
			Console.WriteLine();
			Console.WriteLine("Triangle Rectangle de "+n+" ");
			for (i = 1; i <= n; i++) {
				for (j=1; j<=i; j++)
					Console.Write(" "+ j);
				Console.WriteLine("");
			}
			
			Console.WriteLine();
			Console.WriteLine("Les "+ n +" premiers nombres premier ");
			
			// Rechercher et afficher le nombre des nombre premier
			int val=2;
			while(nbPrem < n) {
				  
				// Verifier si un nombre est premier ou non				
				cpt=0;
				for (i = 1; i <= val; i++) {
					
					if (val % i == 0)
						cpt++;
				}
				
				// Compter les nombres premiers
				if (cpt == 2) {
					Console.Write(" " + val);
					nbPrem++;
				}
				
				// Incrémente la valeur
				val++;
			}
	
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}