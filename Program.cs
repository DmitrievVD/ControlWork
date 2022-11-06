// Программа которая из строк массива формирует новый массив где строка равна меньше 3 символам

// Исходные массивы
string [] arrey = {"Hello", "2", "world", ":-)"};
// string [] arrey = {"1234", "1567", "-2", "computer science"};
// string [] arrey = {"Russia", "Denmark", "Kazan"};

Console.WriteLine("Массив: "+ string.Join(" ",arrey));

string [] arreyFinite = new string [20]; // Новый массив. Туда будем записывать результат
int score = 0;

for (int i = 0; i < arrey.Length; i++) // Алгоритм
{
    if (arrey[i].Length <= 3)
    {
        arreyFinite[score] = arrey[i];
        score++;
    }
}
Console.Write("Результат: "); // Результат
for (int i = 0; i < score; i++)
{
    Console.Write($"{arreyFinite[i]} ");
}
