using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 46, 20, 330, 46, 5121 };

        // print array elements
        PrintArray(numbers);

        //maximum element
        Console.WriteLine("Maximum Element: " + FindMax(numbers));
        Console.WriteLine();

        // minimum element
        Console.WriteLine("Minimum Element: " + FindMin(numbers));
        Console.WriteLine();

        // sum of elements
        Console.WriteLine("Sum of Elements: " + FindSum(numbers));
        Console.WriteLine();

        // reverse array
        Console.WriteLine("array in Reverse Order:");
        PrintArrayReverse(numbers);

        // count even and odd
        CountEvenOdd(numbers);

        // search element
        SearchElement(numbers);

        // copy array
        int[] copy = CopyArray(numbers);
        Console.WriteLine("Copied Array: " + string.Join(", ", copy));
        Console.WriteLine();

        // second largest element
        Console.WriteLine("Second Largest Number: " + FindSecondLargest(numbers));
        Console.WriteLine();

        //frequency
        PrintFrequency(numbers);

        // rotations
        int[] leftRotated = LeftRotate(numbers, 2);
        Console.WriteLine("Left Rotated by 2: " + string.Join(", ", leftRotated));

        int[] rightRotated = RightRotate(numbers, 2);
        Console.WriteLine("Right Rotated by 2: " + string.Join(", ", rightRotated));
        Console.WriteLine();

        // bubble Sort
        int[] sorted = BubbleSort(numbers);
        Console.WriteLine("Sorted Array: " + string.Join(", ", sorted));
        Console.WriteLine();

        // remove duplicates
        int[] unique = RemoveDuplicates(sorted);
        Console.WriteLine("Unique Array: " + string.Join(", ", unique));
        Console.WriteLine();

        // merge with another sorted array
        int[] merged = MergeArrays(unique, new int[] { 2, 4, 6 });
        Console.WriteLine("Merged Array: " + string.Join(", ", merged));
        Console.WriteLine();

        // insert element
        int[] inserted = InsertAtIndex(merged, 99, 3);
        Console.WriteLine("After inserting 99 at index 3: " + string.Join(", ", inserted));
        Console.WriteLine();

        // delete element
        int[] deleted = DeleteAtIndex(inserted, 3);
        Console.WriteLine("After deleting element at index 3: " + string.Join(", ", deleted));
        Console.WriteLine();

        // pairs with sum
        Console.WriteLine("Pairs with sum 10:");
        FindPairsWithSum(deleted, 10);
        Console.WriteLine();

        // palindrome check
        int[] palindromeArr = { 1, 2, 3, 2, 1 };
        Console.WriteLine("Is palindrome? " + IsPalindrome(palindromeArr));
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Printing all elements:");
        foreach (int num in arr) Console.WriteLine(num);
        Console.WriteLine();
    }

    static int FindMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr) if (num > max) max = num;
        return max;
    }

    static int FindMin(int[] arr)
    {
        int min = arr[0];
        foreach (int num in arr) if (num < min) min = num;
        return min;
    }

    static int FindSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr) sum += num;
        return sum;
    }

    static void PrintArrayReverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) Console.WriteLine(arr[i]);
        Console.WriteLine();
    }

    static void CountEvenOdd(int[] arr)
    {
        int even = 0, odd = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0) even++;
            else odd++;
        }
        Console.WriteLine("Even Numbers: " + even);
        Console.WriteLine("Odd Numbers: " + odd);
        Console.WriteLine();
    }

    static void SearchElement(int[] arr)
    {
        Console.Write("7. Enter number to search: ");
        int searchNum = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchNum)
            {
                Console.WriteLine("Found at index: " + i);
                Console.WriteLine();
                return;
            }
        }
        Console.WriteLine("Such element does not exist\n");
    }

    static int[] CopyArray(int[] arr)
    {
        int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) copy[i] = arr[i];
        return copy;
    }

    static int FindSecondLargest(int[] arr)
    {
        int first = int.MinValue, second = int.MinValue;
        foreach (int num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                second = num;
            }
        }
        return second;
    }

    static void PrintFrequency(int[] arr)
    {
        Console.WriteLine("Frequency of Elements:");
        bool[] visited = new bool[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i]) continue;
            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            Console.WriteLine(arr[i] + " appears " + count + " times");
        }
        Console.WriteLine();
    }

    static int[] LeftRotate(int[] arr, int d)
    {
        int n = arr.Length;
        int[] rotated = new int[n];
        for (int i = 0; i < n; i++) rotated[i] = arr[(i + d) % n];
        return rotated;
    }

    static int[] RightRotate(int[] arr, int d)
    {
        int n = arr.Length;
        int[] rotated = new int[n];
        for (int i = 0; i < n; i++) rotated[(i + d) % n] = arr[i];
        return rotated;
    }

    static int[] BubbleSort(int[] arr)
    {
        int[] sorted = (int[])arr.Clone();
        int n = sorted.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (sorted[j] > sorted[j + 1])
                {
                    int temp = sorted[j];
                    sorted[j] = sorted[j + 1];
                    sorted[j + 1] = temp;
                }
            }
        }
        return sorted;
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int count = 0;
        foreach (int num in arr)
        {
            bool duplicate = false;
            for (int j = 0; j < count; j++)
            {
                if (temp[j] == num) { duplicate = true; break; }
            }
            if (!duplicate) temp[count++] = num;
        }
        int[] result = new int[count];
        Array.Copy(temp, result, count);
        return result;
    }

    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length, n2 = arr2.Length;
        int[] merged = new int[n1 + n2];
        int i = 0, j = 0, k = 0;
        while (i < n1 && j < n2)
        {
            if (arr1[i] < arr2[j]) merged[k++] = arr1[i++];
            else merged[k++] = arr2[j++];
        }
        while (i < n1) merged[k++] = arr1[i++];
        while (j < n2) merged[k++] = arr2[j++];
        return merged;
    }

    static int[] InsertAtIndex(int[] arr, int element, int index)
    {
        int[] result = new int[arr.Length + 1];
        for (int i = 0; i < index; i++) result[i] = arr[i];
        result[index] = element;
        for (int i = index; i < arr.Length; i++) result[i + 1] = arr[i];
        return result;
    }

    static int[] DeleteAtIndex(int[] arr, int index)
    {
        int[] result = new int[arr.Length - 1];
        for (int i = 0; i < index; i++) result[i] = arr[i];
        for (int i = index + 1; i < arr.Length; i++) result[i - 1] = arr[i];
        return result;
    }

    static void FindPairsWithSum(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                    Console.WriteLine(arr[i] + " + " + arr[j]);
            }
        }
    }

    static bool IsPalindrome(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            if (arr[i] != arr[arr.Length - 1 - i]) return false;
        }
        return true;
    }
}
