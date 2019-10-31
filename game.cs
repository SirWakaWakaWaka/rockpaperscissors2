using System;

namespace Schere__Stein__Papier_2._
{
	class Program
	{
		public static void Main(string[] args)
		{
			int userWin = 0;
			int compWin = 0;
			int draw = 0;
			short i = 0;
			string win = "Du gewinnst!";
			string loss = "Computer gewinnt!";

			var possibilities = new[]{"schere", "stein", "papier"}; //array of possibilities computer has
			Random game = new Random();

			do{
				Console.WriteLine("Wie heisst du?");
				string name = Console.ReadLine();
				if(name != ""){
					Console.WriteLine("\nVielen Dank für's mitspielen, {0}", name);
					break;}
				else {
					Console.WriteLine("Ungültige Eingabe - Versuch es noch einmal!\n");
				}
					
				
			}while(true);
			
			Console.WriteLine("Die Regeln sind wie folgt:\nPapier schlägt Stein\nStein schlägt Schere\nSchere schlägt Papier\nWenn du \"Beenden\" schreibst, verlässt du das Spiel.\nWenn du \"Resultat\" schreibst, siehst du den Punktestand.\n");
			
			while(i != 1){
				int index = game.Next(possibilities.Length); //Erstellt Zufall innerhalb des array "variablen"
				Console.WriteLine("Was wählst du?");
				string userSelect = Console.ReadLine().ToLower(); //saves user selection and brings to lowercase
				
				if((userSelect) == (possibilities[index])){
				   	Console.WriteLine("Unentschieden");
				   	++draw;
				   }
				   else{
				   	switch(userSelect) {
					case "schere":
							switch(possibilities[index]){
							       case "stein":
							       Console.WriteLine(loss);
							       ++compWin;
							       	                break;
							       case "papier":
							       Console.WriteLine(win);
							       ++userWin;
							     				  	break;
							       	                 
							       	}
						
						break;
					case "stein":
							switch(possibilities[index]){
							       case "papier":
							       Console.WriteLine(loss);
							       ++compWin;
							       	                break;
							       case "schere":
							       Console.WriteLine(win);
							       ++userWin;
							     				  	break;
							       	                 
							       	}
						
						break;
					case "papier":
							switch(possibilities[index]){
							       case "schere":
							       Console.WriteLine(loss);
							       ++compWin;
							       	                break;
							       case "stein":
							       Console.WriteLine(win);
							       ++userWin;
							     				  	break;
							       	                 
							       	}						
						break;
					case "beenden":
						
						return;
					case "next":
						++i;
							
						break;
					case "resultat":
						Console.Write("Du hast {0} gewonnen, Computer hat {1} gewonnen, {2} mal unentschieden.\n", userWin, compWin, draw);
						break;
					default:
						Console.WriteLine("Ungültige Eingabe - Versuch es noch einmal!\n");
						
						break;

				   }
				}
			}
			
			Console.WriteLine("Hier beginnt der nächste Teil der Software");
			Console.ReadLine();
		}
	}
}
