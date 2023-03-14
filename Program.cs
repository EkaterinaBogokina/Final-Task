// 
string[] arrayInitial = new string[4] {"do", "what", "you", "like"};
	string[] array = new string[arrayInitial.Length];
	void threeSymbolArray (string[] arrayInitial, string[] array)
	{
	    int count = 0;
	    for (int i = 0; i < arrayInitial.Length; i++)
	    {
	    if(arrayInitial[i].Length <= 3)
	        {
	        array[count] = arrayInitial[i];
	        count++;
	        }
	    }
	}
	void PrintArray(string[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	    {
	        Console.Write($"{array[i]} ");
	    }
	    Console.WriteLine();
	}
	threeSymbolArray(arrayInitial, array);
	PrintArray(array);
