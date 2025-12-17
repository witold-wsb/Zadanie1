using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Konwerter Temperatur");
		Console.WriteLine("[c] Celsjusz -> Fahrenheit");
		Console.WriteLine("[f] Fahrenheit -> Celsjusz");
		Console.WriteLine("Wybierz kierunek konwersji: ");
		string choice = Console.ReadLine();
		
		Console.WriteLine("Podaj temperaturę: ");
		double temp = Convert.ToDouble(Console.ReadLine());
		
		if (choice == "f")
		{
			double temp2 = (temp - 32.0) / 1.8;
			Console.WriteLine($"{temp}°F = {temp2}°C");
		}
		else if (choice == "c")
		{
			double temp2 = temp * 1.8 + 32.0;
			Console.WriteLine($"{temp}°C = {temp2}°F");
		}
		else
		{
			Console.WriteLine("Nieprawidłowy wybór.");
		}
	}
}