// показать все четные числа от 1 до N
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
    if (a == 1)
    {
        Console.Write("NULL");
    }
while (i <= a)

    {
    
    if ((i % 2) == 0)
    {
    Console.Write(i + ", ");
    
    }
    i= (i+1);

}