using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Średnia ocen ucznia");
		Console.WriteLine("Ile uczeń ma ocen? ");
		string resp = Console.ReadLine();
		int n = Int32.Parse(resp);
		
		float total = 0.0F;
		
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("Podaj ocenę: ");
			float temp = float.Parse(Console.ReadLine());
			total += temp;
		}
		
		float avg = total / n;
		Console.WriteLine($"Średnia: {avg}");
		
		if (avg >= 3.0)
		{
			Console.WriteLine("Uczeń zdał.");
		}
		else
		{
			Console.WriteLine("Uczeń nie zdał.");
		}
	}
}