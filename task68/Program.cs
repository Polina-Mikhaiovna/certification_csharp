// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("***********************************************");
Console.WriteLine("**** Программа вычисления функции Аккермана****");
Console.WriteLine("***********************************************\n");


int number = ReadConsoleInt("Введите первый параметр функции: ");
int argument = ReadConsoleInt("Введите второй параметр функции: ");

if (Checks(number, argument)) Console.WriteLine($"\nA({number}, {argument}) = {Ackermann(number, argument)}");
else Console.WriteLine("Перезапустите программу и попробуйте снова =)");


int ReadConsoleInt(string message) // принимает данные из консили и, если это число типа int, возвращает его, иначе -1
{
	Console.Write(message);
	int integerNumber = 0;
	var stringValue = Console.ReadLine(); // сохраняем в переменную без явного типа, то что введено в консоль
	if (int.TryParse(stringValue, out integerNumber)) return integerNumber; // преобразуем принятое значение в целочисленный тип
	else return -1; // в переменную принимающую выходное значение этого метода запишется -1 если возникнет ошибка парсинга
}

bool Checks(int n, int m) // проверяет введённые 2 числа и указывает пользователю на ошибки
{
	if (n < 0 || m < 0) // если введены отрицательные или не натуральные(установлено условием else метода ReadConsoleInt()) числа,
	{					// то выводится подсказка и программа завершается
		Console.WriteLine("Ошибка. Нужно ввести неотрицательные целые числа.");
		return false;
	}
	else return true;
}

int Ackermann(int number, int argument) // принимает два неотрицательных целых числа в качестве параметров,
{										// вычисляет значение функции Аккермана и возвращает натуральное число
	if (number == 0) return argument + 1;
	else
	{
		if ((number != 0) && (argument == 0)) return Ackermann(number - 1, 1);
		else return Ackermann(number - 1, Ackermann(number, argument - 1));
	}
}