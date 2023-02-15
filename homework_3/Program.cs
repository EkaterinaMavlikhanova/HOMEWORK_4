/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] array = new int[1];

void InitArray(int[] array)
{
int length = array.Length; 
int index = 0;
Random rnd = new Random(); 
while (index < length) 
{
array[index] = rnd.Next(); 
}
}

void PrintArray(int [] array)
{
for (int i = 0; i < array.Length; i++ )
{
Console.WriteLine(array[i]);
}

}

InitArray(array);
PrintArray(array);