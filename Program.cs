string[] CreateArray(int size)
{
    
    string[] array = new string[size];

    for(int i = 0; i < size; i++)   
        {
            Console.Write("Введите текст для записи в элемент массива: ");
            array[i] = Console.ReadLine();

        }

           
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    
       Console.Write(array[i] + " ");
    
    Console.WriteLine();	
}

string[] ArrayOfElementsWithThreeSymbols(string[] userArray)
{
    string[] modifiedArray = new string[userArray.Length];
   
    for (int i = 0, k = 0; i < userArray.Length; i++)
    {
        if(userArray[i].Length <= 3)
        {
            modifiedArray[k] = userArray[i];
            k++;
        }
    }
    return modifiedArray;
}


Console.Write("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(length);
Console.WriteLine();
Console.Write("Ваш массив: ");
ShowArray(myArray);
Console.WriteLine();
string[] arrayOfThree = ArrayOfElementsWithThreeSymbols(myArray);
Console.Write("Элементы массива, в которых не более трёх символов: ");
ShowArray(arrayOfThree);


