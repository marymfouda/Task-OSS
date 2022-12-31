using System;
namespace Task2;
public class Task2{
    private static void Main(){
       var num = Convert.ToInt32(Console.ReadLine());
       var sum = 0;
       for(int i=0 ; i <num ; i++){
        var num1 = Convert.ToInt32(Console.ReadLine());
        sum = sum + num1;
       }
       Console.WriteLine(sum);
    }
}
