// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string [] array = {"Hello", "2", "world", ":-)", "wxyz", "T9", "77", "qwerty", "yes"};
Console.WriteLine(String.Join(", ", array)); 
void PrintArray (string[] arr){
    int length = 0;
    int j = 0;
    string [] result = new string [arr.Length];
    for (int i = 0; i < arr.Length; i++){
        length = arr[i].Length;
        result[i] = String.Empty;
        if (length <=3) {
            result[j] = arr[i];
            j++; 
        }
    }
    int lastIndex = Array.IndexOf(result, String.Empty);
    for (int k = 0; k<lastIndex-1; k++){
        Console.Write($"{result[k]}, ");
        } 
    Console.Write(result[lastIndex-1]);
    Console.WriteLine();
}
PrintArray(array);