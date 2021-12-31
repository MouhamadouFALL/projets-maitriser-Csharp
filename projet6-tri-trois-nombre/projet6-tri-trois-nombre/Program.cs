/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-15
 * Time: 10:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet6_tri_trois_nombre
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x, y, z;
			
			Console.Write("Entrer le premier nombre :  ");
			x=int.Parse(Console.ReadLine());
			
			Console.Write("Entrer le deuxieme nombre :  ");
			y=int.Parse(Console.ReadLine());
			
			Console.Write("Entrer le troisieme nombre :  ");
			z=int.Parse(Console.ReadLine());
			
			if (x < y) {
				if (y < z) 
					Console.WriteLine(" " + x + " " + y + " " + z + " .");
				else {
					if (x < z) 
						Console.WriteLine(" " + x + " " + z + " " + y + " .");
					else 
						Console.WriteLine(" " + z + " " + x + " " + y + " .");
				}
			}
			else if (x < z) {
				if (y < z) 
					Console.WriteLine(" " + y + " " + x + " " + z + " .");
			}
			else {
				if (y < z) 
					Console.WriteLine(" " + y + " " + z + " " + x + " .");
				else 
					Console.WriteLine(" " + z + " " + y + " " + x + " .");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}