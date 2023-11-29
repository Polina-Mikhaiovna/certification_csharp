// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("*****************************************************************************************");
Console.WriteLine("**** Программа нахождения суммы натуральных чисел (1, 2, 3...) в указанном диапазоне ****");
Console.WriteLine("*****************************************************************************************\n");


int start = ReadConsoleInt("Введите желаемое начало диапазона натуральных чисел: ");
int end = ReadConsoleInt("Введите желаемый конец диапазона натуральных чисел: ");
// если пройдены проверки считаем сумму
if (Checks(start, end)) Console.WriteLine($"\nСумма натуральных чисел от {start} до {end} равна " + SumInt(start));
// если введённые данные не прошли проверку, метод Checks выводит ошибку и программа завершается
else Console.WriteLine("Перезапустите программу и попробуйте снова =)");


int ReadConsoleInt(string message)
{
	Console.Write(message);
	int integerNumber = 0;
	var stringValue = Console.ReadLine();
	if (int.TryParse(stringValue, out integerNumber)) return integerNumber;
	else return -1;
}

int SumInt(int start) // рекурсивный метод сложения натуральных чисел
{
	if (start < end) return SumInt(start+1) + start;
	else return end;
}

bool Checks(int st, int en) // проверяет введённые 2 числа и указывает пользователю на ошибки
{
	if (st <= 0 || en <= 0) // если введён 0, отрицательные или не натуральные(установлено условием else метода ReadConsoleInt()) числа,
	{						// то выводится подсказка и программа завершается
		Console.WriteLine("Вы ввели не натуральное число.");
		return false;
	}
	else if (st > en) // если первое число больше второго запускается метод Change() меняющий их местами, чтобы передать в SumInt() валидные значения
	{
		Change(st, en);
		return true;
	}
	else if (start == end) // если начало и конец диапазона одинаковы просим изменить входные данные и завершаем программу
	{
		Console.WriteLine("Увеличте диапазон чисел.");
		return false;
	}
	else return true;
}

void Change(int a, int b) // меняет значения start и end друг на друга
{
	start = b;
	end = a;
}