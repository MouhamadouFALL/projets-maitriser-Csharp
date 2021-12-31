/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-14
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet3
{
	class Program
	{
		public static void Main(string[] args)
			
		{
			
			int codeProduit;
			string nom, categorie;
			float prixUnitaire;
			double quantite;
			
			//Demander les informations
			Console.Write("Entrer le code du produit : ");
			codeProduit=int.Parse(Console.ReadLine());
			
			Console.Write("Entrer le nom du produit : ");
			nom=Console.ReadLine();
			
			Console.Write("Entrer la categorie du produit : ");
			categorie=Console.ReadLine();
			
			Console.Write("Entrer le prix unitaire du produit : ");
			prixUnitaire=float.Parse(Console.ReadLine());
			
			Console.Write("Entrer la quantite du produit : ");
			quantite=double.Parse(Console.ReadLine());
			
			Console.WriteLine("");
			Console.WriteLine("");
			
			//Afficher les informations 
			Console.WriteLine("Code du produit : " + codeProduit);
			Console.WriteLine("Nom du produit : " + nom);
			Console.WriteLine("Categorie du produit : " + categorie);
			Console.WriteLine("Prix unitaire du produit : " + prixUnitaire);
			Console.WriteLine("Quantite du produit : " + quantite);
			
			// Calculer Montant
			double montant = (prixUnitaire*quantite);
			Console.WriteLine("Montant final : " + montant + " FCFA");
			
			Console.WriteLine("");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}