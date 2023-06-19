// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string str = "abcde";
//int length = str.Length;
//Console.WriteLine(length);
string [] array = {"Hello", "2", "world", ":-)"};
Console.WriteLine(String.Join(", ", array)); 
void PrintArray (string[] arr){
    int length = 0;
    for (int i = 0; i < arr.Length; i++){
        length = arr[i].Length;
        if (length <=3) Console.Write($"{arr[i]} ,"); 

    }
    Console.WriteLine();
}
PrintArray(array);