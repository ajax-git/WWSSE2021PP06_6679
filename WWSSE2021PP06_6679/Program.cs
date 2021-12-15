/*
    Napisz program, który dla zadanej liczby całkowitej dodatniej oblicza jej reprezentację binarną.
*/

Console.Write("Podaj liczbę całkowitą dotatnią: ");
int number = int.Parse(Console.ReadLine());

int remainder;
string result = "";
while (number > 0)
{
    remainder = number % 2;
    number /= 2;
    result = remainder.ToString() + result;
}
Console.WriteLine("Reprezentacja binarna podanej liczby wynosi: {0}", result);

