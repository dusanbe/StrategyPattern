using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class HondaCivic : Vehicle
	{
		public override void Accelerate()
		{
			Console.WriteLine("Accelerating like a wild goat... \n");
		}
	}
}
