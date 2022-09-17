Console.Write($"Задйте массив, вводя данные через запятую: ");
string info = Console.ReadLine();
string[] array = info.Split(',').ToArray();
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
