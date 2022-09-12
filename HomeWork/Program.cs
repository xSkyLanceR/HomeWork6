//Задача № 1
// int [] ArrayString (string stringArray)
// {
//     string [] nums = stringArray.Split(' ');
//     int [] result = new int[nums.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = Convert.ToInt32(nums[i]);
//     }
//     return result;
// }
// int CountNumbers(int[] arr)
// {
//     int count = 0;
//     foreach (var item in arr)
//     {
//         if (item > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// System.Console.WriteLine("Ввод чисел через пробел: ");
// int [] numbers = ArrayString(System.Console.ReadLine());
// System.Console.WriteLine ($"Количество положительных чисел в массиве: {CountNumbers(numbers)}");

// Задача № 2
  
 string [] stringArray = Console.ReadLine().Split(' ');

double b1 = double.Parse(stringArray[0]);
double k1 = double.Parse(stringArray[1]);
double b2 = double.Parse(stringArray[2]);
double k2 = double.Parse(stringArray[3]);

double [] Point(double b1, double k1, double b2, double k2)
{
    double [] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    
    return result;
}

System.Console.WriteLine(string.Join(" ", Point(b1, k1, b2, k2)));
