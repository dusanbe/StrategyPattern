using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public abstract class Vehicle : IVehicle
	{
		public abstract void Accelerate();

		public IAllWheelsDriveStrategy AllWheelsDriveStrategy { get; set; }

		public void SetAllWheelsDrive(IAllWheelsDriveStrategy allWheelsDriveStrategy)
		{
			this.AllWheelsDriveStrategy = allWheelsDriveStrategy;
		}

		public virtual void AllWheelsDrive()
		{
			Console.WriteLine(GetType().Name);
			if (this.AllWheelsDriveStrategy == null)
			{
				Console.WriteLine("This vehicle does not support all wheels drive! \n");
			}
			else
			{
				this.AllWheelsDriveStrategy.AllWheelsDrive();
			}
		}
	}
}
