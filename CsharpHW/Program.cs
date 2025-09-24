using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 46, 20, 330, 46, 5121 };
        int n = numbers.Length;

        // 1. Print array elements
        Console.WriteLine("1. Printing all elements:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();

        // 2. Maximum element
        int max = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("2. Maximum Element: " + max);
        Console.WriteLine();

        // 3. Minimum element
        int min = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("3. Minimum Element: " + min);
        Console.WriteLine();

        // 4. Sum of elements
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("4. Sum of Elements: " + sum);
        Console.WriteLine();

        // 5. Reverse array
        Console.WriteLine("5. Array in Reverse Order:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();

        // 6. Count even and odd numbers
        int even = 0;
        int odd = 0;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        Console.WriteLine("6. Even Numbers: " + even);
        Console.WriteLine("6. Odd Numbers: " + odd);
        Console.WriteLine();

        // 7. Search element
        Console.Write("7. Enter number to search: ");
        int searchNum = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] == searchNum)
            {
                Console.WriteLine("Found at index: " + i);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Such element does not exist");
        }
        Console.WriteLine();

        // 8. Copy array
        int[] copy = new int[n];
        for (int i = 0; i < n; i++)
        {
            copy[i] = numbers[i];
        }
        Console.WriteLine("8. Copied Array:");
        for (int i = 0; i < copy.Length; i++)
        {
            Console.WriteLine(copy[i]);
        }
        Console.WriteLine();

        // 9. Second largest element
        int firstMax = int.MinValue;
        int secondMax = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > firstMax)
            {
                secondMax = firstMax;
                firstMax = numbers[i];
            }
            else if (numbers[i] > secondMax && numbers[i] != firstMax)
            {
                secondMax = numbers[i];
            }
        }
        Console.WriteLine("9. Second Largest Number: " + secondMax);
        Console.WriteLine();

        // 10. Frequency of elements
        Console.WriteLine("10. Frequency of Elements:");
        bool[] visited = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (visited[i])
                continue;

            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            Console.WriteLine(numbers[i] + " appears " + count + " times");
        }
        Console.WriteLine();

        // 11. Array Rotation (Left by 2)
        int d = 2;
        int[] temp = new int[d];
        for (int i = 0; i < d; i++)
        {
            temp[i] = numbers[i];
        }
        for (int i = d; i < n; i++)
        {
            numbers[i - d] = numbers[i];
        }
        for (int i = 0; i < d; i++)
        {
            numbers[n - d + i] = temp[i];
        }
        Console.WriteLine("11. Left Rotated by 2: " + string.Join(", ", numbers));

        // Right rotate by 2
        for (int i = 0; i < d; i++)
        {
            temp[i] = numbers[n - d + i];
        }
        for (int i = n - d - 1; i >= 0; i--)
        {
            numbers[i + d] = numbers[i];
        }
        for (int i = 0; i < d; i++)
        {
            numbers[i] = temp[i];
        }
        Console.WriteLine("11. Right Rotated by 2: " + string.Join(", ", numbers));
        Console.WriteLine();

        // 12. Sort array without built-in sort (Bubble Sort)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int t = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = t;
                }
            }
        }
        Console.WriteLine("12. Sorted Array: " + string.Join(", ", numbers));
        Console.WriteLine();

        // 13. Remove duplicates
        int[] tempUnique = new int[n];
        int countUnique = 0;
        for (int i = 0; i < n; i++)
        {
            bool duplicate = false;
            for (int j = 0; j < countUnique; j++)
            {
                if (numbers[i] == tempUnique[j])
                {
                    duplicate = true;
                    break;
                }
            }
            if (!duplicate)
            {
                tempUnique[countUnique] = numbers[i];
                countUnique++;
            }
        }
        int[] unique = new int[countUnique];
        for (int i = 0; i < countUnique; i++)
        {
            unique[i] = tempUnique[i];
        }
        Console.WriteLine("13. Unique Array: " + string.Join(", ", unique));
        Console.WriteLine();

        // 14. Merge with another sorted array
        int[] numbers2 = { 2, 4, 6 };
        int n1 = unique.Length;
        int n2 = numbers2.Length;
        int[] merged = new int[n1 + n2];
        int i1 = 0, i2 = 0, k = 0;
        while (i1 < n1 && i2 < n2)
        {
            if (unique[i1] < numbers2[i2])
            {
                merged[k++] = unique[i1++];
            }
            else
            {
                merged[k++] = numbers2[i2++];
            }
        }
        while (i1 < n1)
        {
            merged[k++] = unique[i1++];
        }
        while (i2 < n2)
        {
            merged[k++] = numbers2[i2++];
        }
        Console.WriteLine("14. Merged Array: " + string.Join(", ", merged));
        Console.WriteLine();

        // 15. Insert element at index 3
        int elementToInsert = 99;
        int insertIndex = 3;
        int[] arrInsert = new int[merged.Length + 1];
        for (int i = 0; i < insertIndex; i++)
        {
            arrInsert[i] = merged[i];
        }
        arrInsert[insertIndex] = elementToInsert;
        for (int i = insertIndex; i < merged.Length; i++)
        {
            arrInsert[i + 1] = merged[i];
        }
        Console.WriteLine("15. After inserting 99 at index 3: " + string.Join(", ", arrInsert));
        Console.WriteLine();

        // 16. Delete element at index 3
        int deleteIndex = 3;
        int[] arrDelete = new int[arrInsert.Length - 1];
        for (int i = 0; i < deleteIndex; i++)
        {
            arrDelete[i] = arrInsert[i];
        }
        for (int i = deleteIndex + 1; i < arrInsert.Length; i++)
        {
            arrDelete[i - 1] = arrInsert[i];
        }
        Console.WriteLine("16. After deleting element at index 3: " + string.Join(", ", arrDelete));
        Console.WriteLine();

        // 17. Find pairs with sum 10
        Console.WriteLine("17. Pairs with sum 10:");
        for (int i = 0; i < arrDelete.Length - 1; i++)
        {
            for (int j = i + 1; j < arrDelete.Length; j++)
            {
                if (arrDelete[i] + arrDelete[j] == 10)
                {
                    Console.WriteLine(arrDelete[i] + " + " + arrDelete[j]);
                }
            }
        }
        Console.WriteLine();

        // 18. Check if array is palindrome
        int[] palindromeArr = { 1, 2, 3, 2, 1 };
        bool isPalindrome = true;
        for (int i = 0; i < palindromeArr.Length / 2; i++)
        {
            if (palindromeArr[i] != palindromeArr[palindromeArr.Length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }
        Console.WriteLine("18. Is palindrome? " + isPalindrome);
    }
}
