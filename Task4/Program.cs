using System ;
namespace task4;
public class task4{
    private static void Main(){
        Console.WriteLine("please enter element of array ? ");
        var num = Convert.ToInt16(Console.ReadLine());
        var arr = new int [num];
        for (int i = 0 ; i < num ; i ++ ){
            Console.WriteLine("enter num" + (i+1) +" : ");
            arr[i] = Convert.ToInt16(Console.ReadLine()); 

        }
        var max = arr [0];
        for (int i = 0 ; i < num ; i++ ){
            if (arr[i] > max ){
                max = arr[i];
            }
        }
       Console.WriteLine("max is : "+ max);
    }
}
