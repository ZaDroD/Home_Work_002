// Показать вторую цифру трёхзначного числа

int GetRandom()
{
    int num = new Random().Next(100, 999);
    return num;
}

int randomizer = GetRandom();

Console.WriteLine("Трёхзначное число : " + randomizer);

int result = randomizer % 100 / 10;

Console.WriteLine("Вторая цифра трёхзначного числа = " + result);