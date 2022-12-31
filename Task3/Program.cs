using System;
namespace array;
public class array{
    private static void Main(){
        Console.WriteLine("please enter the size of array ?");
        var num = Convert.ToInt32(Console.ReadLine());
        var arr = new int [num];
        for (int i=0 ; i < num ; i ++){
           Console.Write("enter num " + ( i + 1) +" : ");
           arr[i]= Convert.ToInt32(Console.ReadLine()); 

        }
        var sum = 0 ;
        for( int i=0 ; i <num ; i++){
            sum = sum + arr[i]; 
        }
        Console.WriteLine("the sum = " + sum);
    }
}
/*
var arr = new int [5];
var arr = new int [ ] {2 , 3 , 4 , 5};
var arr = new [ ] { 1 , 2 , 3 , 4 };
var arr = new int [ 2 , 3 ];
var arr = new int [ 2 , 3 , 2 ];
*/