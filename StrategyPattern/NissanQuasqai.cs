using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class NissanQuasqai : Vehicle
	{
		public NissanQuasqai()
		{
			SetAllWheelsDrive(new LimitedSlipDifferencial());
		}

		public override void Accelerate()
		{
			Console.WriteLine("Accelerating... \n");
		}
	}
}
