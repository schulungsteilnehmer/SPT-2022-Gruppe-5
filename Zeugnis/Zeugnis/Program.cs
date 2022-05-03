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
		
		public static void Main(string[] args)
		{
			int i= 0;
			int f= 0;
			Console.WriteLine("Vorname:");
			
			// TODO: Implement Functionality Here
			
			String Vorname =Console.ReadLine();
			
			Console.Write("Name:");
			
			String Name =Console.ReadLine();
		
			Console.Write("Datum (TTMMJJJJ):");
			
			String Datum =Console.ReadLine();
			
			Console.Write("Klasse:");
			
			String Klasse =Console.ReadLine();
			
			Console.Write("Fehltage:");
			
			String Fehltage =Console.ReadLine();
			
			Console.Write("Unentschuldigt:");
			
			int Unentschuldigt =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Fächer (Angabe in Notenpunkten)");
			
			String Fächer =Console.ReadLine();
			
			Console.Write("Deutsch:");
			
			int Deutsch = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Englisch:");
			
			int Englisch =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Musik:");
			
			int Musik =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Geschichte:");
			
			int Geschichte =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Politik:");
			
			int Politik =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Erdkunde:");
			
			int Erdkunde =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Leistungskurse (Angabe in Notenpunkten)");
			
			String Leistungskurse =Console.ReadLine();
			
			Console.Write("Kunst:");
			
			int Kunst =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Physik:");
			
			int Physik =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Notendurchsnitt:");
			
			int Notendurchschnitt =Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Versetzung:");
			
			
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
			
			if (i > 2)
			{
				f = f+1;
			}
			
			if (Unentschuldigt > 29)
			{
				f =f+1;
			}
			if(f >0)
			{
			Console.WriteLine("Der Schüler wird nicht Versetzt");	
			}
			else
			{
			
			Console.WriteLine("Der Schüler wird Versetzt");	
			}
			
				
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}