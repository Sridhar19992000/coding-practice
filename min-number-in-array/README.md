
## 🧵 Logic
1. Assume the first number is the smallest (`min = numbers[0]`)
2. Loop from the second number
3. Compare each number with `min`
4. If any number is smaller, update `min`
5. After the loop, `min` holds the smallest number

## 🧩 C# Code

```csharp
int min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
        min = numbers[i];
}
