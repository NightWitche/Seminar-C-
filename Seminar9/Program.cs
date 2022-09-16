/*// Вариант 1. Калькулятор.

string input1;
double input2;
double input3;
string end = ".";
string end1 = String.Empty;

while (end != end1)
{


    input2 = Convert.ToDouble(Console.ReadLine());
    input1 = Console.ReadLine();
    input3 = Convert.ToDouble(Console.ReadLine());

    double future;
    double result;

    if (input1 == "-")
    {
        result = input2 - input3;
        Console.WriteLine("digit {0} - {1} = {2}", input2, input3, result);
    }
    else if (input1 == "+")
    {
        result = input2 + input3;
        Console.WriteLine("digit {0} + {1} = {2}", input2, input3, result);
    }
    else if (input1 == "/")
    {
        result = input2 / input3;
        Console.WriteLine("digit {0} / {1} = {2}", input2, input3, result);
    }
    else if (input1 == "*")
    {
        result = input2 * input3;
        Console.WriteLine("digit {0} * {1} = {2}", input2, input3, result);
    }
    else if (input1 == "+")
    {
        result = input2 + input3;
        Console.WriteLine("digit {0} + {1} = {2}", input2, input3, result);
    }
    else
    {
        System.Console.WriteLine("Знак не соотвествует условию...");
    }
    Console.WriteLine("Для продолжения нажмите Enter.., Для выхода поставьте '.'");
    end1 = Console.ReadLine();
}
//Вариант 2.

Console.WriteLine("Введите число");
double result = Convert.ToInt32(Console.ReadLine());
char sign = ' ';

while (true)
{
    Console.WriteLine("Введите знак");
    sign = Console.ReadKey().KeyChar;
    if (sign == 'q')
        break;

    Console.WriteLine();

    Console.WriteLine("Введите число");
    int B = Convert.ToInt32(Console.ReadLine());

    switch (sign)
    {
        case '+':
            result = result + B;
            break;
        case '-':
            result = result - B;
            break;
        case '*':
            result = result * B;
            break;
        case '/':
            result = result / B;
            break;
        case '.':

            result = 0;
            break;

        default:
            Console.WriteLine("Error! Wrong sign!");
            break;
    }
    Console.WriteLine($"Result is {result}");
}*/


// кто хочет стать пенсионером.
//вариант 1.

int count = 0;

Console.WriteLine("Вопросик 1:");

string[,] array = {
    {"Какие из перечисленных ниже программ являются антивирусными?",
        "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
    {"Какого типа графики не существует?",
"Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
    {"Когда появился термин «информационные технологии» в современном значении?",
"В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
    {"В каком году компанией IBM был выпущен первый в истории жесткий диск?",
"В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
    {"Какая поисковая система была самой популярной в 2011 году?",
"Yahoo!", "Google", "Bing", "Yandex", "Google"},
    {"Страна лидер по количеству суперкомпьютеров?",
"Китай", "США", "Япония", "Россия", "Китай"},
    {"Какого Интернет-браузера не существует?",
"MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
    {"Какие из клавиш клавиатуры относятся к группе функциональных?",
"Китай", "Россия", "Великобритания", "США", "США"},
    {"Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?",
"F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
    {"Какие из перечисленных ниже программ являются антивирусными?","200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"}
};

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine($"{array[i,0]}");
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        Console.WriteLine($"{array[i,j]}");
    }

    int result = Convert.ToInt32(Console.ReadLine());
    int someNum = 0, key = 0;
    if (result == 5)
    {
        for (int k = 1; k < array.GetLength(1) - 1; k++)
        {
            if(array[i,k] == array[i,5])
            {
                key = k;

                while (true)
                {
                    someNum = new Random().Next(1,5);
                    if(someNum != k)
                    {
                        break;
                    }
                }
            }
        }
        if (someNum > key)
        {
            Console.WriteLine();
            Console.WriteLine(array[i,key]);
        }
    }
    if (array[i, result]  == array[i,5])
    {
        count++;
    }

}


// bool Answer()
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num == 3)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// //вариант 2

// string[] questions = {
// "Какие из перечисленных ниже программ являются антивирусными?",
// "Какого типа графики не существует?",
// "Когда появился термин «информационные технологии» в современном значении?",
// "В каком году компанией IBM был выпущен первый в истории жесткий диск?",
// "Какая поисковая система была самой популярной в 2011 году?",
// "Страна лидер по количеству суперкомпьютеров?",
// "Какого Интернет-браузера не существует?",
// "Какие из клавиш клавиатуры относятся к группе функциональных?",
// "Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП?"
// };

// string[,] answers = {
// {"MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
// {"Растровая", "Векторная", "Облачная", "Трехмерная", "Облачная"},
// {"В 1893 году", "В 1990 году", "В 1958 году", "В 1902 году", "В 1958 году"},
// {"В 1956 году", "В 1958 году", "В 1955 году", "В 1957 году", "В 1956 году"},
// {"Yahoo!", "Google", "Bing", "Yandex", "Google"},
// {"Китай", "США", "Япония", "Россия", "Китай"},
// {"MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
// {"Китай", "Россия", "Великобритания", "США", "США"},
// {"F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
// {"200 МБит/с", "1 МБит/с", "100 МБит/с", "10 МБит/с", "100 МБит/с"}
// };

// (неописано).
