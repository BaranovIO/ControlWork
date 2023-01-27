string[] CreateArray(int size)
{
   string[] primaryArray = new string[size];

    for(int i = 0; i < size; i++)   
        {
            Console.Write("Введите текст для записи в элемент массива: ");
            primaryArray[i] = Console.ReadLine();
        }           
    return primaryArray;
}


void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    
       Console.Write(array[i] + " ");
    
    Console.WriteLine();	
}

string[] ArrayOfElementsWithThreeSymbols(string[] primaryArray)
{
    string[] arrayThreeSymbols = new string[primaryArray.Length];
   
    for (int i = 0, k = 0; i < primaryArray.Length; i++)
    {
        if(primaryArray[i].Length <= 3)
        {
            arrayThreeSymbols[k] = primaryArray[i];
            k++;
        }
    }
    return arrayThreeSymbols;
}


Console.Write("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] userArray = CreateArray(length);
Console.WriteLine();
Console.Write("Ваш массив: ");
ShowArray(userArray);
Console.WriteLine();
string[] arrayOfThree = ArrayOfElementsWithThreeSymbols(userArray);
Console.Write("Элементы массива, в которых не более трёх символов: ");
ShowArray(arrayOfThree);