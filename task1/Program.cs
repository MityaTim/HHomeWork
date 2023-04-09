// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"four", "333", "55555", "1", ":-)", ":>", "hello!", "some long sentence"};
string[] arr = CutArray(array, maxStrLength: 3);
string outputString = string.Join(", ", arr);
Console.WriteLine(outputString);
string[] CutArray(string[] strings, int maxStrLength)
{
	string[] value = new string[strings.Length];
	int j = 0;
	for (int i = 0; i < strings.Length; i++)
	{
		if (strings[i].Length <= maxStrLength)
		{
			value[j] = strings[i];
			j++;
		}
	}
string[] cutArray = value[..j];
return cutArray;
}