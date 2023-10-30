namespace TrackingAlgorithm.HackerRank;

public class HackerRank_Day01
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


public class HackerRank_Day02
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> response = new();
        foreach (int item in grades)
        {
            int checkVariable = 5 * (((item - 1) / 5) + 1);
            if (item < 38)
            {
                response.Add(item);
                Console.WriteLine(item);
                continue;
            }
            if (checkVariable - item < 3)
            {
                response.Add(checkVariable);
                Console.WriteLine(checkVariable);
            } else
            {
                response.Add(item);
            }
        }
        return response;
    }

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        List<int> appleList = new(); int appleCount = 0;
        foreach (int apple in apples)
        {
            appleList.Add(a + apple);
        }
        foreach (int item in appleList)
        {
            if (item >= s && item <= t)
            {
                appleCount++;
            }
        }
        Console.WriteLine(appleCount);
        List<int> oragneList = new(); int orangeCount = 0;
        foreach (int oragne in oranges)
        {
            oragneList.Add(b + oragne);
        }
        foreach (int item in oragneList)
        {
            if (item >= s && item <= t)
            {
                orangeCount++;
            }
        }
        Console.WriteLine(orangeCount);
    }

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        return v1 == v2 ? x1 == x2 ? "YES" : "NO" : ((x1 - x2) % (v2 - v1) == 0) && ((x1 - x2) / (v2 - v1) >= 0) ? "YES" : "NO";
    }

    public static List<int> stringAnagram(List<string> dictionary, List<string> query)
    {
        List<int> result = new();

        static Dictionary<char, int> CalculateFrequency(string word) // rank
        {
            Dictionary<char, int> frequency = new();
            foreach (char c in word)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                } else
                {
                    frequency[c] = 1;
                }
            }
            return frequency;
        }

        Dictionary<string, int> wordFrequencies = new();
        foreach (string word in dictionary)
        {
            Dictionary<char, int> frequency = CalculateFrequency(word);
            string frequencyPattern = string.Join("", frequency.OrderBy(pair => pair.Key).Select(pair => $"{pair.Key}{pair.Value}"));

            if (wordFrequencies.ContainsKey(frequencyPattern))
            {
                wordFrequencies[frequencyPattern]++;
            } else
            {
                wordFrequencies[frequencyPattern] = 1;
            }
        }

        foreach (string word in query)
        {
            Dictionary<char, int> frequency = CalculateFrequency(word);
            string frequencyPattern = string.Join("", frequency.OrderBy(pair => pair.Key).Select(pair => $"{pair.Key}{pair.Value}"));

            if (wordFrequencies.ContainsKey(frequencyPattern))
            {
                result.Add(wordFrequencies[frequencyPattern]);
            } else
            {
                result.Add(0);
            }
        }

        return result;
    }

    public static long getMinCost(List<int> crew_id, List<int> job_id)
    {
        int n = crew_id.Count;
        if (n != job_id.Count)
        {
            throw new ArgumentException("Crew and job lists must have the same number of elements");
        }

        crew_id.Sort();
        job_id.Sort();

        long totalDistance = 0;

        for (int i = 0; i < n; i++)
        {
            totalDistance += Math.Abs(crew_id[i] - job_id[i]);
        }

        return totalDistance;
    }
}