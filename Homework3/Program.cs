#region Task1:Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm misal:input {5,9,12,11} output 9, 12

//int[] numbers = { 3, 7, 9, 24, 23, 16, 17, 19 };
//Console.WriteLine("Murekkeb ededler:");
//for (int j = numbers.Length - 1; j >= 0; j--)
//{
//    int number = numbers[j];
//    int count = 0;
//    if (number > 1)
//    {
//        for (int i = 2; i < number; i++)
//        {
//            if (number % i == 0)
//            {
//                count++;
//            }
//        }
//        if (count > 0)
//        {
//            Console.WriteLine(number);
//        }
//    }
//} 
#endregion

#region .Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxaran algorithm

//int[] array2 = { 1, 5, 13, 15 };
//Console.WriteLine("Ortaq elementler:");
//for (int i = 0; i < array1.Length; i++)
//{
//    for (int j = 0; j < array2.Length; j++)
//    {
//        if (array1[i] == array2[j])
//        {
//            Console.WriteLine(array1[i]); 
//        }
//    }
//}

#endregion

#region Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxaran  algorithm 
//int[] arr = { 91,85,3,56,18 };
//int max =arr[0];
//int min = arr[0];
//int maxIndex = 0;
//int minIndex = 0;
//for (int i = 1; i < arr.Length; i++)
//{

//    if (arr[i] < min)
//    {
//        min = arr[i];
//        minIndex = i;
//    }
//    if (arr[i] > max)
//    {
//        max = arr[i];
//        maxIndex = i;
//    }
//}
//Console.WriteLine("En kicik indexli: " + minIndex);
//Console.WriteLine("en boyuk indexli: " + maxIndex); 
#endregion

#region Verilmish ededin mertebelerinin cemini tapan algorithm
//Console.WriteLine("Eded daxil edin:");
//int number = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//while (number > 0)
//{
//    sum += number % 10;
//    number /= 10;
//}
//Console.WriteLine("ededin reqemlerinin cemi: " + sum); 
#endregion

#region 1-den 10 qeder olan arrayda bir reqem eskikdir. Eskik olan reqemi tapan algorithm yazin
//int[] arr = { 4, 1, 9, 6, 10, 2, 5, 8, 3 };
//int expectedSum = 55; 
//int actualSum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    actualSum += arr[i];
//}
//int missingNumber = expectedSum - actualSum;
//Console.WriteLine("Eksik olan reqem " + missingNumber); 
#endregion