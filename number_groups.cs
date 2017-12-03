using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        int k = Convert.ToInt32(Console.ReadLine());
        long answer = sumOfGroup(k);
        Console.WriteLine(answer);
    }

    static long sumOfGroup(int k) {
        long kl = k;

        // Return the sum of the elements of the k'th group.
        long first = firstElemOfGroup(kl);
        long last = first + 2 * (kl - 1);

        return sumOfOdds(first, last);
    }

    static long firstElemOfGroup(long k) {
        return ((k - 1) * k / 2) * 2 + 1;
    }

    static long sumOfOdds(long a, long b) {
        if (a != 1) {
            long big = (b + 1) * (b + 1) / 4;
            long small = (a - 1) * (a - 1) / 4;
            return big - small;
        } else {
            return (b + 1) * (b + 1) / 4;
        }
    }

    static long sumOfOddsBrute(int a, int b) {
        int sum = 0;
        for (int odd = a; odd <= b; odd += 2) {
            sum += odd;
        }
        return sum;
    }
}
