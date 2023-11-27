// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int start = ReadConsoleInt("Введите желаемое начало диапазона чётных натуральных чисел: ");
int end = ReadConsoleInt("Введите желаемый конец диапазона чётных натуральных чисел: ");

if (start == -1 || end == -1) Console.WriteLine("Вы ввели не натуральное число, " + 
												"перезапустите программу и попробуйте снова =)");
else
{
	if (start > end) Change(start, end);
	if (start == end) Console.WriteLine("Увеличте диапазон чисел и попробуйте снова!");
	else
	{
		if ((start % 2) != 0) start += 1;
		Console.Write(start);
		Console.WriteLine(PrintEvenInteger(start + 2, end));
	}
}

int ReadConsoleInt(string message)
{
	Console.Write(message);
	int integerNumber = 0;
	var stringValue = Console.ReadLine();
	if (int.TryParse(stringValue, out integerNumber)) return integerNumber;
	else return -1;

}

string PrintEvenInteger(int a, int b)
{
	if(a <= b) return $" {a}" + PrintEvenInteger(a+2, b);
	else return $"{'\0'}";

}

void Change(int a, int b)
{
	start = b;
	end = a;
}