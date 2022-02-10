// Найти третью цифру числа или сообщить что её нет

int GetRandom()
{
    int number = new Random().Next(0, 999);
    return number;
}
int randomizer = GetRandom();
Console.WriteLine("Случайное число " + randomizer);
int result = randomizer / 10;
if (result >= 10)
{
    Console.WriteLine(randomizer % 10);
}
else
{
    Console.WriteLine("Третье число отсутствует");
}