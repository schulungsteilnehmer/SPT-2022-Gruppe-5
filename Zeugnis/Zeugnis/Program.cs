/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 03.05.2022
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zeugnis
{
	class Program
		
	{
		int i= 0;
		public static void Main(string[] args)
		{
			Console.WriteLine("Name:");
			
			// TODO: Implement Functionality Here
			
			String Name =Console.ReadLine();
			
			Console.Write("Vorname:");
			
			String Vorname =Console.ReadLine();
		
			Console.Write("Datum:");
			
			String Datum =Console.ReadLine();
			
			Console.Write("Klasse:");
			
			String Klasse =Console.ReadLine();
			
			Console.Write("Fehltage:");
			
			String Fehltage =Console.ReadLine();
			
			Console.Write("Unentschuldigt:");
			
			String Unentschuldigt =Console.ReadLine();
			
			Console.Write("Fächer (Angabe in Notenpunkten)");
			
			String Fächer =Console.ReadLine();
			
			Console.Write("Deutsch:");
			
			int Deutsch =Console.ReadLine();
			
			Console.Write("Englisch:");
			
			int Englisch =Console.ReadLine();
			
			Console.Write("Musik:");
			
			int Musik =Console.ReadLine();
			
			Console.Write("Geschichte:");
			
			int Geschichte =Console.ReadLine();
			
			Console.Write("Politik:");
			
			int Politik =Console.ReadLine();
			
			Console.Write("Erdkunde:");
			
			int Erdkunde =Console.ReadLine();
			
			Console.Write("Leistungskurse (Angabe in Notenpunkten)");
			
			int Leistungskurse =Console.ReadLine();
			
			Console.Write("Kunst:");
			
			int Kunst =Console.ReadLine();
			
			Console.Write("Physik:");
			
			int Physik =Console.ReadLine();
			
			Console.Write("Notendurchsnitt:");
			
			int Notendurchschnitt =Console.ReadLine();
			
			Console.Write("Versetzung:");
			
			String Versetzung =Console.ReadLine();
			
			if (Deutsch < 05)
			{
			i= i+1;
			}
			if (Englisch < 05)
			{
			i= i+1;
			}
			if (Musik < 05)
			{
			i= i+1;
			}
			if (Geschichte < 05)
			{
			i= i+1;	
			}
			if (Politik < 05)
			{
			i= i+1;
			}
			if (Erdkunde < 05)
			{
			i= i+1;
			}
			if (Kunst < 05)
			{
			i= i+1;
			}
			if (Physik < 05)
			{
			i= i+1;
			}
			
			if (i > 1)
			{
			Console.Write("Nein:");
			
			String Nein =Console.ReadLine();
			}
			else
				{
			Console.Write("Ja:");
			
			String Ja =Console.ReadLine();
					
				}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}