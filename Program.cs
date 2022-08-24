string [] array = {"hello","2","world", ":-)"};

Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

int countOne = 0;
for (int i = 0; i < array.Length; i++)
{  
   if (array[i].Length <= 3)
   {
     countOne++;
   }
}
string [] newArray = new string[countOne];

int countTwo = 0;

for (int i = 0; i < array.Length; i++)
{  
   if (array[i].Length <= 3)
   {
     newArray[countTwo] = array[i];
     countTwo++;
   }
}

Console.WriteLine($"Полученный массив: [{String.Join(", ", newArray)}]");