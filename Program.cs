Console.WriteLine($"Введите число для сравнения и нажмите Enter");
int compareNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите число, отображающее длину изначального массива и нажмите Enter");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string [] array = new string [arrayLength];

int newArraySize = 0;

for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Введите {i}-ый элемент массива и нажмите Enter (если вы ничего не введете, элемент массива будет засчитан, как 0)");
    array[i] = Console.ReadLine();
    if (array[i] is null) array[i] = "0";
    string firstArrayElement = array[i];
    int firstArrayElementLength = firstArrayElement.Length;
    if (firstArrayElementLength <= compareNumber)
    {
        newArraySize ++;
    }
}