Console.Write("Введите числа через запятую:  ");

int[] numbers = StringNumbers(Console.ReadLine());
PrintArray(numbers);

int[] StringNumbers(string input)
{
    int countNumbers = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
        {
            countNumbers++;
        }
    }

    int[] numbers = new int[countNumbers];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string tempString = "";

        while(input[i] != ',')
        {
            tempString += input[i].ToString();
            if(i == input.Length - 1)
            {
                break;
            }
            i++;
        }
        numbers[index] = Convert.ToInt32(tempString);
        index++;
    }

    return numbers;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    Console.Write($"[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{arr[i]}/");
    }
    Console.Write($"{arr[size - 1]}]");
    Console.WriteLine();
}