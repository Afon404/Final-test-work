

Console.Write("Введите cколько элементов Вы хотите ввести:\t ");
int size = int.Parse(Console.ReadLine()!);


string[] arrayStrings = new string[size];
int len = 3;
int pos = 0;

for (int i = 1; i < size+1; i++)
{
    
 Console.Write($"Введите {i}-й элемент:\t");
 string element = Convert.ToString(Console.ReadLine()!);

 if (element.Length <= len)
    {
 arrayStrings[pos] = element;
 pos++;
    }
}

Console.WriteLine();

PrintArray(arrayStrings);

void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.WriteLine();
}



