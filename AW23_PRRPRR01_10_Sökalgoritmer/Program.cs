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
		static bool BinarySearch(int[] numbers, int target) {
			int left = 0;
			int right = numbers.Length - 1;
			while (left <= right) {
				int checkIndex = (left + right) / 2;
				int checkValue = numbers[checkIndex];

				if (checkValue == target) {
					return true;
				} else if (checkValue > target) {
					right = checkIndex - 1;
				} else {
					left = checkIndex + 1;
				}
			}

			return false;
		}
		static void Main(string[] args) {
			int[] ints = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25 };
			bool isFound = BinarySearch(ints, 10);

			Console.WriteLine(isFound);
		}
	}
}
