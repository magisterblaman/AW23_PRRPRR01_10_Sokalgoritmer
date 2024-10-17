using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_10_Sökalgoritmer {
	internal class Program {
		static int LinearSearch(int[] numbers, int target) {
			for (int i = 0; i < numbers.Length; i++) {
				if (numbers[i] == target) {
					return i;
				}
			}
			return -1;
		}
		static void Main(string[] args) {
			int[] ints = new int[] { 46, 127, 121, 7, 88, 58, 124, 19, 79 };
			int foundIndex = LinearSearch(ints, 40);

			Console.WriteLine(foundIndex);
		}
	}
}
