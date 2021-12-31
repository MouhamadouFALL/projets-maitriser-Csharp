/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/21/2021
 * Time: 7:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet13
{
	/// <summary>
	/// Description of Personne.
	/// </summary>
	public class Personne
	{
		public Personne() {}
		
		private string nom;
		public string Nom 
		{
			get { return(nom); }
			set {nom = value; }
		}
		
		private string prenom;
		public string Prenom
		{
			get {return(prenom);}
			set {prenom = value;}
		}
		
		public string nomComplet
		{
			get{ return(nom + " " + prenom); }
		}
		
	}
}
