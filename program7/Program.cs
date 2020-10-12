using System;

public class Program
{
	public static void Main()
	{
		String v = Console.ReadLine();
		int l = v.Length;
		int l1 = l / 2;
		String v1, v2;
		v1 = v.Substring(0, l1);
		v2 = v.Substring(l1);
		char c1, c2;
		int a, b, diff;
		for (int i = 0; i < l1; i++)
		{
			c1 = v1[i];
			c2 = v2[i];
			a = (int)c1;
			b = (int)c2;
			diff = a - b;
			Console.WriteLine(diff + "  ");

		}


	}
}
