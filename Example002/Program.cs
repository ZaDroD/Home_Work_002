// Удалить вторую цифру трёхзначного числа

int GetRandom()
{
    int number = new Random().Next(100, 999);
    return number;
}
int randomizer = GetRandom();
Console.WriteLine("Случайное число " + randomizer);
int firstResult = randomizer / 100;
int secondResult = randomizer % 10;
Console.WriteLine(firstResult .. secondResult);