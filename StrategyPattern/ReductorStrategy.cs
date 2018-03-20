using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public class ReductorStrategy : IAllWheelsDriveStrategy
	{
		public void AllWheelsDrive()
		{
			Console.WriteLine("Drive ratio controled unit. \n");
		}
	}
}
