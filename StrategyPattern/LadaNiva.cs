using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class LadaNiva : Vehicle
	{
		public LadaNiva()
		{
			SetAllWheelsDrive(new ReductorStrategy());
		}

		public override void Accelerate()
		{
			Console.WriteLine("Hardly accelerating... \n");
		}
	}
}
