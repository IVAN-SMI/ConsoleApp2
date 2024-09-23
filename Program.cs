
    double par1;
    double par2;
    double result = 0;
    char oper;

    Console.WriteLine("Введите первое число");
    par1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    par2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите символ математического действия");
    oper = Convert.ToChar(Console.ReadLine());

if (oper == '+')
{
    result = par1 + par2;
    Console.WriteLine($"{par1} {oper} {par2} = {result}");
}

else if (oper == '-')
{
    result = par1 - par2;
    Console.WriteLine($"{par1} {oper} {par2} = {result}");
}

else if (oper == '*')
{
    result = par1 * par2;
    Console.WriteLine($"{par1} {oper} {par2} = {result}");
}

else if (oper == '/')
{
    if (par2 == 0)
        Console.WriteLine("Ошибка. На ноль делить нельзя");
    else if (oper == '/')
        result = par1 / par2;
    Console.WriteLine($"{par1} {oper} {par2} = {result}");
}
else
{
    Console.WriteLine("Ошибка. Данную операцию выполнить невозможно");
}

Console.ReadKey();
