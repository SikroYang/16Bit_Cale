using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Bit_Cale
{
	public class Program
	{
		public static void Main(string[] args)
		{
			bool JIXU = true;
			do {
				Console.WriteLine("请输入数字:(按X退出)");
				var readValue = Console.ReadLine();
				if (readValue == "X") {
					JIXU = false;
				}
				else {
					var ceNum = RToCENumber(readValue);
					Console.WriteLine(ceNum);
				}
			} while (JIXU);
		}

		private static string RToCENumber(string readValue) {
			try {
				var readNum = Convert.ToInt32(readValue) - 5474;
				var num = Convert.ToInt16("FFFF", 16) + Convert.ToInt16("1", 16);
				var value = (readNum + num) ^ Convert.ToInt16("229F", 16);
				var result = Convert.ToString(value, 16).ToUpper();
				return result;
			}
			catch {
				return "输入或计算错误!";
			}
		}
	}
}
