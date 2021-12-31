/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/21/2021
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace projet13
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<Personne> personnes = new List<Personne>();
			Personne[] pers = new Personne[3];
			
			int i = 0;
			do {
				Personne perso = new Personne();
				
				Console.Write("Entrer votre nom :  ");
				perso.Nom = Console.ReadLine();
				
				personnes.Add(perso); // Remplir la liste des personnes
				
				pers[i]=perso; // Remplir le tableau de personnes
				
				i++;
			}while(i<3);
			
			Console.WriteLine("");
			
			Console.WriteLine("Affichage de la liste de personnes ");
			foreach(Personne p in personnes) {
				Console.WriteLine("\t" + p.Nom);
			}
			
			Console.WriteLine("");
			Console.WriteLine("Affichage du Tableau de personnes ");
			
			foreach(Personne p in pers) {
				Console.WriteLine("\t" + p.Nom);
			}
			
			//Console.Write("Entrer votre Prénom :  ");
			//perso.Prenom = Console.ReadLine();
			
			//Console.Write("votre nom complet est :  ");
			//Console.WriteLine(perso.nomComplet);
			
			//Console.WriteLine("Le noom est " + perso.Nom);
			
			Console.WriteLine("");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			
		}
	}
}