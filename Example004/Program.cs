// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int GetRandom()
{
    int number = new Random().Next(1, 8);
    return number;
}
int randomizer = GetRandom();
Console.WriteLine( "Число обозначающее день недели  " + randomizer );
if ( randomizer >= 6) Console.WriteLine( randomizer + " - является выходным днём" );
else Console.WriteLine( randomizer + " - является рабочим днём" );