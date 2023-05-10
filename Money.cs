using System;
using System.Collections.Generic;
using System.Text;

namespace Money_OperatorOverload
{
	class Money
	{
		private readonly int amount;

		public int Amount => amount;

		public Money(int value)
		{
			amount = value;
		}

		public static Money operator +(Money money1, Money money2)
		{
			var value = money1.Amount + money2.Amount;
			return new Money(value);
		}

		public static Money operator -(Money money1, Money money2)
		{
			var value = money1.Amount - money2.Amount;
			return new Money(value);
		}

		public static bool operator >(Money money1, Money money2)
		{
			var value = money1.Amount > money2.Amount;
			return value;
		}

		public static bool operator <(Money money1, Money money2)
		{
			var value = money1.Amount > money2.Amount;
			return value;
		}

		public static bool operator >=(Money money1, Money money2)
		{
			var value = money1.Amount >= money2.Amount;
			return value;
		}

		public static bool operator <=(Money money1, Money money2)
		{
			var value = money1.Amount <= money2.Amount;
			return value;
		}

		public static bool operator ==(Money money1, Money money2)
		{
			var value = money1.Amount > money2.Amount;
			return value;
		}

		public static bool operator !=(Money money1, Money money2)
		{
			var value = money1.Amount > money2.Amount;
			return value;
		}
	}
}
