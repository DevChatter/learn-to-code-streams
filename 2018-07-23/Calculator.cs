using System.Collections.Generic;

public static class Calculator
{
        public static int CalculateSum(List<int> listOfNumbers)
        {   
            int sum = 0;
            foreach (int number in listOfNumbers)
            {
                sum += number;
            }
            return sum;
        }

        public static double CalculateAvg(int sum, int countOfNumbersToAdd)
        {   
            return sum / (double)countOfNumbersToAdd;
        }
}