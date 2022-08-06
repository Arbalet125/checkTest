Console.WriteLine($"Введите число для сравнения и нажмите Enter");
int compareNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите число, отображающее длину изначального массива и нажмите Enter");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string [] array = new string [arrayLength];

int newArraySize = 0;
