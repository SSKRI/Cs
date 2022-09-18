// See https://aka.ms/new-console-template for more information
/*{
    string? name = "T\nom";
    Console.WriteLine(name);
    name = "Mat";
    //name = null;
    Console.WriteLine('\n');
    Console.WriteLine('\n');
    Console.WriteLine('\n');
    Console.WriteLine('\n');
    Console.WriteLine(name);
    Console.WriteLine();
}
{
    const string NAME = "Fa \nrt";
    Console.WriteLine(NAME);
}*/

/*{
    string name = "Аля";
    int age = 34;
    double height = 1.74;
    //Console.WriteLine($"Имя: {name}, возраст: {age}, рост: {height} м, вес: {60+2} кг");
    Console.WriteLine("Имя: {2}, возраст: {1}, рост: {0} м", height, age, name);
    Console.Write($"Имя: {name}, возраст: {age}, рост: {height} м, вес: {60 + 2} кг");
    Console.Write($"Имя: {name}, возраст: {age}, рост: {height} м, вес: {60 + 2} кг");
}
*/
Console.WriteLine("Введите имя: ");
string? name = Console.ReadLine();

Console.WriteLine("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите свой рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name}, рост: {height}, возраст: {age}, зарплатаа: {salary}$");