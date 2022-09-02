//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int DedreeOfNumber (int baza, int index){
//     int result = 1;
//     for(int i = 1; i <= index; i++){
//         result *= baza;
//     }
//     return result;
// }

// Console.Write("Введите основание степени: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите показатель степени (натуральное число): ");
// int ind = Convert.ToInt32(Console.ReadLine());

// if (ind < 1) Console.WriteLine("Некорректный ввод показателя степени");
// else {
//     int res = DedreeOfNumber(b, ind);
//     Console.WriteLine ($"{b} в степени {ind} равно {res}");
// }


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Summ(int number){
//     int result = 0;
//     int num = number;
//     if (num<0) num *= -1;
//     while (num > 0){
//         result += num % 10;
//         num /= 10;
//     }
    
//     return result;
// }

// Console.Write("Введите число: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());
// int res = Summ(userNumber);
// Console.WriteLine($"Сумма цифр числа {userNumber} равна {res} ");


//Напишите программу, которая задаёт массив из произвольных элементов и выводит их на экран.

int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        Console.Write($"Введите {i}-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());;
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size));

