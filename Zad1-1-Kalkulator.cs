using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Prosty Kalkulator");
		
		Console.WriteLine("Wprowadź pierwszą liczbę: ");
		string resp = Console.ReadLine();
		int x = Int32.Parse(resp);
		
		Console.WriteLine("Wprowadź drugą liczbę: ");
		resp = Console.ReadLine();
		int y = Int32.Parse(resp);
		
		Console.WriteLine("Wprowadź operator: ");
		string op = Console.ReadLine();
		
		if (op == "+")
		{
			Console.WriteLine($"Wynik: {x + y}");
		}
		else if (op == "-")
		{
			Console.WriteLine($"Wynik: {x - y}");
		}
		else if (op == "*")
		{
			Console.WriteLine($"Wynik: {x * y}");
		}
		else if (op == "/")
		{
			if (y == 0)
			{
				Console.WriteLine("Nie można dzielić przez zero!");
			}
			else
			{
				double wynik = Convert.ToDouble(x) / Convert.ToDouble(y);
				Console.WriteLine($"Wynik: {wynik}");
			}
		}
		else
		{
			Console.WriteLine("Nieznany operator.");
		}
	}
}