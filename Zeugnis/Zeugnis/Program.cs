/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 03.05.2022
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System;  
 using System.IO;  
 using System.Text; 

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
			
			Console.WriteLine("Name:");
			
			String Name =Console.ReadLine();
		
			Console.WriteLine("Datum (TTMMJJJJ):");
			
			String Datum =Console.ReadLine();
			
			Console.WriteLine("Klasse:");
			
			String Klasse =Console.ReadLine();
			
			Console.WriteLine("Fehltage:");
			
			String Fehltage =Console.ReadLine();
			
			Console.WriteLine("Unentschuldigt:");
			
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
			
			double Notendurchschnitt =(Deutsch+Englisch+Politik+Musik+Geschichte+Erdkunde+(Kunst*2)+(Physik*2))/10.0;
			
			Notendurchschnitt = (17 - Notendurchschnitt)/3;
			
			Console.WriteLine("Notendurchsnitt: {0:F1}",Notendurchschnitt);
			
			int Versetzung=0; 
			Console.WriteLine("Versetzung:");
			
			
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
		
			Console.WriteLine("Ausdrucken?");
			
			String Ausdrucken =Console.ReadLine();
		
			
			
			if (Ausdrucken.Equals("Ja")||Ausdrucken.Equals("ja") || Ausdrucken.Equals("JA") || Ausdrucken.Equals("J") || Ausdrucken.Equals("j"))
			{
			// File name
          string fileName = @"C:\Users\schulung.SCHULUNGNB-03\Desktop\Zeugnis.txt";  
          
          StreamWriter writer = new StreamWriter(fileName, true);
             
                writer.WriteLine("==========Zeugnis==========");    
                writer.WriteLine("Vorname:" + Vorname);  
                writer.WriteLine("Name:" + Name); 
                writer.WriteLine("Datum:" + Datum);
                writer.WriteLine("Klasse:" + Klasse);   
                writer.WriteLine("==========================="); 
				writer.WriteLine(" ");                
                writer.WriteLine("Fächer (Angaben in Notenpunkten)");  
                writer.WriteLine("Deutsch:" + Deutsch);  
                writer.WriteLine("Englisch:" + Englisch);  
                writer.WriteLine("Musik:" + Musik);  
                writer.WriteLine("Geschichte:" + Geschichte);  
                writer.WriteLine("Politik:" + Politik);
                writer.WriteLine("Erdkunde:" + Erdkunde);
                writer.WriteLine(" ");
                writer.WriteLine("===========================");
                writer.WriteLine(" ");
                writer.WriteLine("Leistungskurse (Angaben in Notenpunkten)");  
                writer.WriteLine("Kunst:" + Kunst);  
                writer.WriteLine("Physik:" + Physik);  
                writer.WriteLine(" ");
                writer.WriteLine("Notendurchsnitt: {0:F1}",Notendurchschnitt);
                writer.WriteLine(" ");
                writer.WriteLine("===========================");
                writer.WriteLine("Fehlage:" + Fehltage);
                writer.WriteLine("Unentschuldigt:" + Unentschuldigt);
                writer.WriteLine("===========================");
                writer.WriteLine(" ");
                if(f >0)
			{
			writer.WriteLine("Der Schüler wird nicht Versetzt");	
			}
			else
			{
			
			writer.WriteLine("Der Schüler wird Versetzt");	
			}

   
                writer.Close();
         
       Console.ReadKey();
			}
			}
      
         
    

		}
	}
