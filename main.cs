using System;

class MainClass {
  public static void Main (string[] args) {
    int[] firstArray = new int[3];
    int[] secondArray = new int[3];
    int[] thirdArray = new int[6];

    firstArray[0] = 4;
    firstArray[1] = 8;
    firstArray[2] = 15;

    secondArray[0] = 16;
    secondArray[1] = 23;
    secondArray[2] = 42;

    thirdArray[0] = 4;
    thirdArray[1] = 8;
    thirdArray[2] = 15;
    thirdArray[3] = 16;
    thirdArray[4] = 23;
    thirdArray[5] = 42;

    Console.WriteLine(thirdArray[0] + " " + thirdArray[1] + " " + thirdArray[2] + " " + thirdArray[3] + " " + thirdArray[4] + " " + thirdArray[5]);
  }
}