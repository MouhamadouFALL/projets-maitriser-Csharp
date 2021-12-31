/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 8:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace projet14_client
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// Une collections des client
			List<Client> clients = new List<Client>();
			
			char response;
			
			do {
				
			// Creer un objet client
			Client client = new Client();
			
			// enregistrement des informations du client
			Console.WriteLine("Entrer le code du client :  ");
			client.Code = int.Parse(Console.ReadLine());
			Console.WriteLine("Entrer le nom du client :  ");
			client.Nom = Console.ReadLine();
			Console.WriteLine("Entrer le Prenom du client :  ");
			client.Prenom = Console.ReadLine();
			Console.WriteLine("Entrer l'age du client :  ");
			client.Age = int.Parse(Console.ReadLine());
			Console.WriteLine("Entrer l'adresse du client :  ");
			client.Adresse = Console.ReadLine();
			Console.WriteLine("Entrer la nationalite du client :  ");
			client.Nationalite = Console.ReadLine();
			Console.WriteLine("Entrer le sexe du client :  ");
			client.Sexe = char.Parse(Console.ReadLine());
			Console.WriteLine("Entrer le pouvoir achat du client :  ");
			client.PouvoirAchat = int.Parse(Console.ReadLine());
			
			// Ajouter client dans la collection
			clients.Add(client);
			
			// Demander un nouveau client
			Console.WriteLine("Voulez-vous créer un nouveau client (o/n) :  ");
			response=char.Parse(Console.ReadLine());
			
			}while(response != 'n');
			
			
			
			// Montant totale du pouvoir d'achat des clients
			int somme= 0;
			foreach (Client c in clients) {
				somme += c.PouvoirAchat;
			}
			// Affichage Montant totale du pouvoir d'achat des clients
			Console.WriteLine("Montant total des pouvoirs d'achat :  " + somme);
			
			Console.WriteLine();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}