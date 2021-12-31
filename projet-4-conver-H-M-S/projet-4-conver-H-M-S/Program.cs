/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-14
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet_4_conver_H_M_S
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n, h, m, s;
			Console.WriteLine("Entrer une valeur entière les secondes : ");
			n=int.Parse(Console.ReadLine());
			h=(n/3600);
			m=(n%3600)/60;
			s=(n%3600)%60;
			Console.WriteLine(" " + n + " ==> " + h + ":" + m + ":" + s + "s .");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}