using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Program start... \n");

			Vehicle hondaCivic = new HondaCivic();
			Vehicle ladaNiva = new LadaNiva();
			Vehicle nissanQuasqai = new NissanQuasqai();

			IList<Vehicle> vehicles = new List<Vehicle> { hondaCivic, ladaNiva, nissanQuasqai };

			foreach (var vehicle in vehicles)
			{
				vehicle.AllWheelsDrive();
			}

			Console.WriteLine("Amasing tech upgrade took place in Moscow... \n");
			ladaNiva.SetAllWheelsDrive(new LimitedSlipDifferencial());

			foreach (var vehicle in vehicles)
			{
				vehicle.AllWheelsDrive();
			}

			Console.ReadLine();
		}
	}
}
