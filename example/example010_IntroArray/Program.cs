//               0   1   2   3   4   5   6   7   8    9  10
int[] array = { 21, 24, 733, 45, 95, 45, 63, 17, 38, 19, 45 };

int n = array.Length;
int find = 45;

int index = 0;

while (index < n)
{

	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	//index = index + 1;
	index++;
}