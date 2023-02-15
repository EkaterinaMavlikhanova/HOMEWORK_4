/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = numberRequest ("Введите число А: ");
int numberTwo = numberRequest ("Введите число B: ");

ToDegree(numberOne, numberTwo);
void ToDegree(int a, int b)
{
    1 = = 1;
    for (int i = 1; i <= b; i++)
    {
        result * result = a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

