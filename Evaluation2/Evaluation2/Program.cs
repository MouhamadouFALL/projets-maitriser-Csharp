/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 6:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Evaluation2
{
	class Program
	{
		
		public static void affichePersonne() {
			Console.WriteLine("");
			Console.WriteLine("Nom : FALL");
			Console.WriteLine("Prenom : Mouhamadou Moustapha");
			Console.WriteLine("Adresse : Dakar, Fann Campus ucad");
		}
		
		public static void tableMulti() {
			Console.WriteLine("");
			int i, j;
			for (i = 1; i<=10; i++) {
				for (j=1; j<=10; j++) {
					Console.WriteLine(i + " x " + j + " = " + (i*j));
				}
				Console.WriteLine();
				Console.WriteLine();
			}
		}
		
		public static void afficheTriangle() {
			Console.WriteLine("");
			Console.WriteLine("Affichage du triangle rectangle d'étoile");
			int i, j;
			for (i=0; i<5; i++) {
				for (j=0; j<=i; j++) {
					Console.Write(" * ");
				}
				Console.WriteLine();
			}
		}
		
		public static void menu() {
			int choix=0;
			do {
				Console.WriteLine("\t \t MENU");
				Console.WriteLine("\t 1 - Afficher une pesonne");
				Console.WriteLine("\t 2 - Afficher les tables de multiplication de 1 à 10");
				Console.WriteLine("\t 3 - Afficher un triangle rectangle d'étoile");
				Console.WriteLine("\t 4 - Quitter");
				Console.WriteLine("\t Faites votre choix ");
				choix=int.Parse(Console.ReadLine());
				
				switch (choix) 
				{
						
					case 1: 
						affichePersonne();
						break;
					case 2: 
						tableMulti();
						break;
					case 3:
						afficheTriangle();
						break;
					case 4:
						Console.WriteLine("Au revoir ");
						break;
					default:
						Console.WriteLine("choix inexistant ");
						break;
				}
				
			}while(choix != 4);
		} 
		
		public static void Main(string[] args)
		{
			menu();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}