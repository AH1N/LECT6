using System.Linq; // Подключаем библиотеку System.Linq - непонятно нахуа....

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(" , "")   // тут удаляем скобку, заменяем на пробел
                .Replace(")" , "");  // тут удаляем скобку, заменяем на пробел

var data = text.Split(" ") // Разделяем строку символом "ПРОБЕЛ"
               .Select(item => item.Split(",")) // тут слабо понял, надо спросить на паре будет
               .Select(e=> (x: int.Parse(e[0]),y: int.Parse(e[1])))  // " x: " - указываем что это Х, " y: " - указываем что это Y
               .Where(e => e.x % 2 == 0)
               .Select(point => (point.x*10, point.y))
               .ToArray(); // Конвертируем строку сразу в массив

for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]); 
    System.Console.WriteLine();  
}