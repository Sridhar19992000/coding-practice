int[] arr = { 2, 7, 4, 1, 9, 3 };

int max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
}

Console.WriteLine(max);

