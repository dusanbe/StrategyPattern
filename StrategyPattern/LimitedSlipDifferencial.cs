using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	class LimitedSlipDifferencial : IAllWheelsDriveStrategy
	{
		public void AllWheelsDrive()
		{
			Console.WriteLine("Limited drive transfer. \n");
		}
	}
}
