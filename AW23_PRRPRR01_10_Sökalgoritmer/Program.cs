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

		static bool HasPairWithSum(int[] data, int sum) {
			int low = 0;
			int hi = data.Length - 1;
			while (low < hi) {
				int s = data[low] + data[hi];
				if (s == sum) {
					return true;
				} else if (s < sum) {
					low += 1;
				} else {
					hi -= 1;
				}
			}
			return false;
		}
		static void Main(string[] args) {
			int[] ints = new int[] { 1, 2, 4, 4 };
			bool isFound = HasPairWithSum(ints, 8);

			Console.WriteLine(isFound);
		}
	}
}
