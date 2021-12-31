/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 2021-12-14
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet5_compare
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			float x, y;
		
			Console.Write("Entre la premire valeur : ");
			x=float.Parse(Console.ReadLine());
			Console.Write("Entre la deuxieme valeur : ");
			y=float.Parse(Console.ReadLine());
			
			if ( x > y ) {
				Console.WriteLine("Max : " + x + " et Min : " + y);
			}
			else {
				Console.WriteLine("Max : " + y + " et Min : " + x);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}