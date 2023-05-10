using System;

namespace Money_OperatorOverload
{
	class Program
	{
		static void Main(string[] args)
		{
			var money1 = new Money(10);
			var money2 = new Money(20);

			var money3 = money1 + money2;
			Console.WriteLine(money3.Amount);

			Console.ReadKey();
		}
	}
}
