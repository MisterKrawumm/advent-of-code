// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] input = File.ReadAllLines("C:\\Users\\fritz\\Desktop\\01_Fritz.txt");



List<long> calories= new List<long>();
long summe=0;
foreach (string line in input)
{
    if (line.Length == 0)
    {
        calories.Add(summe);
        summe=0;
    }
    else
    {
        summe += long.Parse(line);
    }
}


Console.WriteLine(calories.Max());