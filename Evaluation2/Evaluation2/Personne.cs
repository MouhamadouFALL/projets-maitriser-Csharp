/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/28/2021
 * Time: 6:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Evaluation2
{
	/// <summary>
	/// Description of Personne.
	/// </summary>
	public class Personne
	{
		public Personne()
		{
		}
		
		private string nom;
		public string Nom
		{
			get {return (nom);}
			set { nom = value;}
		}
		
		private string prenom;
		public string Prenom
		{
			get {return(prenom);}
			set { prenom = value;}
		}
		
		
		
		private string adresse;
		public string Adresse
		{
			get {return(adresse);}
			set { adresse = value;}
		}
		
	}
}
