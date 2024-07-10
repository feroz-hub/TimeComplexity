int[] array = [1, 2, 3, 4, 5];

// O(1) example
Console.WriteLine("O(1) example: ");
Console.WriteLine(GetFirstElement(array));

// O(n) example
Console.WriteLine("\nO(n) example: ");
Console.WriteLine(SumArray(array));

// O(n^2) example
Console.WriteLine("\nO(n^2) example: ");
PrintPairs(array);

// O(log n) example
Console.WriteLine("\nO(log n) example: ");
Console.WriteLine(BinarySearch(array, 3));

// O(n log n) example
Console.WriteLine("\nO(n log n) example: ");
int[] unsortedArray = { 5, 3, 1, 4, 2 };
SortArray(unsortedArray);
Console.WriteLine(string.Join(", ", unsortedArray));

// O(2^n) example
Console.WriteLine("\nO(2^n) example: ");
Console.WriteLine(Fibonacci(5));
// O(1) - Constant Time Complexity
static int GetFirstElement(int[] array)
{
    return array[0];
}

// O(n) - Linear Time Complexity
static int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

// O(n^2) - Quadratic Time Complexity
static void PrintPairs(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[i] + ", " + array[j]);
        }
    }
}

// O(log n) - Logarithmic Time Complexity
static int BinarySearch(int[] sortedArray, int target)
{
    int left = 0, right = sortedArray.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (sortedArray[mid] == target)
            return mid;
        if (sortedArray[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }
    return -1;
}

// O(n log n) - Linearithmic Time Complexity
static void SortArray(int[] array)
{
    Array.Sort(array);
}

// O(2^n) - Exponential Time Complexity
static int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}