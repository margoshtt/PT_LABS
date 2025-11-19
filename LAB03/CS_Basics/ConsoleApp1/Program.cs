using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА 13 - CS_Basics");
            Console.WriteLine("Основы языка программирования С#");
            Console.WriteLine("Выберите блок задач для выполнения:");
            Console.WriteLine("1 - Переменные и операторы");
            Console.WriteLine("2 - Условные операторы (if-else, switch)");
            Console.WriteLine("3 - Циклы (while, do-while, for)");
            Console.WriteLine("4 - Массивы (одномерные и двумерные)");
            Console.WriteLine("5 - Функции и методы");
            Console.WriteLine("0 - Выход из программы");
            Console.Write("Введите номер блока: ");
            
            string? choice = Console.ReadLine();
            Console.WriteLine();
            
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Неверный ввод!");
                continue;
            }
            
            switch (choice)
            {
                case "0":
                    return;
                case "1":
                    Block1();
                    break;
                case "2":
                    Block2();
                    break;
                case "3":
                    Block3();
                    break;
                case "4":
                    Block4();
                    break;
                case "5":
                    Block5();
                    break;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
        }
    }
    
    
    static void Block1()
    {
        Console.WriteLine("Блок 1: Переменные и операторы");
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("2 - Индекс массы тела (ИМТ)");
        Console.WriteLine("4 - Перевод времени");
        Console.WriteLine("6 - Цена со скидкой");
        Console.WriteLine("0 - Назад");
        Console.Write("Введите номер задачи: ");
        
        string? task = Console.ReadLine();
        Console.WriteLine();
        
        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Неверный ввод!");
            return;
        }
        
        switch (task)
        {
            case "2":
                
                Console.WriteLine("Задача 2: Индекс массы тела");
                Console.Write("Введите рост в см: ");
                string? heightInput = Console.ReadLine();
                Console.Write("Введите вес в кг: ");
                string? weightInput = Console.ReadLine();
                
                if (double.TryParse(heightInput, out double height) && double.TryParse(weightInput, out double weight))
                {
                    double heightMeters = height / 100;
                    double bmi = weight / (heightMeters * heightMeters);
                    bmi = Math.Round(bmi, 1);
                    
                    Console.WriteLine($"Индекс массы тела: {bmi}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "4":
               
                Console.WriteLine("Задача 4: Перевод времени");
                Console.Write("Введите количество секунд: ");
                string? secondsInput = Console.ReadLine();
                
                if (int.TryParse(secondsInput, out int totalSeconds))
                {
                    int hours = totalSeconds / 3600;
                    int minutes = (totalSeconds % 3600) / 60;
                    int seconds = totalSeconds % 60;
                    
                    Console.WriteLine($"{totalSeconds} секунд = {hours}ч {minutes}м {seconds}с");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "6":
               
                Console.WriteLine("Задача 6: Цена со скидкой");
                Console.Write("Введите первоначальную цену: ");
                string? priceInput = Console.ReadLine();
                Console.Write("Введите размер скидки в %: ");
                string? discountInput = Console.ReadLine();
                
                if (double.TryParse(priceInput, out double price) && double.TryParse(discountInput, out double discount))
                {
                    double finalPrice = price * (100 - discount) / 100;
                    Console.WriteLine($"Цена со скидкой: {finalPrice:F2}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
        }
    }
    
   
    static void Block2()
    {
        Console.WriteLine("Блок 2: Условные операторы");
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("2 - Тип треугольника");
        Console.WriteLine("4 - Оценка по числу");
        Console.WriteLine("6 - Конвертация валют");
        Console.WriteLine("0 - Назад");
        Console.Write("Введите номер задачи: ");
        
        string? task = Console.ReadLine();
        Console.WriteLine();
        
        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Неверный ввод!");
            return;
        }
        
        switch (task)
        {
            case "2":
               
                Console.WriteLine("Задача 2: Тип треугольника");
                Console.Write("Введите сторону A: ");
                string? aInput = Console.ReadLine();
                Console.Write("Введите сторону B: ");
                string? bInput = Console.ReadLine();
                Console.Write("Введите сторону C: ");
                string? cInput = Console.ReadLine();
                
                if (double.TryParse(aInput, out double a) && 
                    double.TryParse(bInput, out double b) && 
                    double.TryParse(cInput, out double c))
                {
                    if (a == b && b == c)
                        Console.WriteLine("Треугольник равносторонний");
                    else if (a == b || a == c || b == c)
                        Console.WriteLine("Треугольник равнобедренный");
                    else
                        Console.WriteLine("Треугольник разносторонний");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "4":
               
                Console.WriteLine("Задача 4: Оценка по числу");
                Console.Write("Введите оценку (1-5): ");
                string? gradeInput = Console.ReadLine();
                
                if (int.TryParse(gradeInput, out int grade))
                {
                    switch (grade)
                    {
                        case 1:
                            Console.WriteLine("Плохо");
                            break;
                        case 2:
                            Console.WriteLine("Неудовлетворительно");
                            break;
                        case 3:
                            Console.WriteLine("Удовлетворительно");
                            break;
                        case 4:
                            Console.WriteLine("Хорошо");
                            break;
                        case 5:
                            Console.WriteLine("Отлично");
                            break;
                        default:
                            Console.WriteLine("Неверная оценка");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "6":
               
                Console.WriteLine("Задача 6: Конвертация валют");
                Console.Write("Введите сумму в рублях: ");
                string? rublesInput = Console.ReadLine();
                
                if (double.TryParse(rublesInput, out double rubles))
                {
                    Console.WriteLine("Выберите валюту:");
                    Console.WriteLine("1 - Доллар (0.011)");
                    Console.WriteLine("2 - Фунт (0.0085)");
                    Console.WriteLine("3 - Евро (0.01)");
                    Console.Write("Ваш выбор: ");
                    string? currencyInput = Console.ReadLine();
                    
                    if (int.TryParse(currencyInput, out int currency))
                    {
                        double result = 0;
                        switch (currency)
                        {
                            case 1:
                                result = rubles * 0.011;
                                Console.WriteLine($"{rubles} руб = {result:F2} долларов");
                                break;
                            case 2:
                                result = rubles * 0.0085;
                                Console.WriteLine($"{rubles} руб = {result:F2} фунтов");
                                break;
                            case 3:
                                result = rubles * 0.01;
                                Console.WriteLine($"{rubles} руб = {result:F2} евро");
                                break;
                            default:
                                Console.WriteLine("Неверный выбор валюты");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода данных!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
        }
    }
    
   
    static void Block3()
    {
        Console.WriteLine("Блок 3: Циклы");
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("2 - Переворот числа");
        Console.WriteLine("4 - Максимальное нечётное число");
        Console.WriteLine("6 - Арифметическая прогрессия");
        Console.WriteLine("0 - Назад");
        Console.Write("Введите номер задачи: ");
        
        string? task = Console.ReadLine();
        Console.WriteLine();
        
        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Неверный ввод!");
            return;
        }
        
        switch (task)
        {
            case "2":
              
                Console.WriteLine("Задача 2: Переворот числа");
                Console.Write("Введите число: ");
                string? numberInput = Console.ReadLine();
                
                if (int.TryParse(numberInput, out int number))
                {
                    int reversed = 0;
                    int temp = number;
                    while (temp > 0)
                    {
                        reversed = reversed * 10 + temp % 10;
                        temp /= 10;
                    }
                    Console.WriteLine($"Перевернутое число: {reversed}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "4":
              
                Console.WriteLine("Задача 4: Максимальное нечётное число");
                Console.Write("Введите начало диапазона: ");
                string? aInput = Console.ReadLine();
                Console.Write("Введите конец диапазона: ");
                string? bInput = Console.ReadLine();
                
                if (int.TryParse(aInput, out int a) && int.TryParse(bInput, out int b))
                {
                    int maxOdd = -1;
                    for (int i = a; i <= b; i++)
                    {
                        if (i % 2 != 0 && i > maxOdd)
                        {
                            maxOdd = i;
                        }
                    }
                    
                    if (maxOdd != -1)
                        Console.WriteLine($"Максимальное нечётное число: {maxOdd}");
                    else
                        Console.WriteLine("Нечётных чисел в диапазоне нет");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "6":
             
                Console.WriteLine("Задача 6: Арифметическая прогрессия");
                Console.Write("Введите количество членов: ");
                string? nInput = Console.ReadLine();
                Console.Write("Введите первый член: ");
                string? firstInput = Console.ReadLine();
                Console.Write("Введите шаг прогрессии: ");
                string? stepInput = Console.ReadLine();
                
                if (int.TryParse(nInput, out int n) && 
                    double.TryParse(firstInput, out double first) && 
                    double.TryParse(stepInput, out double step))
                {
                    double sum = 0;
                    double current = first;
                    Console.Write("Члены прогрессии: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"{current} ");
                        sum += current;
                        current += step;
                    }
                    Console.WriteLine($"\nСумма: {sum}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
        }
    }
    
    
    static void Block4()
    {
        Console.WriteLine("Блок 4: Массивы");
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("2 - Второй по величине элемент");
        Console.WriteLine("4 - Чётные элементы в столбцах");
        Console.WriteLine("6 - Диагонали матрицы");
        Console.WriteLine("0 - Назад");
        Console.Write("Введите номер задачи: ");
        
        string? task = Console.ReadLine();
        Console.WriteLine();
        
        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Неверный ввод!");
            return;
        }
        
        switch (task)
        {
            case "2":
               
                Console.WriteLine("Задача 2: Второй по величине элемент");
                Console.Write("Введите размер массива: ");
                string? sizeInput = Console.ReadLine();
                
                if (int.TryParse(sizeInput, out int size) && size > 0)
                {
                    int[] array = new int[size];
                    Random rand = new Random();
                    
                    Console.Write("Массив: ");
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = rand.Next(1, 101);
                        Console.Write($"{array[i]} ");
                    }
                    Console.WriteLine();
                    
                    int max1 = 0, max2 = 0, maxIndex = 0, secondIndex = 0;
                    
                   
                    for (int i = 0; i < size; i++)
                    {
                        if (array[i] > max1)
                        {
                            max1 = array[i];
                            maxIndex = i;
                        }
                    }
                    
                   
                    for (int i = 0; i < size; i++)
                    {
                        if (array[i] > max2 && array[i] < max1)
                        {
                            max2 = array[i];
                            secondIndex = i;
                        }
                    }
                    
                    Console.WriteLine($"Второй по величине элемент: {max2}");
                    Console.WriteLine($"Его индекс: {secondIndex}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "4":
               
                Console.WriteLine("Задача 4: Чётные элементы в столбцах");
                Console.Write("Введите количество строк: ");
                string? rowsInput = Console.ReadLine();
                Console.Write("Введите количество столбцов: ");
                string? colsInput = Console.ReadLine();
                
                if (int.TryParse(rowsInput, out int rows) && rows > 0 && 
                    int.TryParse(colsInput, out int cols) && cols > 0)
                {
                    int[,] matrix = new int[rows, cols];
                    Random rand2 = new Random();
                    
                    Console.WriteLine("Матрица:");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[i, j] = rand2.Next(1, 101);
                            Console.Write($"{matrix[i, j],3} ");
                        }
                        Console.WriteLine();
                    }
                    
                    int[] evenCount = new int[cols];
                    
                  
                    for (int j = 0; j < cols; j++)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            if (matrix[i, j] % 2 == 0)
                            {
                                evenCount[j]++;
                            }
                        }
                    }
                    
                   
                    int maxEvenCol = 0;
                    int maxEvenCount = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        Console.WriteLine($"Столбец {j}: {evenCount[j]} четных элементов");
                        if (evenCount[j] > maxEvenCount)
                        {
                            maxEvenCount = evenCount[j];
                            maxEvenCol = j;
                        }
                    }
                    
                    Console.WriteLine($"Столбец с максимальным количеством четных: {maxEvenCol}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
                
            case "6":
                Console.WriteLine("Задача 6: Диагонали матрицы");
                Console.Write("Введите размер квадратной матрицы: ");
                string? nInput = Console.ReadLine();
                
                if (int.TryParse(nInput, out int n) && n > 0)
                {
                    int[,] squareMatrix = new int[n, n];
                    Random rand3 = new Random();
                    
                    Console.WriteLine("Матрица:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            squareMatrix[i, j] = rand3.Next(1, 101);
                            Console.Write($"{squareMatrix[i, j],3} ");
                        }
                        Console.WriteLine();
                    }
                    
                    int maxMain = 0, maxSecondary = 0;
                    
                    for (int i = 0; i < n; i++)
                    {
                        if (squareMatrix[i, i] > maxMain)
                        {
                            maxMain = squareMatrix[i, i];
                        }
                    }
                    
                   
                    for (int i = 0; i < n; i++)
                    {
                        if (squareMatrix[i, n - 1 - i] > maxSecondary)
                        {
                            maxSecondary = squareMatrix[i, n - 1 - i];
                        }
                    }
                    
                    Console.WriteLine($"Максимум на главной диагонали: {maxMain}");
                    Console.WriteLine($"Максимум на побочной диагонали: {maxSecondary}");
                    Console.WriteLine($"Сумма максимумов: {maxMain + maxSecondary}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }
                break;
        }
    }
    

    static void Block5()
    {
        Console.WriteLine("Блок 5: Функции");
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("2 - Генерация массива");
        Console.WriteLine("4 - Сумма цифр числа (рекурсия)");
        Console.WriteLine("6 - Разделение числа");
        Console.WriteLine("8 - Длины строк");
        Console.WriteLine("0 - Назад");
        Console.Write("Введите номер задачи: ");
        
        string? task = Console.ReadLine();
        Console.WriteLine();
        
        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Неверный ввод!");
            return;
        }
        
        switch (task)
{
    case "2":
        
        Console.WriteLine("Задача 2: Генерация массива");
        int[] array = GenerateArray(5, 1, 100);
        Console.Write("Сгенерированный массив: ");
        foreach (int num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        break;
        
    case "4":
       
        Console.WriteLine("Задача 4: Сумма цифр числа");
        Console.Write("Введите число: ");
        string? numberInput = Console.ReadLine();
        
        if (int.TryParse(numberInput, out int number))
        {
            int sum = DigitSum(number);
            Console.WriteLine($"Сумма цифр: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода данных!");
        }
        break;
        
    case "6":
        
        Console.WriteLine("Задача 6: Разделение числа");
        Console.Write("Введите число: ");
        string? numInput = Console.ReadLine();
        
        if (double.TryParse(numInput, out double inputNumber))
        {
            Split(inputNumber, out int whole, out double fraction);
            Console.WriteLine($"Целая часть: {whole}");
            Console.WriteLine($"Дробная часть: {fraction}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода данных!");
        }
        break;
        
    case "8":
       
        Console.WriteLine("Задача 8: Длины строк");
        int[] lengths = GetLengths("My", "Name", "Is", "Jabbar", "I", "Live", "In", "Qatar");
        Console.Write("Длины строк: ");
        foreach (int len in lengths)
        {
            Console.Write($"{len} ");
        }
        Console.WriteLine();
        break;
}
    }
    
    
    static int[] GenerateArray(int count, int min, int max)
    {
        int[] array = new int[count];
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            array[i] = rand.Next(min, max + 1);
        }
        return array;
    }
    
    static int DigitSum(int number)
    {
        if (number == 0)
            return 0;
        return number % 10 + DigitSum(number / 10);
    }
    
    static void Split(double number, out int whole, out double fraction)
    {
        whole = (int)number;
        fraction = number - whole;
    }
    
    static int[] GetLengths(params string[] strings)
    {
        int[] lengths = new int[strings.Length];
        for (int i = 0; i < strings.Length; i++)
        {
            lengths[i] = strings[i].Length;
        }
        return lengths;
    }
}
