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