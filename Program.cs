//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string str = GetString();
string[] array = StringToArray(str);
string[] FinalArray = GetThreeElementArray(array);
Console.WriteLine();
PrintArray(FinalArray);

string GetString()
{
    	Console.WriteLine("Введите символы через пробел");
    	return Console.ReadLine();
}

string[] StringToArray(string str)
{
    	string[] stringArray = str.Split(" ");
    	return stringArray;
}

string[] GetThreeElementArray(string[] array)
{
    	int count = 0;
    	for (int i = 0; i < array.Length; i++)
    	{
        	if (array[i].Length <= 3)
        	{
            	count++;
        	}
    	}
    	string[] FinalArray = new string[count];
    	count = 0;
    	for (int i = 0; i < array.Length; i++)
    	{
        	if (array[i].Length <= 3)
        	{
            	FinalArray[count] = array[i];
            	count++;
        	}
    	}
    	return FinalArray;
}

void PrintArray(string[] array)
{
    	for (int i = 0; i < array.Length; i++)
    	{
        	Console.Write(array[i] + " ");
    	}
}
