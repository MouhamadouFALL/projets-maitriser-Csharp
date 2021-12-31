/*
 * Created by SharpDevelop.
 * User: nabyFall
 * Date: 12/22/2021
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projet14_client
{
	/// <summary>
	/// Description of Client.
	/// </summary>
	public class Client
	{
		public Client() { }
		
		private long code;
		public long Code
		{
			get { return(code);}
			set { code = value;}
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
		
		private string nationalite;
		public string Nationalite
		{
			get {return(nationalite);}
			set { nationalite = value;}
		}
		
		private string adresse;
		public string Adresse
		{
			get {return(adresse);}
			set { adresse = value;}
		}
		
		private int age;
		public int Age
		{
			get { return(age);}
			set {age = value;}
		}
		
		private int pouvoirAchat;
		public int PouvoirAchat
		{
			get { return(pouvoirAchat);}
			set { pouvoirAchat = value;}
		}
		
		private char sexe;
		public char Sexe
		{
			get { return(sexe); }
			set { sexe = value; }
		}
	}
}
