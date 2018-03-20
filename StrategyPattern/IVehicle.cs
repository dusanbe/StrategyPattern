using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	public interface IVehicle
	{
		void Accelerate();
		//Umesto interace metode koristimo zasebnu klasu
		//void AllWheelsDrive();
	}
}
