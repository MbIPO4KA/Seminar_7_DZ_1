/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


Console.WriteLine("Зададим количество строк в двумерном массиве ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим количество столбцов в массиве ");
int cols= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Зададим минимальное вещественное число ");
double minValue = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Зададим маексимальное вещественное число ");
double maxValue= Convert.ToDouble(Console.ReadLine());

// Создаём метод. Ни чем не заполняем - заполнили с консоли
double[,] GetMatrix()
{          
    double[,] matrix = new double[rows, cols];// Матрица это новый массив сначала строчки rows, потом столбцы cols
    // теперь ЗАПОЛНЯЕМ двумерный массив
    // ОдноМерный массив - это ОДНА строчка, а двумерный - две. 
    //Цикл for надо писать два раза
    for (int i = 0; i < matrix.GetLength(0); i++)
{
     for (int j = 0; j < matrix.GetLength(1); j++)
  matrix[i, j] = Math.Round(100 * (new Random().NextDouble()), 1); // обращаемся к каждому элементу матрицы по его индексам
                                                                 // и округляем во все индексы рандомные числа от 0 до 1 передварительно
                                                                 // умонжив на 100 и оставляем 1 знак после запятой.

}
    return matrix;  // вернули заполненную табличку
}
 // Для того, чтобы увидеть это на экране создаём метод void
 void PrintMatrix(double[,]matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++) // проход по всем строчкам    
    {
         for (int j = 0; j < matr.GetLength(1); j++) // проход по всем столбцам     
        {
            Console.Write(matr[i,j] + "\t"); //  4 пробела
        }
        Console.WriteLine();
    }
 }
//Вызовем наш метод

//  Создадим двумерный массив
// в нашу таблицу resultMatrix должна попасть заполненная таблица с числами от min до max
// чтобы esultMatrix заполнилась значениями мы вызываем метод GetMatrix и в скобках 
// ни чего не указываем, так как все данные введены с консоли
double[,] resultMatrix = GetMatrix(); 

PrintMatrix(resultMatrix);  // Печатаем , вызывая метод void PrintMatrix



