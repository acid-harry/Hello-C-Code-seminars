// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string Read (string message)
{
Console.WriteLine(message);
return Console.ReadLine();
}
string mess = Read ("Введите любое число , для остановки введите stop");
int count = 0;
while ( mess != "stop")
{
int i = Convert.ToInt32(mess);
if ( i > 0)
{
   count = count + 1;
   mess = Read("Введите любое число , для остановки введите stop");
}
else
{
   mess = Read("Введите любое число , для остановки введите stop");
}
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");