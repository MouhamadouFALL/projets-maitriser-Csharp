/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-16
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet11
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x, i, cpt, nbPremier=0;
			
			// Demander la taille du tableau
			do {
				Console.Write("Entrer la taille du tableau :  ");
				x=int.Parse(Console.ReadLine());
			}while(x < 0);
			
			Console.WriteLine("");
			
			// Créer un objet tableau de taille x
			int[] T = new int[x];
			
			// Remplir le tableau avec les x premiers nombres premiers
			Console.WriteLine(" Affichage du tableau des " + x + " premiers nombres premiers :");
			Console.Write("| ");
			int premier = 2;
			while(nbPremier < x) {
				
				cpt=0;
				for (i=1; i<=premier; i++) {
					
					if (premier % i == 0)
						cpt++;
				}
				
				if (cpt == 2) {
					T[nbPremier]=premier;
					nbPremier++;
					
				}
				premier++;
			}
			
			
			foreach (int a in T) {
				Console.Write(a + " | ");
			}
			
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine(" écare entre le max et le min : " + (T[x-1] - T[0]));
			
			Console.WriteLine("");
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}