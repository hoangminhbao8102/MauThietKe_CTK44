using System;
using System.Runtime.CompilerServices;

namespace DoFactory.GangOfFour.Adapter.Structural
{
	class MainApp
	{
		static void Main()
		{
			Target target = new Adapter();
			target.Request();

			Console.ReadKey();
		}
	}
}