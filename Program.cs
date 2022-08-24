string [] array = {"hello","2","world", ":-)"};



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

Console.WriteLine($"[{String.Join(", ", newArray)}]");