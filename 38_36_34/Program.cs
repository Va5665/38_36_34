Console.WriteLine("Введите размер массива"); // введите строку
 int size = Convert.ToInt32(Console.ReadLine()); // Есть какой то размер массива, который отразиться в консооле
 double[]numbers = new double[size]; // есть массив чисел с каким то размером
 FillArrayRandomNumbers(numbers);  // Есть рандомные числа numbers
 Console.WriteLine("Вот наш массив: "); // Вводим фразу Вот наш массив
 PrintArray(numbers); // Есть числа, которые пойдут в консоль
 
 double min = Int32.MaxValue;  // число с запятой дабл - мин
double max = Int32.MinValue;   // число с запятой дабл - мин

 for (int i = 0; i < numbers.Length; i++) //  цикл,                
 {
    if (numbers[i] > max)       
        {
            max = numbers[i];

        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

      Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");                                   
                           
                                               // далее методом VOID создаем цикл рандомных чисел 

void FillArrayRandomNumbers(double[] numbers) // Мы хотим рандомными числами numbersами заполнить массив, это указанно в самом начале , 
                                             //в скобках указывается что это массив чисел
{
    for(int i = 0; i < numbers.Length; i++)  // цикл переберает все индексы 
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;  //  в деопазоне от 100 до 999
        }
}
 
  
                                                                       // делаем цикл для принта на консоль 
void PrintArray(double[] numbers)                                      // у нас есть массив готовый на принт  
{
    Console.Write("[ ");  // Даем указание написать в консоль сначала "["
    for(int i = 0; i < numbers.Length; i++) // делаем цикл при котором печатаем значение каждого индекса, пока не укажем их всех
        {
            Console.Write(numbers[i] + " ");  //даем указание печатать на консоль эти цифры через пробел " "
        }
    Console.Write("]");   // даем указание закрыть это скобкой ]
   
     
         }

