// Выводим последнюю цифру трехзначного числа 
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последняя цифра "+ a % 10);
