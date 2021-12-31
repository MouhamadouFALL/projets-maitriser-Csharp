/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/21/2021
 * Time: 6:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet12_fonction
{
	class Program
	{
		// une fonction de controle de la saisie d'une valeur entiere
		public static int saisie() {
			int n;
			do {
				Console.WriteLine("Entrer un entier positif :  ");
				n=int.Parse(Console.ReadLine());
			}while(n<=0);
			return n;
		}
		
		// une fonction qui recoit un entier puis renvoie son cube
		public static int cube(int n) {
			return (n*n*n);
		}
		
		// une fonction qui recoit un entier puis determine le resultat de l'expression suiante : 
		// somme de (n+1)au cube
		public static long calcul(int n) {
			
			long som=0;
			int i;
			for(i=1; i <= n; i++){
				som+=cube(n+i);
			}
			
			return som;
		}
		
		// une fonction qui recoit un entier puis affiche les tables de multiplication des entiers paires 
		// compris entre un et la valeur recue
		public static void tablePaire(int n) {
			
			int i,j;
			for(i=2 ; i<=n; i++) {
				
				Console.WriteLine(" Table de multiplication de " + i);
				
				for(j=1; j<=10; j++)
					Console.WriteLine(" " + i + " x " + j + " = " + (i*j));
				
				i++; // 2ème incrémentation pour obtenir un nombre paire
			}
		}
		
		// une fonction pour le menu
		public static void menu() {
			int n=1, choix=0;
			//long som=0;
			do {
				Console.WriteLine("\t \t MENU");
				Console.WriteLine("\t 1 - Controle Saisie");
				Console.WriteLine("\t 2 - Calcul Cube");
				Console.WriteLine("\t 3 - Formule");
				Console.WriteLine("\t 4 - Table Paires");
				Console.WriteLine("\t 5 - Quitter");
				Console.WriteLine("\t Faites votre choix ");
				choix=int.Parse(Console.ReadLine());
				
				switch (choix) 
				{
						
					case 1: 
						n=saisie();
						break;
					case 2: 
						{
							//int c=cube(n);
							//Console.WriteLine(n + " au cube  = " + c);
							Console.WriteLine(n + " au cube  = " + cube(n));
							break;
						}
					case 3:
						//som=calcul(n);
						//Console.WriteLine("Resultat calcul de la somme est " + som);
						Console.WriteLine("Resultat calcul de la somme est " + calcul(n));
						break;
					case 4: 
						tablePaire(n);
						break;
					case 5:
						Console.WriteLine("Au revoir ");
						break;
					default:
						Console.WriteLine("choix inexistant ");
						break;
				}
				
			}while(choix != 5);
		}
		
		
		public static void Main(string[] args)
		{
			menu();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}