/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-15
 * Time: 3:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet10_deplaceElementTab
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Déclaration des variables à utiliser
			int n, i, svg;
			
			// Demander la taille du tableau
			do{
				Console.Write("Entrer la tailel du tableau :   ");
				n=int.Parse(Console.ReadLine());
			}while(n<=0);
			
			// Créer un objet tableau et le remplir 
			int[] T = new int[n];
			for (i = 0; i < n; i++) {
				Console.Write("Entrer T[" + i +"] = ");
				T[i]=int.Parse(Console.ReadLine());
			}
			
			// Affichage du tableau
			Console.WriteLine("tableau avant decalage à gauche");
			for(i = 0; i < n; i++) {
				Console.Write(T[i] + " | ");
			}
			
			Console.WriteLine("");
			
			// Décaler les éléments du tableau
			svg=T[0]; 
			for (i=0; i<n-1; i++) {
				T[i]=T[i+1];
			}
			T[n-1]=svg;
			
			Console.WriteLine("tableau apres decalage à gauche");
			for(i=0; i<n; i++) {
				Console.Write(T[i]+ " | ");
			}
			
			Console.WriteLine("");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}