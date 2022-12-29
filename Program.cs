Console.WriteLine("type a length of array"); 
int arrayLength = int.Parse(Console.ReadLine()); // ввод размера массива
string [] FillArray (int arrayLength) // заполнение массива с клавиатуры
{
  string [] array = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
      Console.WriteLine("type a word");
      array [i] = Console.ReadLine(); 
    }
    return array;
}
string [] ChangeArray (string [] array) // изменение массива
{ 
 int num = 0; // длина нового массива
 for (int i = 0; i < array.Length; i++)
 { 
    if (array[i].Length < 4)
    {
      num = num + 1;
    }
 }
 string [] newArray = new string [num];
 int d = 0;
 for (int j = 0; j < array.Length; j++)
 {
    if (array[j].Length < 4)
    {
      for (int k = d; k < newArray.Length; k++)
      {
      newArray[k] = array[j];
      }
      d++;
    }
}
return newArray;
}
void PrintArray(string [] newArray)
{
for (int i = 0; i < newArray.Length; i++)
{
  Console.Write($"{newArray [i]},  ");
}
}
string [] newString = FillArray (arrayLength);
string [] changedString = ChangeArray (newString);
PrintArray (changedString);