namespace TrackingAlgorithm.HackerRank;

public class HackerRackSolution
{
    public static int simpleArraySum(List<int> ar)
    {
        int Sum = 0;
        foreach (int item in ar)
        {
            Sum += item;
        }

        return Sum;
    }

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int aCount = 0;
        int bCount = 0;
        List<int> retList = new();
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < b.Count; j++)
            {
                if (i == j)
                {
                    if (a[i] > b[j])
                    {
                        aCount++;
                    }
                    if (a[i] < b[j])
                    {
                        bCount++;
                    }
                    if (a[i] == b[j])
                    {
                        continue;
                    }
                }
            }
        }
        retList.Add(aCount);
        retList.Add(bCount);
        return retList;
    }

    public static long aVeryBigSum(List<long> ar)
    {
        long Sum = 0;
        foreach (int item in ar)
        {
            Sum += item;
        }

        return Sum;
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumMain = 0;
        int sumCounter = 0;
        // CounterDiagonal
        List<int> CounterDiagonal = new();
        int n = arr.Count;
        for (int i = 0; i < arr.Count; i++)
        {
            CounterDiagonal.Add(arr[i][n - 1 - i]);
        }
        foreach (int item in CounterDiagonal)
        {
            sumCounter += item;
        }
        // MainDiagonal
        List<int> MainDiagonal = new();
        for (int i = 0; i < arr.Count; i++)
        {
            MainDiagonal.Add(arr[i][i]);
        }
        foreach (int item in MainDiagonal)
        {
            sumMain += item;
        }


        return Math.Abs(sumMain - sumCounter); // Make number in positive
    }

    public static void plusMinus(List<int> arr)
    {
        int CountOfPositive = 0; int CountOfNegative = 0; int CountOfZero = 0; int TotalListCount = arr.Count;
        foreach (int item in arr)
        {
            if (item is 0)
            {
                CountOfZero++;
            }
            if (item > 0)
            {
                CountOfPositive++;
            }
            if (item < 0)
            {
                CountOfNegative++;
            }
        }
        double x = (double)CountOfPositive / TotalListCount;
        double y = (double)CountOfNegative / TotalListCount;
        double z = (double)CountOfZero / TotalListCount;
        Console.WriteLine(x.ToString("N6"));
        Console.WriteLine(y.ToString("N6"));
        Console.WriteLine(z.ToString("N6"));
    }

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    public static void miniMaxSum(List<int> arr)
    {
        long minSum = 9223372036854775807; long maxSum = 0;

        for (int i = 0; i <= arr.Count - 1; i++)
        {
            long Sum = 0;
            for (int j = 0; j <= arr.Count - 1; j++)
            {
                if (i == j)
                {
                    continue;
                }
                Sum += arr[j];

            }
            if (maxSum < Sum)
            {
                maxSum = Sum;
            }
            if (minSum > Sum)
            {
                minSum = Sum;
            }
        }
        Console.WriteLine("Max  " + maxSum);
        Console.WriteLine("Min " + minSum);
    }

    public static int birthdayCakeCandles(List<int> candles)
    {
        int height = 0; int count = 0;
        foreach (int candle in candles)
        {
            if (height < candle)
            {
                height = candle;
            }
        }
        foreach (int item in candles)
        {
            if (height == item)
            {
                count++;
            }
        }
        return count;
    }
}
