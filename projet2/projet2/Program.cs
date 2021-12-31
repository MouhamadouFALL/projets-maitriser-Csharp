/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-14
 * Time: 2:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet2
{
	class Program
	{
		
		
		public static void Main(string[] args)
		{
			string nom, prenom, adress;
			int age;
			
			Console.WriteLine("Welcome !");
			Console.Write("Entrer votre nom :  ");
			nom=Console.ReadLine();
			Console.Write("Entrer votre Prenom :  ");
			prenom=Console.ReadLine();
			Console.Write("Entrer votre adresse :  ");
			adress=Console.ReadLine();
			Console.Write("Entrer votre age :  ");
			age=int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			
			Console.WriteLine("Nom : " + nom);
			Console.WriteLine("Prenom :  " + prenom);
			Console.WriteLine("Adresse : " + adress);
			Console.WriteLine("Age : " + age);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}