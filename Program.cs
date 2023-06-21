// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string [] array = {"Hello", "2", "world", ":-)", "wxyz", "T9", "77", "qwerty", "yes"};
Console.WriteLine(String.Join(", ", array)); // вывод исходного массива на печать
void PrintArray (string[] arr){// метод обработки и вывода результата на печать
    int length = 0; // переменная, с которой сравнивают элементы исходного массива 
    int j = 0; // счетчик элементов результирующего массива
    string [] result = new string [arr.Length];// создание результирующего массива
    for (int i = 0; i < arr.Length; i++){ //цикл обхода исходного массива
        length = arr[i].Length;// возврат в переменную количества символов в элементе исходного массива
        result[i] = String.Empty;// присвоение элементу результирующего массива пустого значения
        if (length <=3) {// сравнение количества символов в элементе с заданным по условию
            result[j] = arr[i];//присвоение элементу результирующего массива значение элемента исходного массива
            j++; //увеличение счетчика результирующего массива
        }
    }
    int lastIndex = Array.IndexOf(result, String.Empty); //возврат индекса первого пустого элемента в результирующем массиве 
    for (int k = 0; k<lastIndex-1; k++){// цикл обхода результирующего массива до последнего не пустого элемента
        Console.Write($"{result[k]}, ");//печать элемента массива с пробелом и запятой
        } 
    Console.Write(result[lastIndex-1]);// печать последнего не пустого элемента
    Console.WriteLine();
}
PrintArray(array);// вызов метода