//1
//Console.WriteLine("Введите длину пароля:");
//int length = int.Parse(Console.ReadLine());

//string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
//Random random = new Random();
//string password = "";

//for (int i = 0; i < length; i++)
//{
//    int index = random.Next(chars.Length);
//    password += chars[index];
//}

//Console.WriteLine("Сгенерированный пароль: " + password);

//2

Random random = new Random();
int temperature = 0;
for (int i = 0; ; i++)
{
    temperature = random.Next(1, 101);
    Console.WriteLine("Текущая температура: " + temperature);

    if (temperature > 90)
    {
        Console.WriteLine("Превышена критическая температура. Остановка устройства.");
        break;
    }
}


